using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol {
    internal class Nodo {
        public Leon Dato { get; set; }
        public Nodo Izq { get; set; }
        public Nodo Der { get; set; }

        public Nodo(Leon dato) {
            Dato = dato;
            Izq = null;
            Der = null;
        }

        public override string? ToString() {
            return $"{Dato}";
        }
    }
}
