using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_velocidades
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal velocidad;
            bool si = true;
            
            do
            {
                try
                {
                    VELOCIDADES X = new VELOCIDADES();
                    X.PEDIRDISTANCIA();
                    X.PEDIRTIEMPO();
                    velocidad = (X.CALCULAR_VELOCIDAD());
                    Console.WriteLine("La velocidad calculada es de {0}", velocidad);
                    si = false;

                }
                catch (FormatException e) { Console.WriteLine("Intenta escribir con numeros"); }
                catch (DivideByZeroException e) { Console.WriteLine("El tiempo no puede ser cero"); }
                catch (RankException g) { Console.WriteLine("\"No puedo viajar al ayer pues yo era alguien diferente entonces\"" +
                    "\n -Lewis Carroll \n usa tiempos positivos si no quieres mas citas raras"); }
                catch { Console.WriteLine("error no especificado"); }
            } while (si == true);
            

        }
    }
}
