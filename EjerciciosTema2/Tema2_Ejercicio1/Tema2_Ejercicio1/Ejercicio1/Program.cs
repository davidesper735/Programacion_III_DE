using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Sistema de Mascotas Virtuales: 
 * Crea una clase base Mascota con un nombre y 
 * un método HacerTruco(). 
 * Crea clases derivadas como Loro (que repita una frase) y 
 * Gato (que amase pan). 
 * Usa una lista para que el usuario elija qué mascota quiere ver actuar.
 */

namespace EjerciciosTema2.Ejercicio1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Loro loro = new Loro();
            Gato gato = new Gato();

            loro.setNombre("Polly");
            gato.setNombre("Moncú");

            List<Mascota> mascotas = new List<Mascota>();

            mascotas.Add(loro);
            mascotas.Add(gato);

            Console.WriteLine("¿Qué mascota quieres ver actuar? (1: Loro, 2: Gato)");
            int eleccion = int.Parse(Console.ReadLine());

            Console.WriteLine(mascotas[eleccion - 1].HacerTruco());

        }

    }
}
