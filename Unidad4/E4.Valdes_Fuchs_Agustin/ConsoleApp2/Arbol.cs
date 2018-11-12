using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Arbol
    {
        public int Contador = 0;
        public Nodo top;
        public Arbol() { top = null; }
        public Arbol(string valor)
        {
            top = new Nodo(valor);
        }
        public void Agregarswitch(string L1, string L2, string L3, string L4, string R1, string R2, string R3, string R4,string daddy)
        {
            
            Agregar(top,  L1,  L2,  L3,  L4,  R1,  R2,  R3,  R4,daddy);

        }
        public void Agregar(  Nodo Y,string L1,string L2, string L3, string L4, string R1, string R2, string R3, string R4,string daddy)
        {// Y es el nodo al que se agregara el valor
            //L y R son los valores
            //daddy es la el valor guia del padre
            
                
            
                if (Y == null) { return;}
                if (Y.Valor == daddy)
                {
                    return;
                }
                //#Solo los chicos de los 90's recordaran haber hecho 8 metodos recursivos lol jk, lol jk?
                Agregar( Y.L1, L1, L2, L3, L4, R1, R2, R3, R4, daddy);
                Agregar( Y.L2, L1, L2, L3, L4, R1, R2, R3, R4, daddy);
                Agregar( Y.L3, L1, L2, L3, L4, R1, R2, R3, R4, daddy);
                Agregar( Y.L4, L1, L2, L3, L4, R1, R2, R3, R4, daddy);
                Agregar( Y.R1, L1, L2, L3, L4, R1, R2, R3, R4, daddy);
                Agregar( Y.R2, L1, L2, L3, L4, R1, R2, R3, R4, daddy);
                Agregar( Y.R3, L1, L2, L3, L4, R1, R2, R3, R4, daddy);
                Agregar( Y.R4, L1, L2, L3, L4, R1, R2, R3, R4, daddy);
                return;
            
        }
        public Nodo Fetch(ref Nodo Y, string father)
        {
            bool notfound = true;
            do
            {
                if (Y == null) { notfound = false; }
                if (Y.Valor == father) { return Y; }
                else
                {
                    if (Y.L1.Valor == father) { return Y.L1; }
                    if (Y.L2.Valor == father) { return Y.L2; }
                    if (Y.L3.Valor == father) { return Y.L3; }
                    if (Y.L4.Valor == father) { return Y.L4; }
                    if (Y.R1.Valor == father) { return Y.R1; }
                    if (Y.R2.Valor == father) { return Y.R2; }
                    if (Y.R3.Valor == father) { return Y.R3; }
                    if (Y.R4.Valor == father) { return Y.R4; }
                }

                Fetch(ref Y.L1, father);
                Fetch(ref Y.L2, father);
                Fetch(ref Y.L3, father);
                Fetch(ref Y.L4, father);
                Fetch(ref Y.R1, father);
                Fetch(ref Y.R2, father);
                Fetch(ref Y.R3, father);
                Fetch(ref Y.R4, father);
                return null;
            } while (notfound);
        }
        public void Impresion(ref Nodo Y)
        {
            if (Y == null) { return; }


            Contador++;
                
                for (int i = 0; i < Contador; i++)
                {
                    Console.Write("--");
                }
                Console.WriteLine(Y.Valor);

                Impresion(ref Y.L1);
                Impresion(ref Y.L2);
                Impresion(ref Y.L3);
                Impresion(ref Y.L4);
                Impresion(ref Y.R1);
                Impresion(ref Y.R2);
                Impresion(ref Y.R3);
                Impresion(ref Y.R4);
                
            
        }
        public void print()
        {
            Impresion(ref top);
            

        }
    }
}
