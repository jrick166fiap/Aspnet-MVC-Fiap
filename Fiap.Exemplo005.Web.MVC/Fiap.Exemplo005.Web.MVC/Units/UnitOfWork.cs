using Fiap.Exemplo005.Web.MVC.Persistencia;
using Fiap.Exemplo005.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo005.Web.MVC.Units
{

    public class UnitOfWork : IDisposable
    {
        private CinemaContext _context = new CinemaContext();

        private IFilmeRepository _filmeRepository;

        public IFilmeRepository FilmeRepository
        {
            get {
                if (_filmeRepository == null)
                {
                    _filmeRepository = new FilmeRepository(_context);
                }
                return _filmeRepository;
                }
        }

        private IProdutoraRepository _produtoraRepository;

        public IProdutoraRepository ProdutoraRepository
        {
            get
            {
                if (_produtoraRepository == null)
                {
                    _produtoraRepository = new ProdutoraRepository(_context);
                }
                return _produtoraRepository;
            }
        }


        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

    }
}