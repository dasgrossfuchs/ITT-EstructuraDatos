using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Cuantos datos tendra la sucesion");
            x = int.Parse(Console.ReadLine());
            int[] sucesion = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Capturando dato {0}", i + 1);
                sucesion[i] = int.Parse(Console.ReadLine());
            }
            int valor = sucesion.Max();
            int indice = sucesion.ToList().IndexOf(valor);
            Console.WriteLine("La posicion del primer valor mas grande es {0}", (indice +1));
        }
    }
}
