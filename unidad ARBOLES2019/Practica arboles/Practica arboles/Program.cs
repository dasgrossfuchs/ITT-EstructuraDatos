using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol arbolito = new Arbol();
            arbolito.Agregar(arbolito.raiz,10);
            arbolito.Agregar(arbolito.raiz, 9);
            arbolito.Agregar(arbolito.raiz, 8);
            arbolito.Agregar(arbolito.raiz, 7);
            arbolito.Agregar(arbolito.raiz, 6);
            arbolito.Agregar(arbolito.raiz, 15);
            arbolito.Agregar(arbolito.raiz, 13);
            arbolito.print(arbolito.raiz);
        }
    }
}
