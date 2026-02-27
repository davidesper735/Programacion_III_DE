using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Sistema de Biblioteca: 
 * Crea una clase Libro que tenga un estado (Disponible o Prestado). 
 * Crea un método Prestar() que cambie el estado solo si el libro está disponible.
 */

namespace Tema2_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro("Historia general de los robos y asesinatos de los más famosos piratas");

            libro.Prestar();
            libro.Prestar();

        }
    }
}
