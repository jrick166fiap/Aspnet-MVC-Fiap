using Fiap.Exemplo004.Web.MVC.Models;
using Fiap.Exemplo004.Web.MVC.Persistencia;
using Fiap.Exemplo004.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo004.Web.MVC.Controllers
{
    public class TimeController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        // GET: Time
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastrar() {

            return View();

        }

        [HttpPost]
        public ActionResult Cadastrar(Time time) {
            _unit.TimeRepository.Cadastrar(time);
            _unit.Salvar();
            TempData["msg"] = "Time cadastrado com Sucesso";
            return RedirectToAction("listar");

        }

        [HttpGet]
        public ActionResult Listar() {


            //Importante sempre quando tiver relacionamento adicionar o include para adicionar outras classes.
            return View(_unit.TimeRepository.Listar());
        }

        //Imporante Liberar o recurso após o uso.
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }


    }
}