using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Blackjacknoascii
    {
        int indicemano = 0, acesupyoursleve = 0, indicedecision = 0;


        
        string[] baraja;//arreglo global que podrias ser local
        string symbol = "";//string global que podria ser utilizado como local
        Stack<Carta> barajareada;//pila global 
        public int[] mano = new int[5];

        public void Barajear()//metodo que podria ser mas simple si le metiera todos los datos al arreglo manualmente pero nadie tiene tiempo para eso, imaginate cuanto tiempo me tardaria dandole copy paste a muchas cosas , oigame no ,aqui tengo un switch muy bonito
        {

            Random rndm = new Random();//obj random
            int x = 0;//contador 
            baraja = new string[52];//arreglo temporal
            for (int i = 1; i < 5; i++)//este for es de 1 a 4 simbolizando los cuatro palos
            {

                switch (i)//este cumple la funcion de darle el palo a la carta uwu
                {
                    case 1: symbol = "C"; break;
                    case 2: symbol = "D"; break;
                    case 3: symbol = "T"; break;
                    case 4: symbol = "E"; break;
                    default: break;
                }
                for (int ii = 1; ii < 14; ii++)//este tiene del 1 al 13 ya que cada palo tiene 13 posibles cartas
                {
                    if (ii != 1)//si el valor es 1 la carta es As, por lo tanto puedo descartar(hehehe) rapidamente ese valor asi
                    {
                        if (ii >= 11)//si el valor es del 11 al 13 significan que seran Jacks, Queen y King, y esteticamente necesitaban tener ese valor tambien
                        {
                            switch (ii)
                            {
                                case 11: baraja[x] = string.Format("{0} J", symbol); break;
                                case 12: baraja[x] = string.Format("{0} Q", symbol); break;
                                case 13: baraja[x] = string.Format("{0} K", symbol); break;
                                default: break;
                            }
                        }
                        else//si solo son del 2 al 10 solo son numeros
                        {
                            baraja[x] = string.Format("{0} {1}", symbol, ii);
                        }
                    }
                    else { baraja[x] = string.Format("{0} A", symbol); }//1=A
                    x++;
                }

            }
            barajareada = new Stack<Carta>();
            baraja = baraja.OrderBy(barajeoaleatorio => rndm.Next()).ToArray();//se barajean las cartas en un orden aleatorio gracias a un lambda
            foreach (string item in baraja)
            {
                Carta cardtemp = new Carta();
                cardtemp.Name = item;
                barajareada.Push(cardtemp);
            }
            //la pila es inicializada con los valores de la baraja barajeada, esta se llama barajareada porque puedo
        }
        public void Hitme()//Me repartes una carta porfavor amiguito casa :)
        {
            Console.WriteLine("Carta No.{0}\t{1}\t", (indicemano + 1), (barajareada.Peek()).Name);
            char[] liposuccion = { ' ', 'D', 'C', 'T', 'E' };

            string temp = string.Format("{0}", ((barajareada.Peek()).Name.ToString()).Trim(liposuccion));//le quita el palo(*ouch*),esto se puede hacer en el switch pero es mas estetico con una variable local temporal y evita confusiones
            
            if (temp != "A")
            {
                switch (temp)//convierte valores base de la carta a numero entero
                {
                    case "J": mano[indicemano] = 10; break;
                    case "Q": mano[indicemano] = 10; break;
                    case "K": mano[indicemano] = 10; break;
                    default: mano[indicemano] = int.Parse(temp); break;
                }
            }
            else
            {
                acesupyoursleve++;//para que se pueda realizar un uso justo de los aces, estos se guardan por separado para que sean utilizados conforme sea necesario su valor
                //igual que en el juego
            }

            barajareada.Pop();
            indicemano++;
        }
        public int CountMeIn()//este metodo utiliza la logica del juego para contar las cartas que el jugador a obtenido, y regresa este valor
        {
            int temp = 0;
            foreach (var item in mano)
            {
                temp = temp + item;
            }
            switch (acesupyoursleve)//por mera logica siempre vas a utilizar unicamente un as de valor 11, no se pueden usar dos, por lo que esta parte se puede declarar sin utilizar metodos demasiado complicados
            {//probablemte se podia hacer de otra manera, pero esto parecia lo mas simple en el momento
                case 1:
                    if (temp <= 10)
                    {
                        temp = temp + 11;
                    }
                    else
                    {
                        temp = temp + 1;
                    }
                    break;
                case 2:
                    if (temp <= 9)
                    {
                        temp = temp + 12;//11 siendo del primer as + 1 del segundo
                    }
                    else
                    {
                        temp = temp + 2;
                    }
                    break;
                case 3:
                    if (temp <= 8)
                    {
                        temp = temp + 13;//11 siendo del primer as + 2 de los demas
                    }
                    else
                    {
                        temp = temp + 3;
                    }
                    break;
                case 4:
                    if (temp <= 7)
                    {
                        temp = temp + 14;//11 siendo del primer as + 3 de los demas
                    }
                    else
                    {
                        temp = temp + 4;
                    }
                    break;
                default: break;

            }

            return temp;
        }
        public void ThaRulez()//reglas del juego
        {
            Console.WriteLine("La dinamica del juego es la siguiente:\nEl juego empieza y al jugador le son dadas dos cartas de una baraja barajeada.\n" +
                "El jugador puede decidir pedir otra carta, o quedarse con las que ya cuenta.\n" +
                "El objetivo del juego; ya que no esta un competidor de tipo casa osease el dealer.\n" +
                "1.-Obtener 21 puntos, o acercarse lo mas posible a ellos." +
                "2.-En caso de revasar estos 21 puntos el jugador inmediatamente pierde.\n" +
                "3.-Al jugador unicamente se le permiten retirar 3 cartas aparte de las que obtuvo al iniciar el juego,dando un total de 5 cartas\n" +
                "\n PRESIONA CUALQUIER TECLA PARA CONTINUAR");
            Console.ReadKey();
        }
        public void TheDecision()//metodo que literalmente es una decision , en este tambien se determina si el jugador puede seguir jugando, gano , o perdio
        {



            Console.WriteLine("¿Quieres otra carta?");
            Console.WriteLine("escribe la opcion");
            Console.WriteLine("SI --> 1\tNO --> 0");
            string temp = Console.ReadLine();
            switch (temp)
            {
                case "1":
                    indicedecision++;
                    Hitme();
                    break;
                case "0":
                    indicedecision = 6;
                    break;
                default:
                    Console.WriteLine("porfavor elije una de las opciones anteriores");
                    TheDecision();//uff si, recursividad si si si
                    break;
            }
            int untilnow = CountMeIn();
            if (untilnow < 21 && indicedecision < 3)
            {
                TheDecision();
            }
            if (untilnow == 21)
            {
                Console.WriteLine("O may GAH!! GANASTE!!!!");
            }
            if (indicedecision == 6)
            {
                Console.WriteLine("Terminaste el juego con {0} puntos", untilnow);
            }
            else
            {
                Console.WriteLine("Sorry dude, perdiste con {0}", untilnow);
            }





        }
    }
}
