using Fiap.Exemplo005.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo005.Web.MVC.Persistencia
{
    public class CinemaContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Produtora> Produtoras { get; set;}
    }
}