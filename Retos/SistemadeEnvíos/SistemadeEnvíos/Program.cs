using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemadeEnvíos.Enum;
using SistemadeEnvíos.Modelos;
using System.IO;

namespace SistemadeEnvíos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ruta = "envios.csv";
            int opcion;

            do
            {
                Console.WriteLine("============================");
                Console.WriteLine("     SISTEMA DE ENVIOS      ");
                Console.WriteLine("============================");

                Console.WriteLine("1. Nuevo Envío.");
                Console.WriteLine("2. Reporte de Carga");
                Console.WriteLine("3. Buscar por Guía");
                Console.WriteLine("4. Salir");

                Console.Write("Ingresa una opción ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    ProcesarOpcion(opcion, ruta);
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                }
            } while (opcion != 4);

        }

        public static void PeticionDatos(string ruta)
        {
            Console.Write("Ingresa el número de guía: ");
            int guia = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el nombre del destinatario: ");
            string destinario = Console.ReadLine();

            Console.Write("Ingresa el peso del paquete: ");
            decimal peso = decimal.Parse(Console.ReadLine());

            TipoEnvío tipoEnvio = SeleccionarTipo();

            var paquete = new Paquete();

            paquete.Guia = guia;
            paquete.Destinatario = destinario;
            paquete.Peso = peso;
            paquete.Tipo = tipoEnvio;

            File.AppendAllText(ruta, paquete.ToCSV() + Environment.NewLine);

        }

        public static TipoEnvío SeleccionarTipo()
        {
            Console.WriteLine("Selecciona el tipo de envío del paquete: ");
            Console.WriteLine("1. Nacional");
            Console.WriteLine("2. Internacional");

            int opcionTipoEnvio = int.Parse(Console.ReadLine());

            switch (opcionTipoEnvio)
            {
                case 1:
                    return TipoEnvío.Nacional;

                case 2:
                    return TipoEnvío.Internacional;

                default:
                    Console.WriteLine("Opción no válida. Se asignará Nacional por defecto.");
                    return TipoEnvío.Nacional;
            }
        }

        public static void CalcularPesoTotal(string ruta)
        {
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                decimal pesoTotal = 0;

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');

                    if (datos.Length >= 3)
                    {
                        decimal peso;

                        if (decimal.TryParse(datos[2], out peso))
                        {
                            pesoTotal += peso;
                        }
                    }

                    Console.WriteLine($"El peso total de los paquetes es de: {pesoTotal}");

                }
            }
            else
            {
                Console.WriteLine("El archivo no existe.");
            }
        }

        public static string BuscarPorGuia(string guia, string ruta)
        {
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');

                    if (datos[0] == guia)
                    {
                        return linea;
                    }
                }
            }

            return null;
        }

        private static void ProcesarOpcion(int opcion, string ruta)
        {
            switch (opcion)
            {
                case 1:

                    PeticionDatos(ruta);
                    break;

                case 2:

                    CalcularPesoTotal(ruta);
                    break;

                case 3:

                    Console.Write("Ingrese la guía del paquete a buscar: ");
                    string guiaBuscada = Console.ReadLine();

                    string paquete = BuscarPorGuia(guiaBuscada, ruta);

                    if (paquete != null)
                    {
                        Console.WriteLine("\nPaquete encontrado:");
                        Console.WriteLine(paquete);
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún paquete con esa guía.");
                    }

                    break;

                case 4:
                    Console.WriteLine("Haz decidido salir.");
                    break;
                    
                default:
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    break;
            }
        }
    }
}
