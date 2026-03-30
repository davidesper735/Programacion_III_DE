using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;
using SistemaRestaurante.Modelos;

/*Crear un sistema para un restaurante que maneja diferentes tipos de platos: Entradas, PlatosPrincipales y Postres. Cada tipo de plato tiene tiempos de preparación y costos diferentes.
 * Estructura de Carpetas Requerida
 * 
 * SistemaRestaurante\
 * ├── Enums\
 * │   ├── TipoComida.cs           ← Vegetariana, Vegana, Carnivora, Mariscos
 * │   ├── NivelDificultad.cs      ← Facil, Intermedio, Avanzado
 * │   └── EstadoOrden.cs          ← Pendiente, Preparando, Listo, Entregado
 * ├── Interfaces\
 * │   └── IPreparable.cs          ← ContratoPreparacion
 * ├── Modelos\
 * │   ├── Plato.cs                ← Clase abstracta base
 * │   ├── Entrada.cs              ← Hereda de Plato
 * │   ├── PlatoPrincipal.cs       ← Hereda de Plato
 * │   └── Postre.cs               ← Hereda de Plato
 * └── Program.cs
 * 
 * CLASES HIJAS a crear:
 * 
 * Entrada: Propiedades → bool EsFria, int Porciones
 * PlatoPrincipal: Propiedades → string ProteinaPrincipal, bool IncluyeGuarnicion
 * Postre: Propiedades → bool ContieneLactosa, int CaloriasPorPorcion
 * 
 * LÓGICA DE NEGOCIO:
 * Entrada: Tiempo = EsFria ? 10min : 20min
 * PlatoPrincipal: Tiempo = 30min + (Dificultad * 15min)
 * Postre: Tiempo = 25min + (ContieneLactosa ? 5min : 0)
 */

namespace SistemaRestaurante
{
    internal class Program
    {
        private static List<IPreparable> menu = new List<IPreparable>();
        private static int siguienteId = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema del restaurante");

            int opcion;

            do
            {
                MostrarMenu();
                Console.WriteLine("Seleccione una opción:");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }

