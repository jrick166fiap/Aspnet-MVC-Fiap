using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo005.Web.MVC.Models
{
    public class Produtora
    {
        public int ProdutoraId { get; set; }


        [Required(ErrorMessage ="Informe o nome da produtora")]
        public string Nome { get; set; }

        public List<Filme> Filmes { get; set; }
    }
}