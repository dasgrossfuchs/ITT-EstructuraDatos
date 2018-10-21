using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Gamestart
    {
        Versioncheck v = new Versioncheck();
        bool juego = true;
        public void start()
        {
            int x = v.Ascii();
            if (x != 0)
            {
                
                while (juego == true)
                    try
                    {

                        Blackjack blackjack = new Blackjack();
                        blackjack.Barajear();
                        Console.WriteLine("Bienvenido a BlackJack!");
                        Console.WriteLine("Escribe 0 para ver las reglas o cualquier otra tecla para continuar");
                        string opc = Console.ReadLine();
                        if (opc == "0")
                        {
                            blackjack.ThaRulez();
                        }
                        blackjack.Hitme();
                        blackjack.Hitme();
                        blackjack.TheDecision();

                        Console.WriteLine("¿Quieres jugar denuevo?");
                        Console.WriteLine("escribe la opcion");
                        Console.WriteLine("NO --> 0");
                        opc = Console.ReadLine();
                        if (opc == "0")
                        {
                            juego = false;
                        }


                    }
                    catch (Exception) { }

            }
            else
            {
                bool juego = true;
                while (juego == true)
                    try
                    {

                        Blackjacknoascii blackjack = new Blackjacknoascii();
                        blackjack.Barajear();
                        Console.WriteLine("Bienvenido a BlackJack!");
                        Console.WriteLine("Escribe 0 para ver las reglas o cualquier otra tecla para continuar");
                        string opc = Console.ReadLine();
                        if (opc == "0")
                        {
                            blackjack.ThaRulez();
                        }
                        blackjack.Hitme();
                        blackjack.Hitme();
                        blackjack.TheDecision();

                        Console.WriteLine("¿Quieres jugar denuevo?");
                        Console.WriteLine("escribe la opcion");
                        Console.WriteLine("NO --> 0");
                        opc = Console.ReadLine();
                        if (opc == "0")
                        {
                            juego = false;
                        }


                    }
                    catch (Exception) { }


            }

            
        }
    }
}
