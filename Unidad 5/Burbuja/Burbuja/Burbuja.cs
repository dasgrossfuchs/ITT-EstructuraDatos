using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja
{
    class Burbuja
    {
        public void Impresion(int[] arreglolocalimpresion) //Método que recibe como parámetro un arreglo
        {
            Console.Clear();
            Console.WriteLine("Valores ingresados: ");

            foreach (var item in arreglolocalimpresion)
            {
                Console.Write(item + " "); //Se despliega cada uno de los elementos del arreglo
            }

            int temp; //Se inicializa el temporal para el ordenamiento

            for (int i = 0; i < arreglolocalimpresion.Length; i++) //For para que se acomode cada uno de los elementos
            {                               //se realiza el segundo for la cantidad de veces como elementos tenga el arreglo
                for (int ii = 1; ii < arreglolocalimpresion.Length; ii++) //Aquí se van a comparar los valores de los elementos
                {
                    if (arreglolocalimpresion[ii - 1] > arreglolocalimpresion[ii]) //Si el valor anterior es mayor que el actual
                    {
                        temp = arreglolocalimpresion[ii]; //Se guarda el actual
                        arreglolocalimpresion[ii] = arreglolocalimpresion[ii - 1]; //Se sustituye el actual por el anterior
                        arreglolocalimpresion[ii - 1] = temp;//Al anterior se le asigna el actual
                    }
                }
            }

            Console.WriteLine("\nOrdenado: ");

            foreach (var item in arreglolocalimpresion)
            {
                Console.Write(item + " "); //Se despliega la lista ordenada
            }

            Console.ReadKey();
        }
    }
}
