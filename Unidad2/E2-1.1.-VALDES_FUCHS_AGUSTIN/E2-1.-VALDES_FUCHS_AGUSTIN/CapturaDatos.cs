using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_1._VALDES_FUCHS_AGUSTIN
{
    class CapturaDatos
    {
        int numerofactorizable = 0;
        public CapturaDatos() { }
        public int NF { get { return numerofactorizable; }set { numerofactorizable = value; } }
        public int Capturacion()
        {
            Console.WriteLine("Capture el numero que desea factorizar");
            NF = int.Parse(Console.ReadLine());
            return NF;
        }
    }
}
