using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace josevitorads.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }
    }
}