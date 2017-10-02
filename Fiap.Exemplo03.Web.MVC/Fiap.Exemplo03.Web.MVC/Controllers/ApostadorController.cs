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
    public class ApostadorController : Controller
    {
        private LoteriaContext _context = new LoteriaContext();

        [HttpGet]
        public ActionResult Remover(int id)
        {
            var apostador = _context.Apostadores.Find(id);
            _context.Apostadores.Remove(apostador);
            _context.SaveChanges();
            TempData["msg"] = "Removido";
            return RedirectToAction("Listar");
        }

        //Alterar com base no Id
        [HttpGet]
        public ActionResult Alterar(int id)

        {
            //Está devolvendo todo Objeto
            return View(_context.Apostadores.Find(id));
        }

        //Alterar com Post
        [HttpPost]
        public ActionResult Alterar(Apostador apostador)
        {

            _context.Entry(apostador).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Atualizado com sucesso";
            return RedirectToAction("Listar");
        }

        // GET: Apostador
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Cadastro(Apostador apostador)
        {
          
            _context.Apostadores.Add(apostador);
            _context.SaveChanges();
            //Mensagem
            TempData["msg"] = "Cadastrado com Sucesso";
            ViewBag.mensagem = "Gravado";
            return RedirectToAction("Cadastro");
        }
        [HttpGet]
        public ActionResult Listar()
        {
            //var context = new LoteriaContext();
           //List<Apostador> lista = _context.Apostadores.ToList();
           
            return View(_context.Apostadores.ToList());
        }

    }
}