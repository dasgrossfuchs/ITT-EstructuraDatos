using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_1._VALDES_FUCHS_AGUSTIN
{
    class CicloFactorial
    {
        
        int n;
        public int N{ get { return n; }set {n=value; } }
        public CicloFactorial() { }
        public CicloFactorial(int parametro) { N=parametro; }
        public int Factorial()
        {
            Console.WriteLine(N);
            int total = 1;
            for (int x = 1; x<=N; x++)
            {
                total = total * x;
            }
            return total;
        }
    }
}
