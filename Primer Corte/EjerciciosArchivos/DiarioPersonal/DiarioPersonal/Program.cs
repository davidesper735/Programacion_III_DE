using System;
using System.IO;
using System.Linq;

/*
 * Ejercicio 1: Diario Personal con Bitácora (Clase File y DateTime)
 * Objetivo: Crear un programa que permita al usuario escribir una entrada en su "diario" y guardarla automáticamente con la fecha y hora actual.
 * 
 * Instrucciones:
 * 
 * Solicita al usuario que ingrese su nombre al iniciar.
 * Pide al usuario que escriba un pensamiento o actividad del día por teclado.
 * Guarda el texto en un archivo llamado diario.txt.
 * Regla de oro: No debes sobrescribir lo anterior. Usa File.AppendAllText.
 * El formato de cada línea en el archivo debe ser: [FECHA Y HORA] - USUARIO: MENSAJE.
 * 
 * Reto extra: Al iniciar el programa, muestra las últimas 3 líneas guardadas en el diario antes de pedir una nueva entrada.
 * */

namespace DiarioPersonal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MostrarUltimasEntradas();

            Console.WriteLine("======= Bienvenido a tu Diario Personal =======");
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su pensamiento o actividad del día: ");
            string mensaje = Console.ReadLine();

            IngresarEntrada(nombre, mensaje);

        }

        public static void IngresarEntrada(string nombre, string mensaje)
        {
            string ruta = "diario.txt";

            string entrada = $"[{DateTime.Now}] - {nombre}: {mensaje}{Environment.NewLine}";

            if (File.Exists(ruta))
            {
                File.AppendAllText(ruta, entrada);
            }
            else
            {
                File.WriteAllText(ruta, entrada);
            }
           
        }

        public static void MostrarUltimasEntradas()
        {
            string ruta = "diario.txt";

            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);
                var ultimasLineas = lineas.Skip(Math.Max(0, lineas.Length - 3)).ToArray();
                Console.WriteLine("Últimas entradas en el diario:");
                foreach (var linea in ultimasLineas)
                {
                    Console.WriteLine(linea);
                }
            }
            else
            {
                Console.WriteLine("No hay entradas en el diario aún.");
            }
        }
    }
}
