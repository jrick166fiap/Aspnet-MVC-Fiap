using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo004.Web.MVC.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }

        [Required(ErrorMessage ="Informe o nome do Jogador")]
        public string Nome { get; set; }

        [Range(1, 99)]
        public int Numero { get; set; }

        //Relacionamento Time Jogador Muitos para um com Times
        
        public Time Time { get; set; }

        public int TimeId { get; set; }
    }
}