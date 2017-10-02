using Fiap.Exemplo004.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo004.Web.MVC.Persistencia
{
    public class FutebolContext : DbContext
    {

        //Criação dos Contextos dos Bancos de Dados
        public DbSet<Time>  Times { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }

        public DbSet<Tecnico> Tecnicos { get; set; }

        public DbSet<Campeonato> Campeonatos { get; set; }
    }
}