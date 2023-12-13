using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace josevitorads.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public DateOnly DataLimite { get; set; }

        public double Valor { get; set; }

        public Boolean Pago { get; set; }
    }
}