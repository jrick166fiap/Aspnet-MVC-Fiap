using Fiap.Exemplo03.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo03.Web.MVC.Persistencia
{
    public class LoteriaContext : DbContext
    {
        public DbSet<Apostador> Apostadores { get; set; }

        public DbSet<Aposta> Apostas { get; set; }
    }
}