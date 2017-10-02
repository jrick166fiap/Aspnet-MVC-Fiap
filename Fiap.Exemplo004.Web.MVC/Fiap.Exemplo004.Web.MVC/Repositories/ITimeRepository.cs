using Fiap.Exemplo004.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo004.Web.MVC.Repositories
{

    //Marcar a interface como public
    public interface ITimeRepository
    {
        void Cadastrar(Time time);
        List<Time> Listar();

        void Atualizar(Time time);

        void Remover(int codigo);

        Time Buscar(int codigo);

        List<Time> BuscarPor(Expression<Func<Time, bool>> Filtro);
    }
}
