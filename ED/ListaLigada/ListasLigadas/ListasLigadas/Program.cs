using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasLigadas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaLig lista = new ListaLig();
            lista.ImprimirNodos();
            Console.WriteLine();
            lista.AgregarUltimo(12);

            lista.AgregarUltimo("Hola");
            lista.AgregarUltimo("Mundo");
            lista.ImprimirNodos();

            lista.AgregarInicio("Inicio");
            
            Console.WriteLine();
            lista.ImprimirNodos();
            Console.ReadKey();
        }

    }
}
