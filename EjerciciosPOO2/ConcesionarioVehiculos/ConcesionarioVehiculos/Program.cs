using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Modelos;
using System;


namespace ConcesionarioVehiculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n🚗 MENÚ CONCESIONARIO DE VEHÍCULOS");
                Console.WriteLine("1. Registrar Auto");
                Console.WriteLine("2. Registrar Motocicleta");
                Console.WriteLine("3. Registrar Camión");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarAuto();
                        break;
                    case "2":
                        RegistrarMotocicleta();
                        break;
                    case "3":
                        RegistrarCamion();
                        break;
                    case "4":
                        salir = true;
                        Console.WriteLine("👋 Gracias por usar el sistema.");
                        break;
                    default:
                        Console.WriteLine("❌ Opción inválida, intente nuevamente.");
                        break;
                }
            }
        }

        static void RegistrarAuto()
        {
            Console.WriteLine("\n--- Registro de Auto ---");
            Console.Write("Marca: "); string marca = Console.ReadLine();
            Console.Write("Modelo: "); string modelo = Console.ReadLine();
            Console.Write("Año: "); int año = int.Parse(Console.ReadLine());
            Console.Write("Precio Base: "); decimal precioBase = decimal.Parse(Console.ReadLine());
            Console.Write("Número de Puertas: "); int puertas = int.Parse(Console.ReadLine());
            Console.Write("¿Tiene Aire Acondicionado? (s/n): "); bool aire = Console.ReadLine().ToLower() == "s";

            var auto = new Auto(1, marca, modelo, año, precioBase, TipoCombustible.Gasolina, EstadoVehiculo.Nuevo, puertas, aire);
            auto.MostrarEspecificaciones();
            auto.GenerarFacturaVenta();
        }

        static void RegistrarMotocicleta()
        {
            Console.WriteLine("\n--- Registro de Motocicleta ---");
            Console.Write("Marca: "); string marca = Console.ReadLine();
            Console.Write("Modelo: "); string modelo = Console.ReadLine();
            Console.Write("Año: "); int año = int.Parse(Console.ReadLine());
            Console.Write("Precio Base: "); decimal precioBase = decimal.Parse(Console.ReadLine());
            Console.Write("Cilindraje: "); int cilindraje = int.Parse(Console.ReadLine());
            Console.Write("¿Es Deportiva? (s/n): "); bool deportiva = Console.ReadLine().ToLower() == "s";

            var moto = new Motocicleta(2, marca, modelo, año, precioBase, TipoCombustible.Gasolina, EstadoVehiculo.Seminuevo, cilindraje, deportiva);
            moto.MostrarEspecificaciones();
            moto.GenerarFacturaVenta();
        }

        static void RegistrarCamion()
        {
            Console.WriteLine("\n--- Registro de Camión ---");
            Console.Write("Marca: "); string marca = Console.ReadLine();
            Console.Write("Modelo: "); string modelo = Console.ReadLine();
            Console.Write("Año: "); int año = int.Parse(Console.ReadLine());
            Console.Write("Precio Base: "); decimal precioBase = decimal.Parse(Console.ReadLine());
            Console.Write("Capacidad de Carga (toneladas): "); decimal carga = decimal.Parse(Console.ReadLine());
            Console.Write("Número de Ejes: "); int ejes = int.Parse(Console.ReadLine());

            var camion = new Camion(3, marca, modelo, año, precioBase, TipoCombustible.Diesel, EstadoVehiculo.Usado, carga, ejes);
            camion.MostrarEspecificaciones();
            camion.GenerarFacturaVenta();
        }
    }
}