                Console.WriteLine("Presione Enter para continuar...");
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 6);
        }

        private static void MostrarMenu()
        {
            Console.WriteLine("========= MENU PRINCIPAL =========");
            Console.WriteLine("1. Agregar Entrada");
            Console.WriteLine("2. Agregar Plato Principal");
            Console.WriteLine("3. Agregar Postre");
            Console.WriteLine("4. Generar Orden de Cocina");
            Console.WriteLine("5. Mostrar Todos los Platos");
            Console.WriteLine("6. Salir");
        }

        private static void ProcesarOpcion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    AgregarEntrada();
                    break;
                case 2:
                    AgregarPlatoPrincipal();
                    break;
                case 3:
                    AgregarPostre();
                    break;
                case 4:
                    GenerarOrdenCocina();
                    break;
                case 5:
                    MostrarTodosLosPlatos();
                    break;
                case 6:
                    Console.WriteLine("Gracias por usar el sistema del restaurante. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    break;
            }
        }

        private static void AgregarEntrada()
        {
            Console.WriteLine("Ingrese el nombre de la entrada:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la descripción de la entrada:");
            string descripcion = Console.ReadLine();

            Console.WriteLine("Ingrese el precio base de la entrada:");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            TipoComida tipoComida = LeerTipoComida();

            NivelDificultad dificultad = LeerNivelDificultad();

            EstadoOrden estadoOrden = LeerEstadoOrden();

            Console.WriteLine("¿Es fría? (s/n):");
            bool esFria = Console.ReadLine().ToLower() == "s";

            Console.WriteLine("Ingrese el número de porciones:");
            int porciones = int.Parse(Console.ReadLine());

            string id = $"E{++siguienteId}";
            Entrada nuevaEntrada = new Entrada(id, nombre, descripcion, precioBase, tipoComida, dificultad, EstadoOrden.Pendiente, esFria, porciones);
            menu.Add(nuevaEntrada);

            Console.WriteLine($"Entrada '{nombre}' agregada al menú con ID: {id}");
        }

        private static void AgregarPlatoPrincipal()
        {
            Console.WriteLine("Ingrese el nombre del plato principal:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la descripción del plato principal:");
            string descripcion = Console.ReadLine();

            Console.WriteLine("Ingrese el precio base del plato principal:");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            TipoComida tipoComida = LeerTipoComida();

            NivelDificultad dificultad = LeerNivelDificultad();

            EstadoOrden estadoOrden = LeerEstadoOrden();

            Console.WriteLine("Ingrese la proteína principal:");
            string proteinaPrincipal = Console.ReadLine();

            Console.WriteLine("¿Incluye guarnición? (s/n):");
            bool incluyeGuarnicion = Console.ReadLine().ToLower() == "s";

            string id = $"PP{++siguienteId}";
            PlatoPrincipal nuevoPlatoPrincipal = new PlatoPrincipal(id, nombre, descripcion, precioBase, tipoComida, dificultad, EstadoOrden.Pendiente, proteinaPrincipal, incluyeGuarnicion);
            menu.Add(nuevoPlatoPrincipal);

            Console.WriteLine($"Plato Principal '{nombre}' agregado al menú con ID: {id}");
        }

        private static void AgregarPostre()
        {
            Console.WriteLine("Ingrese el nombre del postre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la descripción del postre:");
            string descripcion = Console.ReadLine();

            Console.WriteLine("Ingrese el precio base del postre:");
            decimal precioBase = decimal.Parse(Console.ReadLine());

            TipoComida tipoComida = LeerTipoComida();

            NivelDificultad dificultad = LeerNivelDificultad();

            EstadoOrden estadoOrden = LeerEstadoOrden();

            Console.WriteLine("¿Contiene lactosa? (s/n):");
            bool contieneLactosa = Console.ReadLine().ToLower() == "s";

            Console.WriteLine("Ingrese las calorías por porción:");
            int caloriasPorPorcion = int.Parse(Console.ReadLine());

            string id = $"P{++siguienteId}";
            Postre nuevoPostre = new Postre(id, nombre, descripcion, precioBase, tipoComida, dificultad, EstadoOrden.Pendiente, contieneLactosa, caloriasPorPorcion);
            menu.Add(nuevoPostre);
            Console.WriteLine($"Postre '{nombre}' agregado al menú con ID: {id}");

        }

        private static TipoComida LeerTipoComida()
        {
            Console.WriteLine("Seleccione el tipo de comida (1. Vegetariana, 2. Vegana, 3. Carnivora, 4. Mariscos):");
            int opcion = int.Parse(Console.ReadLine());
            return (TipoComida)(opcion - 1);
        }

        private static NivelDificultad LeerNivelDificultad()
        {
            Console.WriteLine("Seleccione el nivel de dificultad (1. Facil, 2. Intermedio, 3. Avanzado):");
            int opcion = int.Parse(Console.ReadLine());
            return (NivelDificultad)(opcion - 1);
        }

        private static EstadoOrden LeerEstadoOrden()
        {
            Console.WriteLine("Seleccione el estado de la orden (1. Pendiente, 2. Preparando, 3. Listo, 4. Entregado):");
            int opcion = int.Parse(Console.ReadLine());
            return (EstadoOrden)(opcion - 1);
        }

        private static void GenerarOrdenCocina()
        {
            Console.WriteLine("Ingrese el ID del plato para generar la orden de cocina:");
            string id = Console.ReadLine();
            IPreparable platoSeleccionado = menu.FirstOrDefault(p => ((Plato)p).Id == id);
            if (platoSeleccionado != null)
            {
                platoSeleccionado.GenerarOrdenCocina();
            }
            else
            {
                Console.WriteLine($"No se encontró un plato con ID: {id}");
            }
        }

        private static void MostrarTodosLosPlatos()
        {
            Console.WriteLine("========= PLATOS EN EL MENÚ =========");

            if (menu.Count == 0)
            {
                Console.WriteLine("No hay platos en el menú.");
                return;
            }

            foreach (var plato in menu)
            {
                ((Plato)plato).MostrarInformacionNutricional();
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
