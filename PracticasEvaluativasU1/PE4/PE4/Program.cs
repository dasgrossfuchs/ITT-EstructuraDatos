using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] abc = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Capturando dato {0}", i + 1);
                abc[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El valor menor es {0}", abc.Min());
        }
    }
}
