using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasLigadas
{
   public class ListaLig
    {
        private Nodo encabezado;
        private Nodo Actual;

        public int count;

        public ListaLig()
        {
            encabezado = new Nodo();
            Actual = encabezado;
        }

        public void AgregarUltimo(object data)
        {
            Nodo nuevoNodo = new Nodo();
            nuevoNodo.Valor = data;
            Actual.Siguiente = nuevoNodo;
            Actual = nuevoNodo;
            count++;

        }

        public void AgregarInicio(object data)
        {
            Nodo NuevoNodo = new Nodo() { Valor = data };
            NuevoNodo.Siguiente = encabezado.Siguiente;
            encabezado.Siguiente = NuevoNodo;
            count++;
        }

        public void EliminarInicio()
        {
            if (count>0)
            {
                encabezado.Siguiente = encabezado.Siguiente.Siguiente;
                count--;
            }
            else
            {
                Console.WriteLine("No existen Elementos en la lista ligada");
            }
        }

        public void ImprimirNodos()
        {
            Console.Write("Encabezado ->");
            Nodo actual = encabezado;
            while (actual.Siguiente!=null)
            {
                actual = actual.Siguiente;
                Console.Write(actual.Valor);
                Console.Write(" -> ");
            }
            Console.Write(" Null");

          
        }
    }
}
