using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool realidad = true;
            while (realidad == true)
            {
                try
                {

                    int count = 0;
                    int x = 0;
                    Console.WriteLine("escriba un numero de 5 digitos");
                    x = int.Parse(Console.ReadLine());
                    string y = x.ToString();
                    char[] palindromocheck = y.ToCharArray();
                    foreach (char i in palindromocheck)
                    {
                        count = count+1;
                    }
                    if (count != 5)
                    throw new FieldAccessException();
                    realidad = false;
                    if (palindromocheck[4] == palindromocheck[0])
                    {
                        if (palindromocheck[3] == palindromocheck[1])
                        {
                            Console.WriteLine("Felicidades!! :) es un palindromo");
                        }
                        else
                        Console.WriteLine("Felicidades!! :) su numero lamentablemente no es un palindromo :(");
                    }
                    else
                    Console.WriteLine("Felicidades!! :)  su numero lamentablemente no es un palindromo :(");
                    
                }
                catch (FieldAccessException) { Console.WriteLine("Su numero no tenia 5 digitos porfavor intente nuevamente"); }
                catch (FormatException) { Console.WriteLine("intento capturar datos no numericos"); }
            }
        }
    }
}
