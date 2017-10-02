using Fiap.Exemplo005.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap.Exemplo005.Web.MVC.Repositories
{
    public interface IProdutoraRepository
    {
        void Cadastrar(Produtora produtora);
        void Atualizar(Produtora produtora);
        void Remover(int id);
        Produtora Buscar(int id);
        List<Produtora> Listar();
        List<Produtora> BuscarPor(Expression<Func<Produtora,bool>>filtro);
    }
}