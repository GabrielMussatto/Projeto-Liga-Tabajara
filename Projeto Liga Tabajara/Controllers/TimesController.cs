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
    public class TimesController : Controller
    {
        private LigaContext db = new LigaContext();

        // GET: Times
        public ActionResult Index(string nome, string estadio)
        {
            // carrega todos os times, já com jogadores e comissão
            var query = db.Times
                          .Include(t => t.Jogadores)
                          .Include(t => t.ComissaoTecnica)
                          .AsQueryable();

            // aplica filtros, se vierem parâmetros
            if (!String.IsNullOrEmpty(nome))
                query = query.Where(t => t.Nome.Contains(nome));

            if (!String.IsNullOrEmpty(estadio))
                query = query.Where(t => t.Estadio.Contains(estadio));

            var times = query.ToList();

            // recalcula status de cada um
            foreach (var t in times)
            {
                t.Status = VerificarTimeApto(t);
                db.Entry(t).State = EntityState.Modified;
            }
            db.SaveChanges();

            // guarda para manter o texto nos inputs depois do postback
            ViewBag.NomeFilter = nome;
            ViewBag.EstadioFilter = estadio;

            return View(times);
        }

        // GET: Times/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Time time = db.Times.Include(t => t.Jogadores)
                                .Include(t => t.ComissaoTecnica)
                                .FirstOrDefault(t => t.Id == id);
            if (time == null)
                return HttpNotFound();
            return View(time);
        }

        // GET: Times/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Times/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Time time)
        {
            if (ModelState.IsValid)
            {
                // Inicialmente, o time não está apto
                time.Status = false;
                db.Times.Add(time);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(time);
        }

        // GET: Times/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Time time = db.Times.Find(id);
            if (time == null)
                return HttpNotFound();
            return View(time);
        }

        // POST: Times/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Time time)
        {
            if (ModelState.IsValid)
            {
                db.Entry(time).State = EntityState.Modified;
                db.SaveChanges();
                // Após qualquer alteração, você pode chamar um método para atualizar o status do time:
                AtualizarStatusTime(time.Id);
                return RedirectToAction("Index");
            }
            return View(time);
        }

        // Método auxiliar para atualizar o status do time
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

        // GET: Times/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Time time = db.Times.Find(id);
            if (time == null)
            {
                return HttpNotFound();
            }
            return View(time);
        }

        // POST: Times/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Time time = db.Times.Find(id);
            db.Times.Remove(time);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            base.Dispose(disposing);
        }
    }
}
