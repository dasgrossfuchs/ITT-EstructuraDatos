using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol A = new Arbol("E");//La raiz es E
            A.Agregarswitch("A",null,null,null,"F",null,null,null,"E");//en este caso el padre es E
            A.Agregarswitch(null, null, null, null, "B", "C","D",null, "A");//papa es A
            A.print();
            A.Fetcher("B");
            A.Fetcher("C");
            A.Fetcher("D");

            Arbol B = new Arbol("C");//La raiz es E
            B.Agregarswitch("A", null, null, null, "D", "F", "G", null, "C");//en este caso el padre es C
            B.Agregarswitch(null, null, null, null, "B", null,null, null, "A");//papa es A
            B.Agregarswitch(null, null, null, null, "E", null, null, null, "B");//papa es B
            B.print();
            B.Fetcher("E");


            Arbol C = new Arbol("K");//La raiz es E
            C.Agregarswitch("A", "B", "C", "D", null, null, null, null, "K");//en este caso el padre es K
            C.Agregarswitch(null, null, null, null, "E", "I", null, null, "D");//papa es D
            C.Agregarswitch(null, null, null, null, "F", "G", null, null, "E");//papa es E
            C.Agregarswitch(null, null, null, null, "J", null, null, null, "I");//papa es I
            C.Agregarswitch(null, null, null, null, "H", null, null, null, "G");//papa es G
            C.print();
            C.Fetcher("H");
            //HAY UN ERROR EN EL METODO DE IMPRESION, REALMENTE CREI QUE FUNCIONARIA 
            //solo que no estoy muy familizarizado con el funionamiento de ref
        }
    }
    
}
