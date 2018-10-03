using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_2._VALDES_FUCHS_AGUSTIN
{
    class CapturaDatos
    {
        int factorizable;
        public int F { get { return factorizable; }set { factorizable = value; } }
        public CapturaDatos() { }
        public int Captura()
        {
            Console.WriteLine("Captura numero a factorizar");
            F = int.Parse(Console.ReadLine());
            return F;
        }
    }
}
