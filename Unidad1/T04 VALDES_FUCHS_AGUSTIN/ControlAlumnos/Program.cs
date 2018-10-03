using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool variablechidisima = true;
            do
            {
                try
                {


                    Clases x = new Clases();
                    x.CapturaNoClases();
                    x.CreaValorClase();
                    x.Impresion();
                    variablechidisima = false;
                }
                catch (IndexOutOfRangeException) { Console.WriteLine("Unicamente se aceptan calificaciones entre 0 y 100"); }
                catch (FormatException) { Console.WriteLine("Solo numeros permitidos"); }
               
                catch { }
            } while (variablechidisima == true);

        }
    }
}
