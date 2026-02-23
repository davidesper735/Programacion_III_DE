using System;
using System.Collections.Generic;
using System.Text;

/*
 * Calculadora de Propina Solidaria: 
 * Pide el total de una cuenta en un restaurante. 
 * Pregunta qué porcentaje de propina desea dejar (10%, 15% o 20%). 
 * Si el total con propina supera los $100.000, 
 * muestra un mensaje agradeciendo su generosidad.
 * 
 */

namespace EjerciciosTema1.Ejercicios
{
    internal class Ejercicio2
    {
        public static void Ejecutar()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("         CALCULADORA DE PROPINA SOLIDARIA          ");
            Console.WriteLine("===================================================");
            Console.WriteLine(" ");

            Console.Write("Ingrese el total de la cuenta: ");
            int cuenta = VerificarTotal();
            Console.WriteLine(" ");

            Console.Write("¿Qué porcentaje de propina desea dejar?");
            int propina = VerificarPropina();
            Console.WriteLine(" ");

            Console.Clear();
             
            double totalPropina = cuenta + (cuenta * propina / 100.0);

            if (totalPropina > 100000)
            {
                Console.WriteLine("Muchas gracias por su generosidad. El total con propina es: " + totalPropina);
            }
            else
            {
                Console.WriteLine("El total con propina es: " + totalPropina);
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.Write("Pulsa cualquier tecla para volver al menú.");
            Console.ReadKey();
        }

        private static int VerificarTotal()
        {
            while (true)
            {
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int resultado))
                {
                    return resultado;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número entero.");
                }
            }
        }

        private static int VerificarPropina()
        {
            while (true)
            {
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out int resultado))
                {
                    if (resultado == 10 || resultado == 15 || resultado == 20)
                    {
                        return resultado;
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un número entero: 10, 15 o 20.");
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número entero: 10, 15 o 20.");
                }
            }
        }
    }
}
