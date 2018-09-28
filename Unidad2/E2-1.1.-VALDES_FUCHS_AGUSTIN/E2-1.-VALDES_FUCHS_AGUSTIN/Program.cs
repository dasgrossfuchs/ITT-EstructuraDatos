using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_1._VALDES_FUCHS_AGUSTIN
{
    class Program
    {
        static void Main(string[] args)
        {
            CapturaDatos captura = new CapturaDatos();
            int input = captura.Capturacion();
            CicloFactorial proceso = new CicloFactorial(input);
            int output = proceso.Factorial();
            ImpresionResultados impresion = new ImpresionResultados(input, output);
            impresion.Impresion();
            
            

            
        }
    }
}
