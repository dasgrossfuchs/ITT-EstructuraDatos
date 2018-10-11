using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E.C_Raso_Padilla_Jose_Manuel
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack Pila = new Stack();

            Pila.Push("Brownies");
            Pila.Push("pies");
            Pila.Push("drogas que se insertan por atras");
            Pila.Push("amor");

            //Comprueba si un elemento esta dentro de la pila
            if (Pila.Contains("Brownies"))
                Console.WriteLine("1.-wow, chocolate papi, dame todo tu choco choco late bb\n");
            else
                Console.WriteLine("1.-Ando a dieta prro\n");

            //Se utiliza para saber de que tipo es el objeto
            if (Pila.GetType() == typeof(Stack))
                Console.WriteLine("2.-son del mismo tipo supongo\n");
            else
                Console.WriteLine("2.-la verdad no fui a la clase aunque si entiendo basicamente lo que hacen los metodos\n");

            //Regresa un string que representa el objeto seleccionado
            Console.WriteLine("3.-" + Pila.ToString() + "\n");

            //Convierte la pila a arreglo haciendola asi capaz de usar las funciones de arreglos.
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
