using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2._VALDES_FUCHS_AGUSTIN
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            Queue queue = new Queue();
            //capturar valres
            for (int i = 0; i < 20; i++)
            {
                stack.Push((i + 1).ToString());//en una pila se agregan datos con el metodo push
                queue.Enqueue((i + 1).ToString());//en una cola se agregan datos con el metodo enqueue

            }
            Console.WriteLine("La pila es de tipo\t{0}", stack.GetType());//muestra el tipo de objeto
            Console.WriteLine("La cola es de tipo\t{0}", queue.GetType());
            Console.WriteLine("La pila es de tipo\t{0}", stack.ToString());//muestra el tipo de objeto de otra manera
            Console.WriteLine("La cola es de tipo\t{0}", queue.ToString());
            {//imprime valores de una manera
                int y = stack.Count;
                Console.WriteLine("Valores en stack");
                //Mostrar valores
                for (int i = 0; i < y; i++)
                {//para se puede mostrar en el orden normal de una pila con peek o con pop
                    Console.WriteLine(stack.Pop());
                }
                Console.WriteLine("valores en queue");
                int x = queue.Count;//cree una constante a partir del count para que no hubiera error de impresion
                for (int i = 0; i < x; i++)
                {//ya que no hay un metodo pop en las colas como lo hay en las pilas, este se puede simular, mustrando con peek y destruyendo con dequeue
                    Console.WriteLine(queue.Peek());
                    queue.Dequeue();
                }
            }
            {//Imprime valores de otra manera
                IEnumerator Enumpila = stack.GetEnumerator();//crea un enumerador
                IEnumerator Enumcola = queue.GetEnumerator();
                while (Enumpila.MoveNext())
                {//para se puede mostrar en el orden normal de una pila con peek o con pop
                    Console.WriteLine(stack.Pop());
                }
                Console.WriteLine("valores en queue");
                int x = queue.Count;//cree una constante a partir del count para que no hubiera error de impresion
                for (int i = 0; i < x; i++)
                {//ya que no hay un metodo pop en las colas como lo hay en las pilas, este se puede simular, mustrando con peek y destruyendo con dequeue
                    Console.WriteLine(queue.Peek());
                    queue.Dequeue();
                }
            }
            //verificar valores
            {
                if (stack.Contains("2") == false)
                {//verifica que la pila tiene el valor 2 en este caso
                    Console.WriteLine("la pila contiene el objeto 2");
                }
                else Console.WriteLine("nel pila");//aviso al usuario que efectivamente el valor no se encuentra en la pila
                if (queue.Contains("4") == false)
                {//verifica que la cola tiene el valor 4 en este caso
                    Console.WriteLine("la cola contiene el objeto 4");
                }
                else Console.WriteLine("nel cola");//aviso al usuario que efectivamente el valor no se encuentra en la cola
                queue.ToArray();//los convierte en arreglos
                stack.ToArray();
            }
            {
                if (stack.Equals("2") == false)
                {//verifica que la pila tiene el valor 2 en este caso
                    Console.WriteLine("la pila contiene el objeto 2");
                }
                else Console.WriteLine("nel pila");//aviso al usuario que efectivamente el valor no se encuentra en la pila
                if (queue.Equals("4") == false)
                {//verifica que la cola tiene el valor 4 en este caso
                    Console.WriteLine("la cola contiene el objeto 4");
                }
                else Console.WriteLine("nel cola");//aviso al usuario que efectivamente el valor no se encuentra en la cola
                queue.ToArray();//los convierte en arreglos
                stack.ToArray();
            }
            queue.Clear();//vacia el contenido
            stack.Clear();

        }
    }
}
