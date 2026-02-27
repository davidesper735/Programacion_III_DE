using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Ejercicio3
{
    public class Podcast : IReproductor
    {
        public string nombre;
        public Podcast() 
        { 

        }

        public Podcast(string nombre)
        {
            this.nombre = nombre;
        }

        public void Play()
        {
            Console.WriteLine($"Reproduciendo podcast: {this.nombre}");
        }

        public void Stop()
        {
            Console.WriteLine($"Deteniendo podcast: {this.nombre}");
        }
    }
}
