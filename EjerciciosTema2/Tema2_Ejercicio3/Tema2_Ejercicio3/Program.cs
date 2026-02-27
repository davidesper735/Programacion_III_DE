using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * App de Streaming de Música: 
 * Crea una interfaz IReproductor con métodos Play() y Stop(). 
 * Implementa esta interfaz en clases como Cancion y Podcast. 
 * El usuario debe poder "darle play" a cualquiera de los dos.
 */

namespace Tema2_Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que quieres escuchar?: ");
            string eleccion = Console.ReadLine().ToLower();

            if (eleccion == "cancion")
            {
                Cancion cancion = new Cancion("Bohemian Rhapsody");

                cancion.Play();

                Console.WriteLine("Quieres detener la canción? S para 'Sí' y N para 'No'");
                string eleccion2 = Console.ReadLine().ToLower();

                if (eleccion2 == "s")
                {
                    cancion.Stop();
                }
                else if (eleccion2 == "n")
                {
                    Console.WriteLine("La canción sigue sonando");
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }

            }
            else if (eleccion == "podcast")
            {
                Podcast podcast = new Podcast("The Wild Project");

                podcast.Play();

                Console.WriteLine("Quieres detener la canción? S para 'Sí' y N para 'No'");
                string eleccion2 = Console.ReadLine().ToLower();

                if (eleccion2 == "s")
                {
                    podcast.Stop();
                }
                else if (eleccion2 == "n")
                {
                    Console.WriteLine("El podcast sigue sonando");
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }
    }
}
