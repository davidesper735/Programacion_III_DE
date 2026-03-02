using System;
using Reproductor.Interfaces;

namespace Reproductor.Modelos
{
    public class Podcast : IReproductor
    {
        public string Titulo { get; set; }

        public string Creador { get; set; }

        public int Episodio { get; set; }
        public void Play()
        {
            Console.WriteLine($"Reproduciendo el podcast: {Titulo} del creador {Creador} en el episodio {Episodio}");
        }

        public void Stop()
        {
            Console.WriteLine($"Deteniendo el podcast: {Titulo} del creador {Creador} en el episodio {Episodio}");
        }
    }
}
