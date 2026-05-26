using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace arbol {
    internal class ArbolBBL {
        private Nodo Raiz {  get; set; }

        //AgregarLeon
        /*
        public void Agregar( string color, int edad) {
            Leon l = new Leon(color, edad);
            Nodo nuevo = new Nodo(l);
            Nodo tmp = Raiz;
            while (tmp != null) {
                if (nuevo.Dato.Edad > tmp.Dato.Edad) {
                    tmp = tmp.Der;
                } else if (nuevo.Dato.Edad < tmp.Dato.Edad) {
                    tmp = tmp.Izq;
                } else { //iguales
                    return;
                }
            }
            tmp = nuevo;

            Console.WriteLine(Raiz);
        }*/
        public void Insertar(string color, int edad) {
            Raiz = InsertarRecursivo(Raiz, color, edad);
        }
        private Nodo InsertarRecursivo(Nodo r, string color, int edad) {
            if (r == null) {
                Leon l = new Leon(color, edad);
                return new Nodo(l);
            } else if (edad < r.Dato.Edad) {
                r.Izq = InsertarRecursivo(r.Izq, color, edad);
            } else if (edad > r.Dato.Edad) {
                r.Der = InsertarRecursivo(r.Der, color, edad);
            }
            return r;
        }


        public void RecorrerPreOrden() {
            RecorrerPreOrdenRec(Raiz);
        }
        private void RecorrerPreOrdenRec(Nodo r) {
            if (r != null) {
                Console.Write(r.Dato + " ");
                RecorrerPreOrdenRec(r.Izq);
                RecorrerPreOrdenRec(r.Der);
            }
        }

        //Leon Mayor
        public void MayorLeon() {
            MayorLeonRec(Raiz);
        }
        private bool MayorLeonRec(Nodo r) {
            if (r != null) {
                bool d = MayorLeonRec(r.Der);
                if (d) {
                    Console.Write(r.Dato + " ");
                }
                return false;
                MayorLeonRec(r.Izq);
            }
            return true;
        }


    }
}
