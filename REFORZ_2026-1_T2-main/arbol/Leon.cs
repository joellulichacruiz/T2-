using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbol {
    internal class Leon {
        public string Color { get; set; }
        public int Edad { get; set; }

        public Leon(string color, int edad) {
            Color = color;
            Edad = edad;
        }

        public override string? ToString() {
            return $"{Color} {Edad}";
        }
    }
}
