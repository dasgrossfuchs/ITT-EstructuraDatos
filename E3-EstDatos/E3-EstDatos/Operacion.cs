using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    public class Operacion
    {
        public void Principal()
        {
            Stack Lista = new Stack();
            Queue Cola = new Queue();

        }

        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            Stack Lista = new Stack();
            Lista.Push(5);
            Lista.Push(3);
            Console.WriteLine(Lista.Pop());
            Lista.Push(2);
            Lista.Push(8);
                Console.WriteLine(Lista.Pop());
                Console.WriteLine(Lista.Pop());
                Lista.Push(9);
                Lista.Push(1);
                Console.WriteLine(Lista.Pop());
                Lista.Push(7);
                Lista.Push(6);
                Console.WriteLine(Lista.Pop());
                Console.WriteLine(Lista.Pop());
                Lista.Push(4);
                    Console.WriteLine(Lista.Pop());
                    Console.WriteLine(Lista.Pop());
        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
            bool x = true;
            int contador = 0;
            LinkedList<string> Listapalabra = new LinkedList<string>();
            LinkedList<char> Listaliteral = new LinkedList<char>();
            while (x == true)
            {
                Console.WriteLine("Escriba la palabra que desea agregar a la lista");
                string temp= Console.ReadLine();
                Console.WriteLine("Escriba literal que desea agregar a la lista,si captura mas de una solo se tomara en cuanta la primera");
                string temp1 = Console.ReadLine();
                contador++;
                char temp2 = temp1.ToArray().First();
                Listapalabra.AddLast(temp);
                Listaliteral.AddLast(temp2);
                Console.WriteLine("Desea capturar otro elemento? s/n");
                string opc = Console.ReadLine();
                if (opc.ToLower() != "s") x = false;
            }
            for (int i = 0; i < contador; i++)
            {
                 char chartemp = Listaliteral.First();
                string stringtemp = Listapalabra.First();
                Listaliteral.RemoveFirst();
                Listapalabra.RemoveFirst();
                Console.WriteLine("{0}.-{1}",chartemp,stringtemp);
            }
        }

        public void Ejercicio3()
        {
            //mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            var w1 = Stopwatch.StartNew();
            var w2 = Stopwatch.StartNew();
            List<int> lista = new List<int>();
            w1.Start();
            for (int i = 0; i < 9876; i++)
            {
                lista.Add(i);
            }
            w1.Stop();
            LinkedList<int> liga = new LinkedList<int>();
            w2.Start();
            for (int i = 0; i < 9876; i++)
            {
                liga.AddFirst(i);
            }
            w2.Stop();
            Console.WriteLine("La lista normal duro {0}ms",w1.ElapsedMilliseconds);
            Console.WriteLine("La lista ligada duro {0}ms", w2.ElapsedMilliseconds);
        }

        public void Ejercicio4()
        {

            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.
            //public int Media { get; set; }
            Console.WriteLine("Nombre del maestro");
            string name = Console.ReadLine();
            Console.WriteLine("Nombre de la clase");
            string classname = Console.ReadLine();
            List < Clase > listaclase = new List<Clase>();
            Clase clase;
            for (int i = 0; i < 30; i++)
            {
                clase = new Clase();
                clase.Maestro = name;
                clase.NombreClase = classname;
                Console.WriteLine("Nombre alumno {0}",i+1);
                clase.Alumno = Console.ReadLine();
                Console.WriteLine("Calificacion alumno {0}", i + 1);
                clase.Calificacion = int.Parse(Console.ReadLine());
                listaclase.Add(clase);
            }
            
        }
    }
}
