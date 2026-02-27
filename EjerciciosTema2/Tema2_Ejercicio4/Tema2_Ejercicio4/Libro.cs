using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Ejercicio4
{
    internal class Libro
    {
        public string Titulo;

        public enum EstadoLibro { Disponible, Prestado }

        public EstadoLibro estado;

        public Libro() 
        { 
        }

        public Libro(string titulo)
        {
            this.Titulo = titulo;
         
        }

        public void Prestar()
        {
            if (estado == EstadoLibro.Disponible)
            {
                estado = EstadoLibro.Prestado;
                Console.WriteLine("El libro se ha prestado.");
            }
            else
            {
                Console.WriteLine("El libro no está disponible para prestar.");
            }
        }
    }
}
