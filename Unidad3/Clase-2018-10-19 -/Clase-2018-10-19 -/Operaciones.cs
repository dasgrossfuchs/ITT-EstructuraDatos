using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2018_10_19__
{
    class Operaciones
    {
        public void Principal()
        {
            Console.WriteLine("Ingrese la cantidad de automoviles");
            int cantidad = int.Parse(Console.ReadLine());
            Auto carro;
            List<Auto> carros = new List<Auto>();
            for (int i = 0; i < cantidad; i++)
            {
                carro = new Auto();
                carro.ID = i + 1;
                Console.WriteLine("Marca");
                carro.MARCA = Console.ReadLine();
                Console.WriteLine("Modelo");
                carro.MODELO = Console.ReadLine();
                Console.WriteLine("Año");
                carro.YEAR = int.Parse(Console.ReadLine());
                Console.WriteLine("Color");
                carro.COLOR = Console.ReadLine();
                Console.WriteLine("Placa");
                carro.PLACA = Console.ReadLine();
                carros.Add(carro);
            }
            
            foreach (Auto item in carros)
            {
                Console.WriteLine(item.ID+item.MARCA+item.MODELO+item.PLACA+item.YEAR+item.COLOR);
            }
            var carroAzules = (from c in carros where c.COLOR == "azul" select c).ToList();
            foreach (var item in carroAzules)
            {
                //muestra la lista de carros con color azul
            }
        }
    }
}
