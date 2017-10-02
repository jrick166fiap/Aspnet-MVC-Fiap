using Fiap.Exemplo005.Web.MVC.Models;
using Fiap.Exemplo005.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo005.Web.MVC.Controllers
{
    public class FilmeController : Controller
    {
        UnitOfWork _unit = new UnitOfWork();
        

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.ProdutoraRepository.Listar();
            ViewBag.produ = new SelectList(lista,"ProdutoraId","Nome");

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Filme filme)
        {
            if (ModelState.IsValid)
            {
                _unit.FilmeRepository.Cadastrar(filme);
                _unit.Salvar();
                TempData["msg"] = "Filme cadastrado!";
                return RedirectToAction("Cadastrar");
            }
            else
            {
                var lista = _unit.ProdutoraRepository.Listar();
                ViewBag.produ = new SelectList(lista, "ProdutoraId", "Nome");
                return View(filme);
            }
                
            
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.FilmeRepository.Listar());
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }

    }
}