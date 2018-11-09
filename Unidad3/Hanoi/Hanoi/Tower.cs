using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Tower
    { //se declaran las torres
        int discostotales = 0;
        Stack<Disco> TorreA = new Stack<Disco>();
        Stack<Disco> TorreB = new Stack<Disco>();
        Stack<Disco> TorreC = new Stack<Disco>();
        public void Crear()
        { 
            //se crean los discos de manera descendiente en la primera torre
            Console.WriteLine("Cuantos discos tendra la torre?");
            discostotales = int.Parse(Console.ReadLine());
            for (int i = discostotales; i > 0; i--)
            {
                Disco discotemp = new Disco();
                discotemp.Valor = i;
                TorreA.Push(discotemp);
            }
        }
        public void Checkup()
        { //impresion de torres
            foreach (var item in TorreA)
            {
                Console.Write("A");
                Console.WriteLine(item.Valor);
            }
            foreach (var item in TorreB)
            {
                Console.Write("B");
                Console.WriteLine(item.Valor);
            }
            foreach (var item in TorreC)
            {
                Console.Write("C");
                Console.WriteLine(item.Valor);
            }
        }
        public void StartHanoi()
        { //se crea el disco mas grande que es el que se quiere llevar a la torre final
            Disco disco = new Disco();
            disco.Valor=discostotales;
            //El metodo recursivo busca que 
            //Disco--> sea el disco mas grande de la serie
            //TorreA-->Sea la torre de origen
            //TorreB-->Sea una torre auxiliar
            //TorreC --> Sea la torre destino
            Move(disco,TorreA,TorreC,TorreB);
        }
        public void Move(Disco DiscoBase, Stack<Disco> TorreOrigen, Stack<Disco> TorreFinal, Stack<Disco> TorreApoyo)
        {//a partir de recursividad llevamos el disco mas grande hasta el final
            if (DiscoBase.Valor == 1)
            {//ya que en caso de que el disco sea de tamaño uno no hay uno mas pequeño que este este se mueve sin llamar al metodo recursivo
                //en caso de que sea 1 lo que hace es A-->C
                TorreFinal.Push(TorreOrigen.Pop());
                return;
            }
            Disco discotemp = new Disco();//disco temporal que simboliza el disco base de la operacion
            discotemp.Valor = DiscoBase.Valor - 1;
            Move(discotemp, TorreOrigen, TorreApoyo, TorreFinal);//(Disco del momento/A/B/C)

            TorreFinal.Push(TorreOrigen.Pop());//se mueve el disco a la torre que este en la posicion de torre final en este caso
            //A o B --> B o C

            Move(discotemp, TorreApoyo, TorreFinal, TorreOrigen);//(Disco del momento/B/C/A)
            //ya que este metodo usa recursividad doble, demasiados discos haran muy tardio el proceso
        }
    }
}
