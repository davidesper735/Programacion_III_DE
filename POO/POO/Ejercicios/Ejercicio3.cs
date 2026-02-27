using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 3. Calculadora de Calificaciones (Clase Estudiante)
 * Objetivo: Procesar las notas de un alumno.
 * 
 * Clase: Estudiante.
 * Propiedades: Nombre, Materia y una lista o arreglo de Notas (3 parciales).
 * Métodos:
 * CalcularPromedio(): Devuelve el promedio de las 3 notas.
 * EstadoFinal(): Devuelve "Aprobado" si el promedio es >= 3.0 o "Reprobado" de lo contrario.
 * Interacción: El usuario ingresa el nombre del estudiante, la materia y las 3 notas una por una. 
 * Al final, el programa muestra el promedio y el estado.
 */

namespace POO.Ejercicios
{

    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public List<double> Notas { get; set; } = new List<double>();

        public void CalcularPromedio()
        {
            double promedio = this.Notas.Average();
            Console.WriteLine($"El promedio de {this.Nombre} en {this.Materia} es: {promedio}");
        }

        public string EstadoFinal()
        {
            double promedio = this.Notas.Average();
            return promedio >= 3.0 ? "Aprobado" : "Reprobado";
        }
    }

    public static class Ejercicio3
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 3: Calculadora de Calificaciones");

            Console.WriteLine(" ");

            Console.WriteLine("Ingrese el nombre del Estudiante: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la materia: ");
            string materia = Console.ReadLine();

            Estudiante estudiante = new Estudiante { Nombre = nombre, Materia = materia };

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Ingrese la nota del parcial {i}: ");
                double nota = double.Parse(Console.ReadLine());

                estudiante.Notas.Add(nota);
            }

            Console.Clear();

            estudiante.CalcularPromedio();

            Console.WriteLine($"Estado final: {estudiante.EstadoFinal()}");
        }
    }<
}
