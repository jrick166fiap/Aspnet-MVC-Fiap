using Fiap.Exemplo004.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap.Exemplo004.Web.MVC.Repositories
{
    public interface IJogadorRepository
    {

        void Cadastrar(Jogador jogador);
        void Atualizar(Jogador jogador);
        void Remover(int id);
        Jogador Buscar(int id);
        List<Jogador> Listar();
        List<Jogador> BuscarPor(Expression<Func<Jogador, bool>> filtro);

    }
}