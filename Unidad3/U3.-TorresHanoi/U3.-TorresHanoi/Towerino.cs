using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3._TorresHanoi
{
    class Towerino
    {
        public int biggest = 0;
        public int a = 0;
        Stack<int> TorreA = new Stack<int>();
        Stack<int> TorreB = new Stack<int>();
        Stack<int> TorreC = new Stack<int>();
        public void Babel()
        {
            Console.WriteLine("Cuantos discos existiran en la torre");
            biggest = int.Parse(Console.ReadLine());
            for (int i = biggest; i > 0 ; i--)
            {
                TorreA.Push(i);
            }
            Console.WriteLine("La torre ha sido creada");
            Teller();
            a++;
        }
        public void Teller()
        {
            
            foreach (var item in TorreA)
            {
                Console.WriteLine("A..{0}", item);
            }
            foreach (var item in TorreB)
            {
                Console.WriteLine("B..{0}", item);
            }
            foreach (var item in TorreC)
            {
                Console.WriteLine("C..{0}", item);
            }
            
        }
        private static void Loverboy(int discs,Stack<int> Torriniciar,Stack<int> Torrfin,Stack<int> Torrahora)
        {
            if (discs == 1)
            {
                Torrfin.Push(Torriniciar.Pop());
                return;
            }

            Loverboy(discs - 1, Torriniciar, Torrahora, Torrfin);

            Torrfin.Push(Torriniciar.Pop());

            Loverboy(discs - 1, Torrahora, Torrfin, Torriniciar);
        }
        public void Start()
        {
            Loverboy(biggest,TorreA,TorreC,TorreB);
            Console.WriteLine("Las torres han sido reorganizadas exitosamente");
        }
        
    }
}
