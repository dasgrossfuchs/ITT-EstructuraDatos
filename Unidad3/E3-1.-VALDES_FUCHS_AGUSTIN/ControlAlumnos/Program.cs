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
            Clase clase = new Clase();
            clase.Captura();
            clase.Print();


        }
    }
    public class Clase
    {
        List<string> clss = new List<string>();
        List<string> alumn = new List<string>();
        List<int> calif = new List<int>();
        public int c = 0;
        public int[] cc;//este arreglo hace que todo funcione :) #I know right 
        

        public void Add1(string a)//este metodo agrega clases
        {
            clss.Add(a);

        }
        public void Add2(string b, int c)//este metodo agrega alumnos
        {

            alumn.Add(b);
            calif.Add(c);
        }
        public void Print()//Este metodo imprime
        {
            for (int x = 0; x < c; x++)
            {
               
                for (int xx = 0;xx<cc[x];xx++)
                {
                    Console.WriteLine("Clase : {0}\tAlumno : {1}\tCalificacion : {2}", clss.ToArray().ElementAt(x),alumn.ToArray().ElementAt(xx),calif.ToArray().ElementAt(xx));
                    
                }
                
                    alumn.RemoveRange(0, cc[x]);
                    calif.RemoveRange(0, cc[x]);


                
                
            }
            
        }
        public void Captura()//en este metodo se captura
        {
            
            Console.WriteLine("Cuantas clases?");
            c = int.Parse(Console.ReadLine());
            cc = new int[c];
            for (int x = 0; x < c; x++)
            {
                Console.WriteLine("Captura el nombre de la clase ");
                string name = Console.ReadLine();
                Console.WriteLine("Cuantos Alumnos en la clase {0}?", name);
                 cc[x] = int.Parse(Console.ReadLine());
                
                Add1(name);
                for (int xx = 0; xx < cc[x]; xx++)
                {
                    Console.WriteLine("Captura calif alumno No.{0:00}", ((x + 1)*100).ToString() + (xx + 1).ToString());
                    int ccc = int.Parse(Console.ReadLine());

                    Add2(((x + 1) * 100).ToString() + (xx + 1).ToString(), ccc);
                }
            }
        }
       
        


    }
}
