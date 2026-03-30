using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using POO.Ejercicios;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("======================");
            Console.WriteLine("    EJERCICIOS POO    ");
            Console.WriteLine("======================");
            Console.WriteLine(" ");
            Console.WriteLine("1. Simulador de Cajero Automático (Clase Cuenta)");
            Console.WriteLine(" ");
            Console.WriteLine("Seleccione el ejercicio a ejecutar:");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    Ejercicio1.Ejecutar();
                    break;

                case 2:

                    Ejercicio2.Ejecutar();
                    break;

                case 3:

                    Ejercicio3.Ejecutar();
                    break;

                default:

                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción entre 1 y 3.");
                    break;

            }

        }
    }
}
