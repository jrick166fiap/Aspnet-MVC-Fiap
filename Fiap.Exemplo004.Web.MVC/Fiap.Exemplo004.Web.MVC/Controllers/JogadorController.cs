using Fiap.Exemplo004.Web.MVC.Models;
using Fiap.Exemplo004.Web.MVC.Persistencia;
using Fiap.Exemplo004.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo004.Web.MVC.Controllers
{
    public class JogadorController : Controller
    {
        //private FutebolContext _context = new FutebolContext();

       private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Busca todos os times
            var lista = _unit.TimeRepository.Listar();
            ViewBag.times = new SelectList(lista,"Timeid","Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador) {

            if (ModelState.IsValid)
            {
                _unit.JogadorRepository.Cadastrar(jogador);
                _unit.Salvar();
                TempData["msg"] = "Jogador Cadastrado";
                return RedirectToAction("Cadastrar");
            }
            else
            {
                //Busca todos os times
                var lista = _unit.TimeRepository.Listar();
                ViewBag.times = new SelectList(lista, "Timeid", "Nome");
                return View(jogador);
            }
            

        }

        [HttpGet]
        public ActionResult Listar() {

            return View(_unit.JogadorRepository.Listar());
        }

       
    }
}