using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Exemplo004.Web.MVC.Models;
using Fiap.Exemplo004.Web.MVC.Persistencia;
using System.Data.Entity;

namespace Fiap.Exemplo004.Web.MVC.Repositories
{
    public class TimeRepository : ITimeRepository
    {

        private FutebolContext _context;

        //Contrutor que recebe o contexto.
        public TimeRepository(FutebolContext context)
        {

            _context = context;
        }


        public void Atualizar(Time time)
        {
            _context.Entry(time).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public List<Time> BuscarPor(Expression<Func<Time, bool>> Filtro)
        {

            return _context.Times.Include("Tecnico").Where(Filtro).ToList();
        }

        public Time Buscar(int codigo)
        {
            return _context.Times.Find(codigo);
        }

        public void Cadastrar(Time time)
        {
            _context.Times.Add(time);
        }

        public List<Time> Listar()
        {
            return _context.Times.Include("Tecnico").ToList();
        }

        public void Remover(int codigo)
        {
            var time = _context.Times.Find(codigo);
            _context.Times.Remove(time);
        }
    }
}