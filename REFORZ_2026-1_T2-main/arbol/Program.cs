// See https://aka.ms/new-console-template for more information
using arbol;

ArbolBBL a = new ArbolBBL();
a.Insertar("Marron", 5);
a.Insertar("Verde", 3);
a.Insertar("Azul", 7);
a.Insertar("Rojo", 6);
a.RecorrerPreOrden();
Console.WriteLine("Mayor:");
a.MayorLeon();

