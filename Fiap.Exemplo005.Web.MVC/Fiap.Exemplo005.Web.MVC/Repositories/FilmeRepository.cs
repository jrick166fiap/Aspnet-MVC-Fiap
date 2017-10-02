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
    public class FilmeRepository : IFilmeRepository
    {
        private CinemaContext _context;

        public FilmeRepository(CinemaContext context)
        {
            _context = context;

        }

        public void Atualizar(Filme filme)
        {
            _context.Entry(filme).State = EntityState.Modified;
        }

        public Filme Buscar(int id)
        {
           return  _context.Filmes.Find(id);
        }

        public List<Filme> BuscarPor(Expression<Func<Filme, bool>> filtro)
        {
            return _context.Filmes.Include("Produtora").Where(filtro).ToList();
        }

        public void Cadastrar(Filme filme)
        {
            _context.Filmes.Add(filme);
        }

        public List<Filme> Listar()
        {
            return _context.Filmes.Include("Produtora").ToList();
        }

        public void Remover(int id)
        {
            var filme = _context.Filmes.Find(id);
            _context.Filmes.Remove(filme);
        }
    }
}