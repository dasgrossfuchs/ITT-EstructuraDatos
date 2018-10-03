using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_2._VALDES_FUCHS_AGUSTIN
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hasta que elemento de la serie fibonacci desea contar?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            Fibonacci recursivisitizicion = new Fibonacci();
            recursivisitizicion.impresion(n);
            watch.Stop();
            var recurstime = watch.ElapsedMilliseconds;
            Console.WriteLine("El proceso con recursividad tomo {0}.ms en correr\n\n", recurstime);
            var wachaesto = System.Diagnostics.Stopwatch.StartNew();
            Fibonacci iteratiritaichion = new Fibonacci();
            iteratiritaichion.impresioniter(n);
            wachaesto.Stop();
            var itertime = wachaesto.ElapsedMilliseconds;
            Console.WriteLine("El proceso con iteraciones tomo {0}.ms en correr\n\n", itertime);
            Console.ReadKey();
        }
    }
    public class Fibonacci
    {
        public Fibonacci() { }
        public int Recusivo(int n)
        {
            
            if (n < 2)
                return n;
            return Recusivo(n-1)+Recusivo(n-2);
        }
        public int Iterativo(int n)
        {
            
            int I = 0;
            int II = 1;
            for (int ii=0;ii<n;ii++)
            {
                int III = I + II;
                I = II;
                II = III;
            }
                return I;
        }
        public void impresion(int n)
        {
            for (int x = 0; x < n; x++)
            {
                Console.WriteLine(Recusivo(x));
            }
        }
        public void impresioniter(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Iterativo(i));
            }
        }
    }
}
