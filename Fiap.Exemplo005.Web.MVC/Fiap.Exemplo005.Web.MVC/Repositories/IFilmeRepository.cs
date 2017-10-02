using Fiap.Exemplo005.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap.Exemplo005.Web.MVC.Repositories
{
    public interface IFilmeRepository
    {
        void Cadastrar(Filme filme);
        void Atualizar(Filme filme);
        void Remover(int id);
        Filme Buscar(int id);
        List<Filme> Listar();
        List<Filme> BuscarPor(Expression<Func<Filme,bool>> filtro);
    }
}