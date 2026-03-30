using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;
using BibliotecaDigital.Modelos;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<IPrestable> materiales = new List<IPrestable>();

        while (true)
        {
            Console.WriteLine("\nMenú Biblioteca Digital");
            Console.WriteLine("1. Agregar Libro");
            Console.WriteLine("2. Agregar Revista");
            Console.WriteLine("3. Agregar AudioLibro");
            Console.WriteLine("4. Mostrar Comprobantes de Préstamo");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    materiales.Add(new Libro(1, "Cien Años de Soledad", "Gabriel García Márquez", 1967, TipoCategoria.Ficcion, 417, "978-0307474728"));
                    break;
                case "2":
                    materiales.Add(new Revista(2, "National Geographic", "Varios", 2024, TipoCategoria.Ciencia, 150, "Mensual"));
                    break;
                case "3":
                    materiales.Add(new AudioLibro(3, "El Principito", "Antoine de Saint-Exupéry", 1943, TipoCategoria.Ficcion, TimeSpan.FromHours(2), "Narrador X"));
                    break;
                case "4":
                    foreach (var material in materiales)
                        material.GenerarComprobantePrestramo();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}