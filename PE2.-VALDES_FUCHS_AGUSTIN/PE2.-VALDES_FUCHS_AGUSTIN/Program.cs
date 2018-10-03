using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2._VALDES_FUCHS_AGUSTIN
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /* BENCHMARKING FOR LOOSERS 
                 *var watch = System.Diagnostics.Stopwatch.StartNew();
                 *watch.Stop();
                 *var elapsedMs = watch.ElapsedMilliseconds;
                 * Console.WriteLine("El proceso con recursividad tomo {0}.ms en correr", elapsedMs);
                 */

                Console.Write("Cuantos datos tendra su sucesion : ");
                int n = int.Parse(Console.ReadLine());
                int[] arreglo = new int[n];
                Sucesion poop = new Sucesion(n);
                poop.Creacion();
                Console.ForegroundColor=ConsoleColor.Cyan;
                Console.WriteLine("El valor minimo de esta es {0}\n",poop.Min(0));
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("El valor maximo de esta es {0}\n", poop.Max(0));
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Mira que chido puedo invertir esta sucesion ~Blooop~");
                poop.Inv(n);
                Console.ResetColor();
            }
            
            catch (Exception e) { Console.Write(e.Message); }


        }

    }
    public class Sucesion
    {
        
        public Sucesion() { }
        public Sucesion(int parametro) { n = parametro; }
        int n;
        public int ValorMin=1000;
        public int ValorMax = 0;
        int[] arreglo = new int[1];
        public void Creacion()
        {
            Array.Resize(ref arreglo, n);
            for (int x = 0; x < n; x++)
            {
                Console.Write("Captura dato {0} : ", x + 1);
                arreglo[x] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Felicidades usted creo exitosamente su sucesion :)\n\n");
        }
        public int Min(int x)
        {
            try
            {          
                if (arreglo[x] <= ValorMin)
                {
                    ValorMin = arreglo[x];                      
                    return Min(x + 1);
                }
                else
                {
                    return Min(x + 1);
                }
                    
                
            }
            catch (IndexOutOfRangeException e) { return ValorMin; }
            catch (Exception e)
            {
                
                Console.WriteLine("hubo un error no especificado y el programa cree que el valor minimo es 0\n" +
                "felicidades, rompiste mi programa");
                return 0;
                
            }
            
        }
        public int Max(int x)
        {
            try
            {
                if (arreglo[x] >= ValorMax)
                {
                    ValorMax = arreglo[x];
                    return Max(x + 1);
                }
                else
                {
                    return Max(x + 1);
                }


            }
            catch (IndexOutOfRangeException e) { return ValorMax; }
            catch (Exception e)
            {

                Console.WriteLine("hubo un error no especificado y el programa cree que el valor minimo es 0\n" +
                "felicidades, rompiste mi programa");
                return 0;

            }

        }
        public int Inv(int x)
        {
            if (x > 0)
            {
                Console.WriteLine(arreglo[x-1]);
                return Inv(x - 1);
            }
            else { return 0; }
                                   
        }


    }
}
