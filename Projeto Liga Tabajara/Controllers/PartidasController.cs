using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Projeto_Liga_Tabajara.DataBase;
using Projeto_Liga_Tabajara.Models;

namespace Projeto_Liga_Tabajara.Controllers
{
    public class PartidasController : Controller
    {
        private LigaContext db = new LigaContext();

        // GET: Partidas
        public ActionResult Index(string time, string estadio)
        {
            // 1) Base query já incluindo navegações
            var partidas = db.Partidas
                             .Include(p => p.TimeMandante)
                             .Include(p => p.TimeVisitante)
                             .AsQueryable();

            // 2) Filtro por time (mandante ou visitante)
            if (!String.IsNullOrWhiteSpace(time))
            {
                partidas = partidas.Where(p =>
                    p.TimeMandante.Nome.Contains(time) ||
                    p.TimeVisitante.Nome.Contains(time)
                );
            }

            // 3) Filtro por estádio
            if (!String.IsNullOrWhiteSpace(estadio))
            {
                partidas = partidas.Where(p =>
                    p.Estadio.Contains(estadio)
                );
            }

            // 4) Ordenação
            partidas = partidas.OrderBy(p => p.Rodada)
                               .ThenBy(p => p.Data);

            // 5) Mantém valores nos campos de busca
            ViewBag.TimeFilter = time;
            ViewBag.EstadioFilter = estadio;

            return View(partidas.ToList());
        }

        // GET: Partidas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var partida = db.Partidas
                             .Include(p => p.TimeMandante)
                             .Include(p => p.TimeVisitante)
                             .Include(p => p.Estatisticas.Select(e => e.Jogador.Time))
                             .FirstOrDefault(p => p.Id == id);

            if (partida == null) return HttpNotFound();
            return View(partida);
        }



        // GET: Partidas/GerarPartidas
        public ActionResult GerarPartidas()
        {
            return View();
        }

        // POST: Partidas/GerarPartidasConfirmed
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult GerarPartidasConfirmed()
        {
            var times = db.Times.ToList();
            if (times.Count != 20)
            {
                TempData["Erro"] = "São necessários exatamente 20 times para gerar as partidas.";
                return RedirectToAction("Index");
            }

            // Limpa partidas existentes
            db.Partidas.RemoveRange(db.Partidas);
            db.SaveChanges();

            // Round‑robin (círculo) para 20 times
            int n = times.Count;
            var rotation = new List<Time>(times);
            int rounds = n - 1;
            int matchesPerRound = n / 2;
            var schedule = new List<List<(Time home, Time away)>>();

            // Ida
            for (int round = 0; round < rounds; round++)
            {
                var pairs = new List<(Time, Time)>();
                for (int i = 0; i < matchesPerRound; i++)
                    pairs.Add((rotation[i], rotation[n - 1 - i]));
                schedule.Add(pairs);

                var last = rotation[n - 1];
                rotation.RemoveAt(n - 1);
                rotation.Insert(1, last);
            }

            // Volta (inverte casa/fora)
            var fullSchedule = new List<List<(Time, Time)>>(schedule);
            fullSchedule.AddRange(schedule.Select(r =>
                r.Select(p => (home: p.away, away: p.home)).ToList()
            ));

            // Agendamento semanal
            DateTime startDate = DateTime.Today.AddDays(7);
            int intervalDays = 7;
            var partidas = new List<Partida>();

            for (int r = 0; r < fullSchedule.Count; r++)
            {
                DateTime matchDate = startDate.AddDays(r * intervalDays);
                foreach (var (home, away) in fullSchedule[r])
                {
                    partidas.Add(new Partida
                    {
                        TimeMandanteId = home.Id,
                        TimeVisitanteId = away.Id,
                        Data = matchDate,
                        Estadio = home.Estadio,
                        Rodada = r + 1,
                        GolsMandante = 0,
                        GolsVisitante = 0,
                        Resultado = Resultado.NaoRealizada
                    });
                }
            }

            db.Partidas.AddRange(partidas);
            db.SaveChanges();

            TempData["Mensagem"] = "Calendário de 38 rodadas gerado com sucesso!";
            return RedirectToAction("Index");
        }

        // GET: Partidas/AtualizarResultado/5
        public ActionResult AtualizarResultado(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            // Carrega a partida com os jogadores de mandante e visitante
            var partida = db.Partidas
                            .Include(p => p.TimeMandante.Jogadores)
                            .Include(p => p.TimeVisitante.Jogadores)
                            .FirstOrDefault(p => p.Id == id);

            if (partida == null)
                return HttpNotFound();

            // Monta o ViewModel, incluindo posição de cada jogador
            var vm = new RegistrarPlacarViewModel
            {
                PartidaId = partida.Id,
                MandanteNome = partida.TimeMandante.Nome,
                VisitanteNome = partida.TimeVisitante.Nome,
                Data = partida.Data,

                Mandante = partida.TimeMandante.Jogadores
                    .Select(j => new JogadorGolsViewModel
                    {
                        JogadorId = j.Id,
                        Nome = j.Nome,
                        Posicao = j.Posicao,  // <-- aqui
                        Gols = 0
                    })
                    .ToList(),

                Visitante = partida.TimeVisitante.Jogadores
                    .Select(j => new JogadorGolsViewModel
                    {
                        JogadorId = j.Id,
                        Nome = j.Nome,
                        Posicao = j.Posicao,  // <-- e aqui
                        Gols = 0
                    })
                    .ToList()
            };

            return View(vm);
        }

        // POST: Partidas/AtualizarResultado/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AtualizarResultado(RegistrarPlacarViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);

            var partida = db.Partidas.Find(vm.PartidaId);
            if (partida == null) return HttpNotFound();

            // soma dos gols
            int somaMandante = vm.Mandante.Sum(j => j.Gols);
            int somaVisitante = vm.Visitante.Sum(j => j.Gols);

            partida.GolsMandante = somaMandante;
            partida.GolsVisitante = somaVisitante;

            if (somaMandante > somaVisitante) partida.Resultado = Resultado.VitoriaMandante;
            else if (somaMandante < somaVisitante) partida.Resultado = Resultado.VitoriaVisitante;
            else partida.Resultado = Resultado.Empate;

            // remover estatísticas antigas
            var antigas = db.Estatisticas.Where(e => e.PartidaId == partida.Id);
            db.Estatisticas.RemoveRange(antigas);

            // criar novas estatísticas
            foreach (var j in vm.Mandante.Where(j => j.Gols > 0))
                db.Estatisticas.Add(new Estatistica
                {
                    PartidaId = partida.Id,
                    JogadorId = j.JogadorId,
                    Gols = j.Gols
                });
            foreach (var j in vm.Visitante.Where(j => j.Gols > 0))
                db.Estatisticas.Add(new Estatistica
                {
                    PartidaId = partida.Id,
                    JogadorId = j.JogadorId,
                    Gols = j.Gols
                });

            db.Entry(partida).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Details", new { id = partida.Id });
        }


        // GET: Partidas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            var partida = db.Partidas.Find(id);
            if (partida == null) return HttpNotFound();
            return View(partida);
        }

        // POST: Partidas/Delete/5
        [HttpPost, ActionName("Delete"), ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var partida = db.Partidas.Find(id);
            db.Partidas.Remove(partida);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) db.Dispose();
            base.Dispose(disposing);
        }
    }
}