using System;
using System.Collections.Generic;
using System.Text;

/*
 * Simulador de Semáforo Inteligente: 
 * Pide al usuario que ingrese el color actual del semáforo (Verde, Amarillo, Rojo). 
 * Si es verde, imprime "Sigue adelante"; si es amarillo, 
 * "Prepárate para frenar"; y si es rojo, "¡Detente!".
 */

namespace EjerciciosTema1.Ejercicios
{
    internal class Ejercicio5
    {
        public static void Ejecutar()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("         SIMULADOR DE SEMÁFORO INTELIGENTE         ");
            Console.WriteLine("===================================================");
            Console.WriteLine(" ");

            Console.Write("Ingrese el color actual del semáforo (Verde, Amarillo, Rojo): ");
            string color = VerificarColor();

            switch (color)
            {
                case "verde":
                    Console.WriteLine("Sigue adelante");
                    break;
                case "amarillo":
                    Console.WriteLine("Prepárate para frenar");
                    break;
                case "rojo":
                    Console.WriteLine("¡Detente!");
                    break;
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.Write("Pulsa cualquier tecla para volver al menú.");
            Console.ReadKey();
        }

        private static string VerificarColor()
        {
            while (true)
            {
                string entrada = Console.ReadLine().Trim().ToLower();
                if (entrada == "verde" || entrada == "amarillo" || entrada == "rojo")
                {
                    return entrada;
                }
                else
                {
                    Console.Write("Color no válido. Por favor, ingrese Verde, Amarillo o Rojo: ");
                }
            }
        }
    }
}