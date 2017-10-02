using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo004.Web.MVC.Models
{
    public class Time
    {

        public int TimeId { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Data da Fundação")]
        public DateTime DataFundacao { get; set; }

        //Relacionamento Time Tecnico um um 
        public Tecnico Tecnico { get; set; }
        public int TecnicoId { get; set; }


        // Relacionameno Time Jogador - Muitos para um com jogadores

        public List<Jogador> Jogadores { get; set; }


        // Relacionamento Muitos para Muitos com Campeonato
        public List<Campeonato> Campeonato { get; set; }
    }
}