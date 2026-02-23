using System;
using System.Collections.Generic;
using System.Text;

/*
 * Control de Aforo en Eventos: 
 * Una discoteca tiene un aforo máximo de 50 personas. 
 * Crea un programa que pregunte cuántas personas quieren entrar. 
 * Si hay cupo, dales la bienvenida; si no, 
 * indícales cuántas personas deben salir para que ellos puedan entrar.
 */

namespace EjerciciosTema1.Ejercicios
{
    internal class Ejercicio3
    {
        public static void Ejecutar()
        {
            Console.WriteLine("===================================================");
            Console.WriteLine("         CONTROL DE AFORO EN EVENTOS               ");
            Console.WriteLine("===================================================");
            Console.WriteLine(" ");

            int maximo = 50;

            Console.Write("¿Cuántas personas quieren entrar? ");
            int personas = VerificarPersonas();

            if (personas <= maximo)
            {
                Console.WriteLine("Bienvenidos! Pueden entrar.");
            }
            else
            {
                int excedente = personas - maximo;
                Console.WriteLine($"Lo siento, el aforo máximo es de {maximo} personas. " +
                                  $"Por favor, {excedente} personas deben salir para que puedan entrar.");
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.Write("Pulsa cualquier tecla para volver al menú.");
            Console.ReadKey();
        }

        private static int VerificarPersonas()
        {
            while (true)
            {
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int resultado) && resultado > 0)
                {
                    return resultado;
                }
                else
                {
                    Console.Write("Debe ingresar un número entero.");
                }
            }
        }
    }
}
