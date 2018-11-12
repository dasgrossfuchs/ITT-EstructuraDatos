using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Nodo
    {
        public Nodo Daddy;
        public string Valor;
        public Nodo L1;
        public Nodo L2;
        public Nodo L3;
        public Nodo L4;
        public Nodo R4;
        public Nodo R3;
        public Nodo R2;
        public Nodo R1;
        public Nodo(string x)
        {
            Daddy = null;
            Valor = x;
            L1 = null;
            L2 = null;
            L3 = null;
            L4 = null;
            R4 = null;
            R3 = null;
            R2 = null;
            R1 = null;
        }
        public Nodo(string x,Nodo dad)
        {
            Daddy = dad;
            Valor = x;
            L1 = null;
            L2 = null;
            L3 = null;
            L4 = null;
            R4 = null;
            R3 = null;
            R2 = null;
            R1 = null;
        }

    }
}
