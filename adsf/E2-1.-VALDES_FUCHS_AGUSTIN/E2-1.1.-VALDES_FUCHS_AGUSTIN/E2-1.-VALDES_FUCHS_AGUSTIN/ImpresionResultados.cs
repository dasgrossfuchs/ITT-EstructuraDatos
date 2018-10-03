using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_1._VALDES_FUCHS_AGUSTIN
{
    class ImpresionResultados
    {
        int input = 0;
        public int I { get { return input; }set { input = value; } }
        int output = 0;
        public int O { get { return output; } set { output = value; } }
        public ImpresionResultados() { }
        public ImpresionResultados(int input,int output) { I = input; O = output; }
        public void Impresion()
        {
            Console.WriteLine("El Factorial de {0} es = {1}", I, O);
        }
    }
}
