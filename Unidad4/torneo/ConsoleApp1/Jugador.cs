using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Jugador
    {
        public string Name { get; set; }
        public Jugador Rival;
        public Jugador NextMatch;
        public bool Win = false;
        public List<int> BoteAbierto;
        public List<int> BoteCerrado;

        public Jugador(string nombrelocal)
        {
            Name = nombrelocal;
            BoteAbierto = new List<int>();
            
            BoteCerrado = new List<int>();
            BoteCerrado.Add(1);
        }
        public void SetRival(Jugador jugadorlocal)
        {
            Rival = jugadorlocal;
        }
        public void Winnah(List<int> listalocal)
        {
            foreach (var item in listalocal)
            {
                BoteAbierto.Add(item);
            }
            Win = true;
        }
        public void Ganador(Jugador jugadorlocal)
        {
            NextMatch = jugadorlocal;
        }
    }
}
