using Fiap.Exemplo03.Web.MVC.Models;
using Fiap.Exemplo03.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo03.Web.MVC.Controllers
{
    public class ApostaController : Controller
    {

        private LoteriaContext _context = new LoteriaContext();
        // GET: Aposta
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro() {

            return View();
        }
        [HttpPost]
        public ActionResult Cadastro(Aposta aposta )
        {
            _context.Apostas.Add(aposta);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado com Sucesso";

            return RedirectToAction("listar");
        }

        [HttpGet]
        public ActionResult Listar()
        {

            return View(_context.Apostas.ToList());
        }

        [HttpGet]
        public ActionResult Alterar(int id) {

            return View(_context.Apostas.Find(id));

        }

        [HttpPost]
        public ActionResult Alterar(Aposta aposta) {
            _context.Entry(aposta).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Alterado com sucesso";
            return RedirectToAction("listar");

        }
        [HttpGet]
        public ActionResult Remover(int id) {

            var temp = _context.Apostas.Find(id);
            _context.Apostas.Remove(temp);
            _context.SaveChanges();
            TempData["msg"] = "Removido com Sucesso";
            return RedirectToAction("listar");
        }
    }
}