using Fiap.Exemplo004.Web.MVC.Persistencia;
using Fiap.Exemplo004.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo004.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private FutebolContext _context = new FutebolContext();

        private IJogadorRepository _jogadorRepository;

        public IJogadorRepository JogadorRepository
        {
        get
            {
                if (_jogadorRepository == null)
                {

                    _jogadorRepository = new JogadorRepository(_context);
                    }
                return _jogadorRepository;

               
             }

        }


        private ITimeRepository _timeRepository;

        public ITimeRepository TimeRepository
        {
        get
            {
                if (_timeRepository == null)
                {
                    _timeRepository = new TimeRepository(_context);
                }
                return _timeRepository;
            }
        }

        //Liberar a conexão com o banco de Dados
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