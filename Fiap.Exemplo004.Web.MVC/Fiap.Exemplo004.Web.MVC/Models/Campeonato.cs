using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo004.Web.MVC.Models
{
    public class Campeonato
    {

        public int CampeonatoId { get; set; }

        public string Nome { get; set; }

        public int Duracao { get; set; }


        // Relacionamento Muitos para Muitos TIME
        public List<Time> TIME { get; set; }
    }
}