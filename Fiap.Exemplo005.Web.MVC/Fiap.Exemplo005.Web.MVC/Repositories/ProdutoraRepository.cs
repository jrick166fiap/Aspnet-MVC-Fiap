using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Exemplo005.Web.MVC.Models;
using Fiap.Exemplo005.Web.MVC.Persistencia;
using System.Data.Entity;

namespace Fiap.Exemplo005.Web.MVC.Repositories
{
    public class ProdutoraRepository : IProdutoraRepository
    {
        CinemaContext _context = new CinemaContext();

        public ProdutoraRepository(CinemaContext context)
        {
            _context = context;
        }
        public void Atualizar(Produtora produtora)
        {
            _context.Entry(produtora).State = EntityState.Modified;
        }

        public Produtora Buscar(int id)
        {
            return _context.Produtoras.Find(id);
        }

        public List<Produtora> BuscarPor(Expression<Func<Produtora, bool>> filtro)
        {
            return _context.Produtoras.Where(filtro).ToList();
        }

        public void Cadastrar(Produtora produtora)
        {
            _context.Produtoras.Add(produtora);
        }

        public List<Produtora> Listar()
        {
            return _context.Produtoras.ToList();
        }

        public void Remover(int id)
        {
            var produtora = _context.Produtoras.Find(id);
            _context.Produtoras.Remove(produtora);
        }
    }
}