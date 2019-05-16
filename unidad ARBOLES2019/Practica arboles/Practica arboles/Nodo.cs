using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_arboles
{
    class Nodo
    {
        public int info { get; set; }
        public Nodo R { get; set; }
        public Nodo L { get; set; }
        public Nodo()//constructor sin valor
        { R = null;L = null; }
        public Nodo(int newinfo)//constructor con valor
        { R = null; L = null;info = newinfo; }
    }
}
