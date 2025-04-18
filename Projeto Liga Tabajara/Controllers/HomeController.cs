using System.Linq;
using System.Data.Entity;
using System.Web.Mvc;
using Projeto_Liga_Tabajara.DataBase;
using Projeto_Liga_Tabajara.Models;
using System.Collections.Generic;

namespace Projeto_Liga_Tabajara.Controllers
{
    public class HomeController : Controller
    {
        private LigaContext db = new LigaContext();

        public ActionResult Index()
        {
            // 1) Carrega todos os times
            var times = db.Times
                          .Include(t => t.Jogadores)
                          .Include(t => t.ComissaoTecnica)
                          .ToList();

            // 2) Carrega ou cria a Liga
            var liga = db.Ligas.Include(l => l.Times).FirstOrDefault();
            if (liga == null)
            {
                liga = new Liga { Nome = "Liga Tabajara de Futebol", Status = false, Times = new List<Time>() };
                db.Ligas.Add(liga);
            }
            liga.Times = times;

            // 3) Atualiza status da liga
            liga.Status = (times.Count == 20 && times.All(t => t.Status));
            db.Entry(liga).State = liga.Id == 0 ? EntityState.Added : EntityState.Modified;
            db.SaveChanges();

            // 4) Monta o ranking com partidas já realizadas
            var realizadas = db.Partidas
                               .Where(p => p.Resultado != Resultado.NaoRealizada)
                               .ToList();

            var dict = times.ToDictionary(
                t => t.Id,
                t => new ClassificacaoTime
                {
                    TimeId = t.Id,
                    TimeNome = t.Nome,
                    Pontos = 0,
                    Jogos = 0,
                    Vitorias = 0,
                    Empates = 0,
                    Derrotas = 0,
                    GolsPro = 0,
                    GolsContra = 0
                });

            foreach (var p in realizadas)
            {
                var mand = dict[p.TimeMandanteId];
                var vis = dict[p.TimeVisitanteId];

                mand.Jogos++;
                vis.Jogos++;

                mand.GolsPro += p.GolsMandante;
                mand.GolsContra += p.GolsVisitante;
                vis.GolsPro += p.GolsVisitante;
                vis.GolsContra += p.GolsMandante;

                switch (p.Resultado)
                {
                    case Resultado.VitoriaMandante:
                        mand.Vitorias++; mand.Pontos += 3;
                        vis.Derrotas++;
                        break;
                    case Resultado.VitoriaVisitante:
                        vis.Vitorias++; vis.Pontos += 3;
                        mand.Derrotas++;
                        break;
                    case Resultado.Empate:
                        mand.Empates++; vis.Empates++;
                        mand.Pontos++; vis.Pontos++;
                        break;
                }
            }

            var classification = dict.Values.ToList();

            // 4) Habilita “Ver Campeão” somente se todos jogaram 38 partidas
            bool allPlayed38 = classification.All(c => c.Jogos == 38);
            ViewBag.AllResultsIn = allPlayed38;
            ViewBag.ChampionName = allPlayed38
                                    ? classification
                                        .OrderByDescending(c => c.Pontos)
                                        .ThenByDescending(c => c.SaldoGols)
                                        .First()
                                        .TimeNome
                                    : null;

            // 5) Ordena para exibir
            var ranking = classification
                          .OrderByDescending(c => c.Pontos)
                          .ThenByDescending(c => c.SaldoGols)
                          .ToList();

            ViewBag.Classificacao = ranking;
            return View(liga);
        }
    }
}