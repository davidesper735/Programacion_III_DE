using System;
using EjerciciosTema1.Ejercicios;

namespace EjerciciosTema1
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            bool salir = false;

            while(!salir)
            {
                Console.Clear();

                Console.WriteLine("==========================================");
                Console.WriteLine("        ELIGE A QUE EJERCICIO ACCEDER     ");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. Perfil de Usuario Gamer");
                Console.WriteLine("2. Calculadora de Propina Solidaria");
                Console.WriteLine("3. Control de Afaro en Eventos");
                Console.WriteLine("4. Generador de Correos Corporativos");
                Console.WriteLine("5. Simulador de Semáforo Inteligente");
                Console.WriteLine("0. Salir");
                Console.WriteLine("------------------------------------------");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();

                Console.Clear();

                switch (opcion)
                {

                    case "0":

                        salir = true;
                        Console.WriteLine("Gracias por usar el programa.");
                        break;

                    case "1":

                        Ejercicio1.Ejecutar();
                        break;

                    case "2":

                        Ejercicio2.Ejecutar();
                        break;

                    case "3":

                        Ejercicio3.Ejecutar();
                        break;

                    case "4":

                        Ejercicio4.Ejecutar();
                        break;

                    case "5":

                        Ejercicio5.Ejecutar();
                        break;

                    default:
                        Console.WriteLine("Ingresa una opción válida. ");
                        break;
                }
            }
        }
    }
}