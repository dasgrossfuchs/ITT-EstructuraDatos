using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_arboles
{
    class Arbol
    {
        
        public Nodo raiz = new Nodo();
        
        public Arbol() { raiz = null; }
        
        public void Agregar(Nodo go,int info)
        {
            Nodo nuevo = new Nodo(info);
            if (go == null)
            { go = nuevo; }
            else
            {
                if (info < go.info)
                {
                    Agregar(go.L,info);
                    return;
                }
                else
                {
                    Agregar(go.R,info);
                    return;
                }
            }
            
        }
        public void print(Nodo go)
        {
            if (go == null)
            {
                return;
            }
            else
            {
                print(go.L);
                Console.WriteLine(go.info);
                print(go.R);
                
            }
        }
    }
}
