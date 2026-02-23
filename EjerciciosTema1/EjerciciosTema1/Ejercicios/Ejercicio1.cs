using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*
 * Perfil de Usuario Gamer: 
 * Crea un programa que pida al usuario su Nickname, 
 * nivel de experiencia (1-100) y si tiene suscripción Premium (booleano). 
 * Al final, muestra un mensaje personalizado que le dé la bienvenida 
 * a su nivel correspondiente.
 * 
 */

namespace EjerciciosTema1.Ejercicios
{
    public class Ejercicio1
    {
        public static void Ejecutar()
        {

            Console.WriteLine("==========================================");
            Console.WriteLine("         PERFIL DE USUARIO GAMER          ");
            Console.WriteLine("==========================================");
            Console.WriteLine(" ");
            Console.Write("Ingrese su nickname: ");
            string nickname = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Ingrese su nivel de experiencia (1 - 100): ");
            int experiencia = VerificarExp();
            Console.WriteLine(" ");
            Console.Write("Contiene una suscripción Premium? ('S' para Sí y 'N' para No) ");
            bool suscripcion = VerificarSuscripcion();


            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("                   LEVEL UP!!!                    ");
            Console.WriteLine("==================================================");
            Console.WriteLine("Bienvenido, " + nickname + " has subido de nivel!");
            Console.WriteLine(" ");
            Console.WriteLine($"Tu nivel de experiencia actual es: {experiencia}");
            Console.WriteLine(" ");
            Console.WriteLine("Premium:" + (suscripcion ? "Sí" : "No"));

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.Write("Pulsa cualquier tecla para volver al menú.");
            Console.ReadKey();

        }

        private static int VerificarExp()
        {
            while (true)
            {
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int resultado))
                {
                    if (resultado >= 1 && resultado <= 100)
                    {
                        return resultado;
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un número mayor que 0 y menor o igual que 100");
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número entero.");
                }
            }
        }

        private static bool VerificarSuscripcion()
        {
            while (true)
            {
                string entrada = Console.ReadLine().Trim().ToUpper();
                if (entrada == "S")
                {
                    return true;
                }
                else if (entrada == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Debe ingresar 'S' para Sí o 'N' para No.");
                }
            }
        }

    }
}