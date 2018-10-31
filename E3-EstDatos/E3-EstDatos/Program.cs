using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacion op = new Operacion();
            Console.WriteLine("Elija la opcion que desea revisar");
            int opc = 0;
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:op.Ejercicio1(); break;
                
                case 3:op.Ejercicio3(); break;
                case 4:op.Ejercicio4(); break;
                default: Console.WriteLine("El ejercicio que elijio no existe");
                    break;
            }
            Console.ReadLine();
        }
    }
}
