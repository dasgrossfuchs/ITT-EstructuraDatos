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
            CapturaDatos captura = new CapturaDatos();
            RecursiviFactorial proceso = new RecursiviFactorial();
            ImpresionResultados impresion = new ImpresionResultados();
            impresion.Impresion(proceso.Factorial(captura.Captura()));//10 de 10 por usar todos los metodos en una linea
        }
    }
}
