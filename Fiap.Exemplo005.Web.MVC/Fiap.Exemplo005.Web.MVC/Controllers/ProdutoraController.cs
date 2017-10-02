using Fiap.Exemplo005.Web.MVC.Models;
using Fiap.Exemplo005.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo005.Web.MVC.Controllers
{
    public class ProdutoraController : Controller
    {
        UnitOfWork _unit = new UnitOfWork();
        // GET: Produtora
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produtora produtora )
        {
            if (ModelState.IsValid)
            {
                _unit.ProdutoraRepository.Cadastrar(produtora);
                _unit.Salvar();
                TempData["msg"] = "Produtora Cadastrada com Sucesso";
                return RedirectToAction("Cadastrar");
            }
            else
            {
                return View(produtora);
            }
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.ProdutoraRepository.Listar());
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            return View(_unit.ProdutoraRepository.Buscar(id));   
        }

        [HttpPost]
        public ActionResult Alterar(Produtora produtora)
        {
            _unit.ProdutoraRepository.Atualizar(produtora);
            _unit.Salvar();
            TempData["msg"] = "Alterado com sucesso";
            return RedirectToAction("Listar");
        }


        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }

    }

    
}