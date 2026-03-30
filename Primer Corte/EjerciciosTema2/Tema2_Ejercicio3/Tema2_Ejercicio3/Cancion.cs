using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Ejercicio3
{
    public class Cancion : IReproductor
    {

        public string nombre;

        public Cancion()
        {

        }
        public Cancion(string nombre)
        {
            this.nombre = nombre;
        }
        public void Play()
        {
            Console.WriteLine($"Reproduciendo canción: {this.nombre}");
        }

        public void Stop()
        {
            Console.WriteLine($"Deteniendo canción: {this.nombre}");
        }
    }
}