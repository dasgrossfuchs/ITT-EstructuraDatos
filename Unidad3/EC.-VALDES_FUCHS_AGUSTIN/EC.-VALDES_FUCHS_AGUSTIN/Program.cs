using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ECVALDESFUCHSAGUSTIN
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Pila = new Stack();

            Pila.Push("Brownies");
            Pila.Push("pies");
            Pila.Push("popo");
            Pila.Push("amor");

            //Comprueba si un elemento esta dentro de la pila
            if (Pila.Contains("Brownies"))
            { 
                Console.WriteLine("1.-la pila tiene chocolate dentro");
            
                if (Pila.Contains("popo"))
                    Console.WriteLine("probablemente sea popo\n");
            }
            else
                Console.WriteLine("1.-Ando a dieta prro\n");
            
            

            //Se utiliza para saber de que tipo es el objeto
            if (Pila.GetType() == typeof(Stack))
                Console.WriteLine("2.-el tipo de objeto es \n");
            else
                Console.WriteLine("2.-el tipo no es consistente\n");

            //a partir de la pila crea un dato tipo string
            Console.WriteLine("3.-" + Pila.ToString() + "\n");

            //a partir de la pila se convierte a arreglo, esto permite hacer funciones unicamente disponibles para arreglos
            Console.WriteLine("4.-" + Pila.ToArray().ElementAt(2) + "\n");

            //Consigue un Ienumerator de la pila
            IEnumerator ejemplo = Pila.GetEnumerator();
            while (ejemplo.MoveNext())
            {
                Object objeto = ejemplo.Current;
                Console.WriteLine("5.-" + objeto);
            }
            Console.ReadKey();
        }
    }
}
