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
    public class JogadorRepository : IJogadorRepository
    {

        private FutebolContext _context;

        public JogadorRepository(FutebolContext context)
        {
            _context = context;
        }

        public void Atualizar(Jogador jogador)
        {
            _context.Entry(jogador).State = EntityState.Modified;
        }

        public Jogador Buscar(int id)
        {
            return _context.Jogadores.Find(id);
        }

        public List<Jogador> BuscarPor(Expression<Func<Jogador, bool>> filtro)
        {
            return _context.Jogadores.Include("Time").Where(filtro).ToList();
        }

        public void Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
        }

        public List<Jogador> Listar()
        {
           return _context.Jogadores.Include("Time").ToList();
        }

        public void Remover(int id)
        {
            var jogador = Buscar(id);
            _context.Jogadores.Remove(jogador);
        }
    }
}