using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3._VALDES_FUCHS_AGUSTIN
{
    class Puente
    {
        /*
         * se tienen dos listas simbolizando el lado donde esta el inicio y el final
         */
        LinkedList<Vaca> beforeBridge = new LinkedList<Vaca>();
        LinkedList<Vaca> afterBridge = new LinkedList<Vaca>();
        public void creacionismobovino()
        {
            /*
             * En el principio no habia nada, solo pollo, y nada mas, entonces
             * un destello de luz dio lugar a un fuego y del fuego salio un puente, y del puente
             * salio la necesidad de cruzar un puente y de esta necesidad, surgieron 4 vacas
             * Las vacas:
             * Nombre=Mazie
             * Ataque=43
             * Defensa=4
             * Descripcion= "Viene de una granja pequeña, se vio forzada a huir despues de que 
             *               Ronald mcDonald asesinara a sangre fria a su madre frente a ella
             *               desde entonces lo unico que busca es venganza,se unio a las vacas
             *               cruza puentes en el 2010 y desde entonces ha sido la que cuida
             *               de las demas, le gusta Daisy pero cree que ella nunca la notara."
             * Nombre=Daizy
             * Ataque=9
             * Defensa=25
             * Descripcion= "Viene de una familia rica, despues de que se cansara de la aburrida
             *              vida de nueva york, huyo de casa para perseguir aventura, su mayor
             *              fortaleza es la musica, y le gusta Mazie, aunque cree que ella usa
             *              demasiado maquillaje."
             * Nombre=Crazy
             * Ataque=666
             * Defensa=666
             * Descripcion= "Ninguna de las otras vacas sabe de su origen pero un dia llego pidiendo
             *               ayuda, ninguna de las otras se nego, esta se unio al grupo en el 2011
             *               meses despues que Mazie, nadie sabe su verdadero nombre, Crazy dice que
             *               este le trae demasiados recuerdos por lo que preferiria olvidarlo
             *               ,aunque es la vaca mas razonable del grupo le gusta su apodo."
             * Nombre=Lazy
             * Ataque=2
             * Defensa=155
             * Descripcion= "Lazy viene de Missouri, tras la tipica historia de vaca conoce vaquero
             *              vaca se enamora de vaquero, vaquero intenta matar a vaca para venderla a
             *              mcDonalds decidio que no le interesaba seguir por ese camino y se dio a 
             *              conocer como una vaca independiente que no necesita de ningun vaquero, la
             *              depresion la ha llevado a comer demasiado pasto, lo cual la hizo un poco
             *              obesa, gracias a esto fue contratada en el 2009 por una compañia que 
             *              prueba puentes, Daizy se le unio poco despues, y como un chiste decidieron
             *              llamar a su pequeño grupo LAS VACAS CRUZA PUENTES."
             */
            Vaca vaca1 = new Vaca();
            Vaca vaca2 = new Vaca();
            Vaca vaca3 = new Vaca();
            Vaca vaca4 = new Vaca();
            vaca1.Nombre = "Mazie";
            vaca1.Duracion = 2;
            vaca2.Nombre = "Daisy";
            vaca2.Duracion = 4;
            vaca3.Nombre = "Crazy";
            vaca3.Duracion = 10;
            vaca4.Nombre = "Lazy";
            vaca4.Duracion = 20;
            beforeBridge.AddLast(vaca1);
            beforeBridge.AddLast(vaca2);
            beforeBridge.AddLast(vaca3);
            beforeBridge.AddLast(vaca4);
            /*
             * Se agregaron todas las vacas inicializadas anteriormente a la lista de antes de cruzar
             */
        }
        Vaca vacariable = new Vaca();//variable tipo vaca tipo temporal
        int relojglobal;//reloj que guardara el tiempo de cruce total
        int max;//variable temporal
        public void cruce()
        {
            for (int i = 0; i < 2; i++)
            {
                max = 0;
                for (int ii = 0; ii < 2; ii++)
                {
                    vacariable = beforeBridge.First();
                    beforeBridge.RemoveFirst();
                    afterBridge.AddLast(vacariable);
                    if (max <= vacariable.Duracion) { max = vacariable.Duracion; }
                    Console.Write("\t{0} y",vacariable.Nombre);
                }
                Console.WriteLine("\b duraron {0}min en cruzar",max);//se imprime el nombre de las vacas que cruzaron y cuanto tiempo tomaron
                
                vacariable = afterBridge.First();
                afterBridge.RemoveFirst();
                beforeBridge.AddLast(vacariable);
                relojglobal = relojglobal + vacariable.Duracion +max;
                Console.WriteLine("{0} regreso en {1}min", vacariable.Nombre, vacariable.Duracion);//se imprime la vaca que regreso

            }
            max = 0;
            for (int ii = 0; ii < 2; ii++)
            {

                vacariable = beforeBridge.First();
                beforeBridge.RemoveFirst();
                afterBridge.AddLast(vacariable);
                
                if (vacariable.Duracion >= max) max = vacariable.Duracion;
                Console.Write("\t{0} y", vacariable.Nombre);
            }
            Console.WriteLine("\b duraron {0}min en cruzar", max);
            relojglobal = relojglobal + max;
            Console.WriteLine("Felicidades todas sus vacas cruzaron exitosamente en {0}min",relojglobal);
        }
        
    }
}
