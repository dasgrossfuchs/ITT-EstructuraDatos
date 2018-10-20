using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Versioncheck
    {
        public int Ascii()
        {
            Console.WriteLine("El siguiente texto deberia Imprimir Corazon, Diamate, trevol y espadas\n" +
                "En caso de que no sea asi porfavor escriba 0 y de click a enter\n" +
                "----♥----♦----♣----♠----");
            int x = int.Parse(Console.ReadLine());
            return x;
        }
        
    }
}
