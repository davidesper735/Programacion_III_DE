using System;
using GestorDeContactos.Modelos;
using System.IO;

/*
 * Ejercicio 2: Gestor de Contactos Simple (Formato CSV)
 * 
 * Objetivo: Aplicar el concepto de datos estructurados para guardar una pequeña agenda de contactos.
 * 
 * Instrucciones:
 * 
 * Crea una clase Contacto con las propiedades: Nombre, Telefono y Correo.
 * Solicita estos tres datos al usuario por teclado.
 * Implementa un método ToCSV() en la clase que devuelva los datos separados por punto y coma (;).
 * Guarda el contacto en un archivo contactos.csv.
 * Validación: Antes de guardar, usa String.Trim() y String.ToLower() para normalizar el correo electrónico.
 * Al finalizar, pregunta al usuario si desea "Listar contactos". Si dice que sí, lee el archivo, haz un Split(';') y muestra los datos en una tabla limpia en la consola.
 */

namespace GestorDeContactos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("==================================");
            Console.WriteLine("         GESTOR DE CONTACTOS      ");
            Console.WriteLine("==================================\n");

            string ruta = "Contacto.csv";

            bool salida = true;

            do
            {
                Console.Write("Ingrese el nombre del contacto: ");
                string nombre = Console.ReadLine();

                Console.Write($"Ingrese el número de teléfono de {nombre}: ");
                string telefono = Console.ReadLine();

                Console.Write($"Ingrese el correo electrónico de {nombre}: ");
                string correo = Console.ReadLine().Trim().ToLower();

                var contacto = new Contacto();
                contacto.Nombre = nombre;
                contacto.Telefono = telefono;
                contacto.Correo = correo;

                File.AppendAllText(ruta, contacto.ToCSV() + Environment.NewLine);

                Console.WriteLine("\n¿Desea ver la lista de contactos? (S/N)");
                if (RespuestaSalida())
                {
                    ListaContactos(ruta);
                }

                Console.WriteLine("\n¿Desea agregar otro contacto? (S/N)");
                salida = RespuestaSalida();

            } while (salida);

        }
        public static bool RespuestaSalida()
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

        public static void ListaContactos(string ruta)
        {
            if (File.Exists(ruta))
            {
                Console.WriteLine("==================================");
                Console.WriteLine("         LISTA DE CONTACTOS       ");
                Console.WriteLine("==================================\n");

                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');

                    if (datos.Length == 3)
                    {
                        Console.WriteLine($"{datos[0]}\t\t{datos[1]}\t\t{datos[2]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("El archivo CSV no Existe.");
            }
        }
    }
}
