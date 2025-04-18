using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projeto_Liga_Tabajara.DataBase;
using Projeto_Liga_Tabajara.Models;

namespace Projeto_Liga_Tabajara.Controllers
{
    public class JogadorsController : Controller
    {
        private LigaContext db = new LigaContext();

        // GET: Jogadors
        public ActionResult Index(string nome, Posicao? posicao, PePreferido? pePreferido)
        {
            // Carrega todos já com o Time
            var jogadores = db.Jogadores.Include(j => j.Time).AsQueryable();

            // filtros
            if (!String.IsNullOrWhiteSpace(nome))
                jogadores = jogadores.Where(j => j.Nome.Contains(nome));
            if (posicao.HasValue)
                jogadores = jogadores.Where(j => j.Posicao == posicao.Value);
            if (pePreferido.HasValue)
                jogadores = jogadores.Where(j => j.PePreferido == pePreferido.Value);

            // para manter nos dropdowns
            ViewBag.NomeFilter = nome;
            ViewBag.PosicaoList = new SelectList(Enum.GetValues(typeof(Posicao)));
            ViewBag.SelectedPosicao = posicao;
            ViewBag.PePreferidoList = new SelectList(Enum.GetValues(typeof(PePreferido)));
            ViewBag.SelectedPePreferido = pePreferido;

            return View(jogadores.ToList());
        }

        // GET: Jogadors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jogador jogador = db.Jogadores.Find(id);
            if (jogador == null)
            {
                return HttpNotFound();
            }
            return View(jogador);
        }

        // GET: Jogadors/Create
        public ActionResult Create()
        {
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome");
            return View();
        }

        // POST: Jogadors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,DataNascimento,Nacionalidade,Posicao,NumeroCamisa,Altura,Peso,PePreferido,TimeId")] Jogador jogador)
        {
            // Validação: não permitir cadastro duplicado (mesmo Nome e DataNascimento)
            bool jogadorJaExiste = db.Jogadores.Any(j => j.Nome == jogador.Nome);
            if (jogadorJaExiste)
            {
                ModelState.AddModelError("", "Já existe um jogador com esse nome cadastrado.");
            }

            if (ModelState.IsValid)
            {
                db.Jogadores.Add(jogador);
                db.SaveChanges();

                // Após cadastro, atualiza o status do time associado
                AtualizarStatusTime(jogador.TimeId);

                return RedirectToAction("Index");
            }

            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
            return View(jogador);
        }

        // GET: Jogadors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jogador jogador = db.Jogadores.Find(id);
            if (jogador == null)
            {
                return HttpNotFound();
            }
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
            return View(jogador);
        }

        // POST: Jogadors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,DataNascimento,Nacionalidade,Posicao,NumeroCamisa,Altura,Peso,PePreferido,TimeId")] Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jogador).State = EntityState.Modified;
                db.SaveChanges();

                // Após a edição, atualiza o status do time vinculado
                AtualizarStatusTime(jogador.TimeId);

                return RedirectToAction("Index");
            }
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", jogador.TimeId);
            return View(jogador);
        }

        // GET: Jogadors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jogador jogador = db.Jogadores.Find(id);
            if (jogador == null)
            {
                return HttpNotFound();
            }
            return View(jogador);
        }

        // POST: Jogadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jogador jogador = db.Jogadores.Find(id);
            int timeId = jogador.TimeId;
            db.Jogadores.Remove(jogador);
            db.SaveChanges();

            // Atualiza o status do time após a remoção do jogador
            AtualizarStatusTime(timeId);

            return RedirectToAction("Index");
        }

        // Método auxiliar que atualiza o status do time, verificando se o mesmo está apto para competir
        private void AtualizarStatusTime(int timeId)
        {
            var time = db.Times.Include(t => t.Jogadores)
                               .Include(t => t.ComissaoTecnica)
                               .FirstOrDefault(t => t.Id == timeId);
            if (time != null)
            {
                time.Status = VerificarTimeApto(time);
                db.Entry(time).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        // Método que verifica se o time está apto para competir
        private bool VerificarTimeApto(Time time)
        {
            // 1) Jogadores: mínimo de 30
            if (time.Jogadores == null || time.Jogadores.Count < 29)
                return false;

            // 2) Posições obrigatórias
            var posicoesObrigatorias = new[]
            {
                Posicao.Goleiro,
                Posicao.Zagueiro,
                Posicao.Volante,
                Posicao.Meia,
                Posicao.Atacante,
                Posicao.Lateraldireito,
                Posicao.Lateralesquerdo
            };
            // para cada posição, deve haver ao menos 1 jogador nela
            if (!posicoesObrigatorias.All(pos =>
                time.Jogadores.Any(j => j.Posicao == pos)))
            {
                return false;
            }

            // 3) Comissão técnica: mínimo de 5
            if (time.ComissaoTecnica == null || time.ComissaoTecnica.Count < 4)
                return false;

            // 4) Sem cargos duplicados
            if (time.ComissaoTecnica
                    .GroupBy(ct => ct.Cargo)
                    .Any(g => g.Count() > 1))
            {
                return false;
            }

            // só chega aqui se passou em todas as checagens
            return true;
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}