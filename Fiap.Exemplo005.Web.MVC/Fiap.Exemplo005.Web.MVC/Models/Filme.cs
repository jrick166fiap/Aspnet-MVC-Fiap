using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo005.Web.MVC.Models
{
    public class Filme
    {

        public int FilmeId { get; set; }

        [Required(ErrorMessage ="Informe o nome")]
        public string Titulo { get; set; }

        [Required]
        [Range(1,7,ErrorMessage ="Selecione o Gênero do filme")]
        public Genero Genero { get; set; }

        public int Duracao { get; set; }

        public DateTime Lancamento { get; set; }


        //Relacionamento 
        public Produtora Produtora { get; set; }

        public int ProdutoraId { get; set; }

    }
}