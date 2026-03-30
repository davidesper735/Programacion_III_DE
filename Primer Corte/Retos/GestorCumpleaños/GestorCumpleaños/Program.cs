using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using GestorCumpleaños.Modelos;

/*
 * Crear un sistema que calcule días restantes para eventos espciales y los persista.
 * 
 * Solicita los datos de 3 amigos. Calcula cuántos dias faltan para su cumpleaños y guarda
 * el nombre y la fecha en un archivo llamado cumpleaños.txt.
 */

namespace GestorCumpleaños
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Gestor de Cumpleaños ======");

            for (int i = 0; i < 3; i++)
            {

                var amigo = new Amigo();

                Console.WriteLine($"Ingrese el nombre del amigo #{i + 1}:");
                amigo.Nombre = Console.ReadLine();

                Console.WriteLine($"Ingrese la fecha de nacimiento de {amigo.Nombre} (formato: dd/MM/yyyy): ");
                string fechaNacimiento = Console.ReadLine();

                int diasRestantes = CalcularDiasRestantes(fechaNacimiento);
                Console.WriteLine($"Faltan {diasRestantes} días para el cumpleaños de {amigo.Nombre}.");

                GuardarCumpleaños(amigo, fechaNacimiento);
            }
        }

        public static int CalcularDiasRestantes(string fechaNacimiento)
        {

            int total = 0;
            
            if (DateTime.TryParse(fechaNacimiento, out DateTime fechaNac))
            {
                DateTime hoy = DateTime.Today;
                DateTime proximoCumpleaños = new DateTime(hoy.Year, fechaNac.Month, fechaNac.Day);
                if (proximoCumpleaños < hoy)
                {
                    proximoCumpleaños = proximoCumpleaños.AddYears(1);
                }
                total = (proximoCumpleaños - hoy).Days;
            }

            return total;
            
        }

        public static void GuardarCumpleaños(Amigo amigo, string fechaNacimiento)
        {
            string rutaArchivo = "cumpleaños.txt";
            string contenido = $"{amigo.Nombre} - {fechaNacimiento}";
            File.AppendAllText(rutaArchivo, contenido + Environment.NewLine);
        }
    }
}
