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
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoCombustible Combustible { get; set; }
        public EstadoVehiculo Estado { get; set; }

        protected Vehiculo(int id, string marca, string modelo, int año, decimal precioBase,
                           TipoCombustible combustible, EstadoVehiculo estado)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Año = año;
            PrecioBase = precioBase;
            Combustible = combustible;
            Estado = estado;
        }

        public virtual void MostrarEspecificaciones()
        {
            Console.WriteLine($"[{Id}] {Marca} {Modelo} - Año: {Año}, Precio Base: {PrecioBase:C}, " +
                              $"Combustible: {Combustible}, Estado: {Estado}");
        }
    }
}