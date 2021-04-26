using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisVendas.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoEdicao { get; set; }
        public decimal Valor { get; set; }

        public Genero Genero { get; set; } //sta associado com genero
        public int GeneroId { get; set; }
    }
}