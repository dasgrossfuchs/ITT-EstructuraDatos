using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Cuantos datos desea que haya en la sucesion");
            x = int.Parse(Console.ReadLine());
            int[] sucesion = new int[x];
            for (int i =0;i<x ;i++ )
            {
                Console.WriteLine("Capture dato {0}",i+1);
                sucesion[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El valor mas pequeño es de {0}",sucesion.Min());
            Console.WriteLine("El valor mas grande es de {0}", sucesion.Max());
        }
    }
}
