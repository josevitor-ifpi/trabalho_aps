using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace josevitorads.Models
{
    public class Item
    {
        public int Id { get; set; }
        public double Preco { get; set; }

        public int Percentual { get; set; }

        public int Quantidade { get; set; }

    }
}