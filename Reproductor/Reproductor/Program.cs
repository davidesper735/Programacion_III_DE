/*
 * App de Streaming de Música: 
 * Crea una interfaz IReproductor con métodos Play() y Stop(). 
 * Implementa esta interfaz en clases como Cancion y Podcast. 
 * El usuario debe poder "darle play" a cualquiera de los dos.
 */

using System;
using System.Collections.Generic;
using Reproductor.Interfaces;
using Reproductor.Modelos;

namespace Reproductor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al Reproductor de Música y Podcasts!");

            List<IReproductor> PlayList = new List<IReproductor>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("========= MENU =========");
                Console.WriteLine("1. Agregar canción");
                Console.WriteLine("2. Agregar podcast");
                Console.WriteLine("3. Reproducir todo");
                Console.WriteLine("4. Salir");

                Console.WriteLine(" ");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":

                        Console.Write("Ingrese el título de la canción: ");
                        string nombreCancion = Console.ReadLine();

                        Console.Write("Artista: ");
                        string artista = Console.ReadLine();

                        Console.Write("Album: ");
                        string album = Console.ReadLine();

                        PlayList.Add(new Cancion { Titulo = nombreCancion, Artista = artista, Album = album });

                        break;

                    case "2":

                        Console.Write("Ingrese el título del Podcast ");
                        string nombrePodcast = Console.ReadLine();

                        Console.Write("Creador: ");
                        string creador = Console.ReadLine();

                        Console.Write("Episodio: ");
                        int episodio = int.Parse(Console.ReadLine());

                        PlayList.Add(new Podcast { Titulo = nombrePodcast, Creador = creador, Episodio = episodio });
                        
                        break;

                    case "3":

                        Console.WriteLine("Reproduciendo playlist...");

                        foreach (var item in PlayList)
                        {
                            item.Play();
                        }

                        break;

                    case "4":

                        Console.WriteLine("Saliendo del reproductor. ¡Hasta luego!");

                        foreach (var item in PlayList)
                        {
                            item.Stop();
                        }

                        continuar = false;
                        break;
                }
            }
        }
    }
}