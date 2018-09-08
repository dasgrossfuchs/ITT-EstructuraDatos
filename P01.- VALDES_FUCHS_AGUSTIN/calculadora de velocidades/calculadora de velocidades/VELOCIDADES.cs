using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_velocidades
{
    class VELOCIDADES
    {
        public VELOCIDADES() { }

        decimal distancia;
        public decimal D { get { return distancia; } set { distancia = value; } }

        decimal tiempo;
        public decimal T { get { return tiempo; } set { tiempo = value; } }

        decimal velocidad;
        public decimal V { get { return velocidad; } set { velocidad = value; } }

        public void PEDIRDISTANCIA()
        {
            Console.WriteLine("Indica la distancia en metros con la cual quieres calcular la velocidad.");
            D = decimal.Parse(Console.ReadLine());
        }
        public void PEDIRTIEMPO()
        {
            Console.WriteLine("Indica el tiempo en segundos con el cual quieres calcular la velocidad.");
            T = decimal.Parse(Console.ReadLine());
            if(T < 0)
            {
                throw new RankException();
            }
        }
        public decimal CALCULAR_VELOCIDAD()
        {
            return (V=D/T);
        }
        ~VELOCIDADES() { Console.WriteLine("Todos teman, el destructor de clases esta eliminando la clase \"VELOCIDADES\""); }

    }
}
