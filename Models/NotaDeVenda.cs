using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace josevitorads.Models
{
    public class NotaDeVenda
    {
        public int Id { get; set; }
        public DateOnly Data { get; set; }
        public bool Tipo { get; set; }

        public bool cancelado = false;
        public bool devolvido = false;

        public bool Cancelar() {
            cancelado = true;
            return true;
        }
        public bool Devolver() {
            devolvido = true;
            return true;
        }

    }
}