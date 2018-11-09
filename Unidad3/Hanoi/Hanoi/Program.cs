using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tower torre = new Tower();
            torre.Crear();
            torre.Checkup();
            torre.StartHanoi();
            torre.Checkup();
        }
    }
}
