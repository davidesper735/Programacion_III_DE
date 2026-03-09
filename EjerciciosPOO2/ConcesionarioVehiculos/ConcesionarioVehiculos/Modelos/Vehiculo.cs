using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;

namespace ConcesionarioVehiculos.Modelos
{
    public abstract class Vehiculo 
    {
        public string Id { get; protected set; }
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }
        public int Año { get; protected set; }
        public decimal PrecioBase { get; protected set; }
        public EstadoVehiculo Estado { get; protected set; }
        public TipoCombustible Combustible { get; protected set; }

        protected Vehiculo(string id, string marca, string modelo, int año, double precioBase, EstadoVehiculo estado, TipoCombustible combustible)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            PrecioBase = precioBase;
            Estado = estado;
            Combustible = combustible;
        }

        public virtual void MostrarEspecificaciones()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Precio Base: {PrecioBase:C}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine($"Combustible: {Combustible}");
        }

    }
}
