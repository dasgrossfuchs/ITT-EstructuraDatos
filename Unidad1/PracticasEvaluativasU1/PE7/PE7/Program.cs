using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Random nmbr = new Random();
            Console.WriteLine("Cuantos datos tendra la sucesion");
            x = int.Parse(Console.ReadLine());
            int[] sucesion = new int[x];
            for (int i = 0; i < x; i++)
            {
                sucesion[i] = nmbr.Next(1,100);
            }
            Console.WriteLine("Desordenada");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(sucesion[i]);
            }
            Array.Sort(sucesion);
            Console.WriteLine("Ordenada");
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(sucesion[i]);
            }

        }
    }
}
