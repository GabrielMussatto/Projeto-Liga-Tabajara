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
    public class ComissaoTecnicasController : Controller
    {
        private LigaContext db = new LigaContext();

        // GET: ComissaoTecnicas
        public ActionResult Index(string nome, Cargo? cargo)
        {
            // 1) Carrega todas comissões já incluindo o Time
            var comissoes = db.ComissoesTecnicas
                              .Include(c => c.Time)
                              .AsQueryable();

            // 2) Aplica filtro por nome, se informado
            if (!String.IsNullOrWhiteSpace(nome))
                comissoes = comissoes.Where(c => c.Nome.Contains(nome));

            // 3) Aplica filtro por cargo, se selecionado
            if (cargo.HasValue)
                comissoes = comissoes.Where(c => c.Cargo == cargo.Value);

            // 4) Prepara ViewBag para manter valores nos controles
            ViewBag.NomeFilter = nome;
            ViewBag.CargoList = new SelectList(Enum.GetValues(typeof(Cargo)));
            ViewBag.SelectedCargo = cargo;

            // 5) Executa a consulta e retorna à view
            return View(comissoes.ToList());
        }

        // GET: ComissaoTecnicas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            ComissaoTecnica comissaoTecnica = db.ComissoesTecnicas.Find(id);
            if (comissaoTecnica == null)
                return HttpNotFound();

            return View(comissaoTecnica);
        }

        // GET: ComissaoTecnicas/Create
        public ActionResult Create()
        {
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome");
            return View();
        }

        // POST: ComissaoTecnicas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Cargo,DataNascimento,TimeId")] ComissaoTecnica comissaoTecnica)
        {
            // Verifica se já existe um membro com o mesmo cargo para o mesmo time
            bool cargoJaCadastrado = db.ComissoesTecnicas.Any(c => c.TimeId == comissaoTecnica.TimeId && c.Cargo == comissaoTecnica.Cargo);
            if (cargoJaCadastrado)
            {
                ModelState.AddModelError("", "Já existe um profissional com esse cargo para o time.");
            }

            if (ModelState.IsValid)
            {
                db.ComissoesTecnicas.Add(comissaoTecnica);
                db.SaveChanges();

                // Atualiza o status do time vinculado
                AtualizarStatusTime(comissaoTecnica.TimeId);

                return RedirectToAction("Index");
            }

            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", comissaoTecnica.TimeId);
            return View(comissaoTecnica);
        }

        // GET: ComissaoTecnicas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            ComissaoTecnica comissaoTecnica = db.ComissoesTecnicas.Find(id);
            if (comissaoTecnica == null)
                return HttpNotFound();

            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", comissaoTecnica.TimeId);
            return View(comissaoTecnica);
        }

        // POST: ComissaoTecnicas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Cargo,DataNascimento,TimeId")] ComissaoTecnica comissaoTecnica)
        {
            // Verifica duplicidade de cargo para o mesmo time, desconsiderando o registro que está sendo editado
            bool cargoJaCadastrado = db.ComissoesTecnicas.Any(c => c.TimeId == comissaoTecnica.TimeId
                                                                && c.Cargo == comissaoTecnica.Cargo
                                                                && c.Id != comissaoTecnica.Id);
            if (cargoJaCadastrado)
            {
                ModelState.AddModelError("", "Já existe um profissional com esse cargo para o time.");
            }

            if (ModelState.IsValid)
            {
                db.Entry(comissaoTecnica).State = EntityState.Modified;
                db.SaveChanges();

                // Atualiza o status do time vinculado após a edição
                AtualizarStatusTime(comissaoTecnica.TimeId);
                return RedirectToAction("Index");
            }
            ViewBag.TimeId = new SelectList(db.Times, "Id", "Nome", comissaoTecnica.TimeId);
            return View(comissaoTecnica);
        }

        // GET: ComissaoTecnicas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            ComissaoTecnica comissaoTecnica = db.ComissoesTecnicas.Find(id);
            if (comissaoTecnica == null)
                return HttpNotFound();

            return View(comissaoTecnica);
        }

        // POST: ComissaoTecnicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ComissaoTecnica comissaoTecnica = db.ComissoesTecnicas.Find(id);
            int timeId = comissaoTecnica.TimeId;
            db.ComissoesTecnicas.Remove(comissaoTecnica);
            db.SaveChanges();

            // Atualiza o status do time vinculado após a exclusão
            AtualizarStatusTime(timeId);
            return RedirectToAction("Index");
        }

        // Método auxiliar para atualizar o status do Time vinculado à comissão técnica
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
