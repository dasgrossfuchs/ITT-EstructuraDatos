using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3
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
            int[] inversa = new int[x];
            for (int i = 0; i < x; i++)
            {
                inversa[(x - i - 1)] = sucesion[i];
            }
            int valor = inversa.Max();
            int indice = inversa.ToList().IndexOf(valor);
            Console.WriteLine("La posicion del ultimo valor mas grande es {0}",(x-indice));
        }
    }
}
