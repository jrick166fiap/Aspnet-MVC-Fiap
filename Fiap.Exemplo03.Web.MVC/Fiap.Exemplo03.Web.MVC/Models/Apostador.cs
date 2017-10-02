using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo03.Web.MVC.Models
{
    public class Apostador
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [MinLength(5)]
        public string Email { get; set; }

        [Display(Name ="Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Column("SaldoTotal")]
        public decimal Saldo { get; set; }
    }
}