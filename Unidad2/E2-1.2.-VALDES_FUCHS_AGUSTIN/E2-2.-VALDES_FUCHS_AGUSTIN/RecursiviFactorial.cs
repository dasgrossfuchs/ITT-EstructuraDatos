using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_2._VALDES_FUCHS_AGUSTIN
{
    class RecursiviFactorial
    {
        public RecursiviFactorial() { }
        public int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
            return n * Factorial(n - 1);
        }
    }
}
