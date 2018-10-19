using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackWobject
{
    class Shuffle
    {
        Stack barajareada = new Stack();
        public Shuffle() { }
        string[] baraja;
        string symbol = "";
        public void Barajear()
        {
            Console.WriteLine("YAY");
            Random rndm = new Random();
            int x = 0;
            baraja = new string[52];
            for (int i = 1; i < 5; i++)
            {

                switch (i)
                {
                    case 1: symbol = "♥"; break;
                    case 2: symbol = "♦"; break;
                    case 3: symbol = "♣"; break;
                    case 4: symbol = "♠"; break;
                    default: break;
                }
                for (int ii = 1; ii < 14; ii++)
                {
                    if (ii != 1)
                    {
                        if (ii >= 11)
                        {
                            switch (ii)
                            {
                                case 11: baraja[x] = string.Format("{0} J", symbol); break;
                                case 12: baraja[x] = string.Format("{0} Q", symbol); break;
                                case 13: baraja[x] = string.Format("{0} K", symbol); break;
                                default: break;
                            }
                        }
                        else
                        {
                            baraja[x] = string.Format("{0} {1}", symbol, ii);
                        }
                    }
                    else { baraja[x] = string.Format("{0} A", symbol); }
                    x++;
                }

            }
            Console.WriteLine("ordenado");
            
            baraja = baraja.OrderBy(barajeoaleatorio => rndm.Next()).ToArray();
            Console.WriteLine("barajeado");
            

            foreach (string item in baraja)
            {
                Card cartabase = new Card();
                cartabase.Name = item;
                barajareada.Push(cartabase);

            }
            foreach (string item in barajareada)
            {
                Card cartabase = new Card();

                cartabase = barajareada.Peek();
                
            }

        }
        

    }
}
