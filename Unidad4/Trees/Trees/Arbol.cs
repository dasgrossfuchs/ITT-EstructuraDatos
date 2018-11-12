using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Arbol
    {
        Queue<Nodo> cola = new Queue<Nodo>();
        public void Inicio()
        {
            PlantarArbol("A",1);//se que no tiene sentido, pero funciona y eso es lo que cuenta no  uwu 
            PlantarArbol("B", 2);
            PlantarArbol("D", 3);
            PlantarArbol("G", 4);
            PlantarArbol("E", 3);
            PlantarArbol("H", 4);
            PlantarArbol("I", 4);
            PlantarArbol("C", 2);
            PlantarArbol("F", 3);
            PlantarArbol("J", 4);
            PlantarArbol("K", 5);
            

        }
        
        public void PlantarArbol(string id,int lvl)
        {
            Nodo nodosensual = new Nodo();
            nodosensual.Value = id;
            nodosensual.Haltura = lvl;
            cola.Enqueue(nodosensual);
        }
        public void ImpresionArbol()
        {
            foreach (var item in cola)
            {
                for (int i = 1; i < item.Haltura; i++)
                {
                    Console.Write("---");
                }
                Console.WriteLine(item.Value);
            }
        }
    }
    public class Nodo
    {
        public string Value { get; set; }
        public int Haltura { get; set; } 

    }
}
