using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlAlumnos
{
    class Clases
    {
        int IndiceValorMaximo = 0;
        public int IVM { get { return IndiceValorMaximo; } set { IndiceValorMaximo = value; } }
        int NoClases = 0;
        public int NC { get { return NoClases; } set { NoClases = value; } }
        int NoAlumnos = 0;
        public int NA { get { return NoAlumnos; } set { NoAlumnos = value; } }
        int[] ArClase;
        int[,,] ArAlumno;
        public void CapturaNoClases()
        {
            Console.WriteLine("Cuantas clases deseas capturar?");
            NC = int.Parse(Console.ReadLine());
        }
        public void CreaValorClase()
        {
            ArClase = new int[NC];//este arreglo unicamente indica cuantos alumnos hey en cada clase

            for (int x = 0; x < NC; x++)//alumnos por clase clase es el indice del arreglo
            {
                int y = x + 1;
                Console.WriteLine("Cuantos Alumnos hay en la clase No.{0}", y);
                ArClase[x] = int.Parse(Console.ReadLine());
                IVM = ArClase.Max();
            }
            ArAlumno = new int[NC, IVM, 1];//este arreglo indica clase,alumno,calificacion del alumno
            Console.Clear();
            Console.WriteLine("Recuerda que las calificaciones se dan del 0 al 100");
            for (int x = 0; x < NC; x++)
            {
                for (int y = 0; y < ArClase[x]; y++)
                {
                    Console.WriteLine("Captura la calificacion del alumno de codigo {0:000.}, en la clase {1:00.}", y + 1, x + 1);
                    ArAlumno[x, y, 0] = int.Parse(Console.ReadLine());
                    if (ArAlumno[x, y, 0] <= -1) { throw new IndexOutOfRangeException(); }
                    else if (ArAlumno[x, y, 0] >=101) { throw new IndexOutOfRangeException(); }
                }
            }
            Console.WriteLine("Se han capturado todos los datos, presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        public void Impresion()
        {
            for (int x = 0; x < NC; x++)
            {
                Console.Write("Clase {0:00.}\n", x + 1);
                for (int y = 0; y < ArClase[x]; y++)
                {
                    Console.Write("Alumno {0:000.}\t ",y+1);
                    Console.WriteLine("Calificacion {0:000}\n", ArAlumno[x, y, 0]);
                    
                }
            }
        }

    }
}
