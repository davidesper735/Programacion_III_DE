using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Ejercicio 3: Creador de Estructura de Proyectos (Directory y Path)
 * Objetivo: Automatizar la creación de carpetas y archivos iniciales para un proyecto imaginario.
 * 
 * Instrucciones:
 * 
 * Solicita al usuario el "Nombre del Proyecto".
 * Crea una carpeta principal con ese nombre usando Directory.CreateDirectory.
 * Dentro de esa carpeta, crea tres subcarpetas: documentos, imagenes y codigo.
 * Pide al usuario que ingrese una breve descripción del proyecto.
 * Crea un archivo llamado readme.txt dentro de la subcarpeta documentos (usa Path.Combine para la ruta) y guarda la descripción allí.
 * Muestra en consola la ruta absoluta donde se creó el proyecto usando Path.GetFullPath.
 */

namespace EstructuraDeProyectos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el nombre del proyecto: ");
            string nombreProyecto = Console.ReadLine();
            string principal = nombreProyecto;

            if (!Directory.Exists(principal)) 
            {
                Directory.CreateDirectory(principal);
                Console.WriteLine($"Carpeta Creada: {principal}");
            }

            string carpeta1 = Path.Combine(principal, "Documentos");
            string carpeta2 = Path.Combine(principal, "Imágenes");
            string carpeta3 = Path.Combine(principal, "Código");

            Directory.CreateDirectory(carpeta1);
            Directory.CreateDirectory(carpeta2);
            Directory.CreateDirectory(carpeta3);

            Console.Write("Ingresa una breve descripción del proyecto: ");
            string descripcion = Console.ReadLine();

            string rutaArchivo = "readme.txt";
            string rutaCompleta = Path.Combine(carpeta1, rutaArchivo);
            File.WriteAllText(rutaCompleta, descripcion);

            string rutaAbsoluta = Path.GetFullPath(principal);
            Console.WriteLine($"Proyecto creado en la ruta: {rutaAbsoluta}");

        }
    }
}
