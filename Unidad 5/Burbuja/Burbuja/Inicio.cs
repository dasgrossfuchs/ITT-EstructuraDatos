using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbuja
{
    class Inicio
    {

        public void Captura()//esta clase solo tiene la funcion de 
        {

            int cantidad;
            int[] arreglohomosexual;
            Console.Write("Número de elementos: ");
            cantidad = Convert.ToInt32(Console.ReadLine()); 

            arreglohomosexual = new int[cantidad]; 
            Console.Clear();
            Console.Write("Ingreso de datos: \n");

            for (int contador = 0; contador < cantidad; contador++)
            {
                Console.Write("Elemento {0}: ", contador + 1); 
                arreglohomosexual[contador] = Convert.ToInt32(Console.ReadLine());
            }

            Burbuja ChuyetasMR = new Burbuja(); 

            ChuyetasMR.Impresion(arreglohomosexual); 
        }
    }
}
