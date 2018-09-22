using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice = 0;
            int x = 0;
            Console.WriteLine("Cuantos datos tendra la sucesion");
            x = int.Parse(Console.ReadLine());
            int[] sucesion = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Capturando dato {0}", i + 1);
                sucesion[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i<x; i++)
            {
                if (sucesion[i] > sucesion[i - 1])
                {
                    indice = i + 1;
                    i = x;
                }
                else
                    indice = 0;
            }
            Console.WriteLine("El lugar del primer valor que supera a su predecesor es {0}",indice);
        }
    }
}
