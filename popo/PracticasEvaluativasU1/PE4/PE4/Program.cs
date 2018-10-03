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
            char[] abc = new char[]{'a','b', 'c'};
            Console.WriteLine("el menos de a,b, y c es {0}",abc.Min());
            int[] def = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Capturando dato {0}", i + 1);
                def[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El valor menor es {0}", abc.Min());
        }
    }
}
