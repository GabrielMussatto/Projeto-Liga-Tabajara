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
    public class LigasController : Controller
    {
        private LigaContext db = new LigaContext();

        // GET: Ligas
        public ActionResult Index()
        {
            // 1) Carrega todas as ligas junto com os seus times
            var ligas = db.Ligas
                          .Include(l => l.Times)
                          .ToList();

            // 2) Para cada liga, recalcula o status
            foreach (var liga in ligas)
            {
                bool apta = false;

                if (liga.Times != null && liga.Times.Count == 20)
                {
                    // só está apta se TODOS os 20 times estiverem aptos
                    apta = liga.Times.All(t => t.Status == true);
                    apta = true;
                }

                // atualiza o campo se necessário
                if (liga.Status != apta)
                {
                    liga.Status = apta;
                    db.Entry(liga).State = EntityState.Modified;
                }
            }

            db.SaveChanges();

            return View(ligas);
        }

        // GET: Ligas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var liga = db.Ligas.Include(l => l.Times)
                                .FirstOrDefault(l => l.Id == id);
            if (liga == null)
                return HttpNotFound();
            return View(liga);
        }

        // GET: Ligas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ligas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome")] Liga liga)
        {
            if (ModelState.IsValid)
            {
                liga.Status = false;
                liga.Times = new List<Time>();
                db.Ligas.Add(liga);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(liga);
        }

        // GET: Ligas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var liga = db.Ligas.Find(id);
            if (liga == null)
                return HttpNotFound();
            return View(liga);
        }

        // POST: Ligas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome")] Liga liga)
        {
            if (ModelState.IsValid)
            {
                var ligaDB = db.Ligas.Find(liga.Id);
                if (ligaDB == null)
                    return HttpNotFound();

                ligaDB.Nome = liga.Nome;
                db.Entry(ligaDB).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(liga);
        }

        // GET: Ligas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            var liga = db.Ligas.Find(id);
            if (liga == null)
                return HttpNotFound();
            return View(liga);
        }

        // POST: Ligas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var liga = db.Ligas.Find(id);
            db.Ligas.Remove(liga);
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