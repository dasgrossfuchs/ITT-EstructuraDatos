using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[4] { 1, 2, 3, 4 };
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }
    }
}
