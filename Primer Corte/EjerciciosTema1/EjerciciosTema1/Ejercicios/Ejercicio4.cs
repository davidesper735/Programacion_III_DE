using System;
using System.Collections.Generic;
using System.Text;

/*
 * Generador de Correos Corporativos: 
 * Pide al usuario su nombre y apellido. 
 * El programa debe generar un correo con el formato nombre.apellido@empresa.com 
 * (todo en minúsculas).
 */

namespace EjerciciosTema1.Ejercicios
{
    internal class Ejercicio4
    {

        public static void Ejecutar()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("         GENERADOR DE CORREOS CORPORATIVOS         ");
            Console.WriteLine("===================================================");
            Console.WriteLine(" ");

            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine().Trim().ToLower();

            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine().Trim().ToLower();

            string correo = $"{nombre}.{apellido}@empresa.com";

            Console.WriteLine("");
            Console.WriteLine($"Su correo corporativo generado es: {correo} ");


            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.Write("Pulsa cualquier tecla para volver al menú.");
            Console.ReadKey();
        }
    }
}
