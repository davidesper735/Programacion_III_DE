using System;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;

namespace ConcesionarioVehiculos.Modelos
{
    public class Motocicleta : Vehiculo, IVendible
    {
        public int Cilindraje { get; set; }
        public bool EsDeportiva { get; set; }

        public Motocicleta(int id, string marca, string modelo, int año, decimal precioBase,
                           TipoCombustible combustible, EstadoVehiculo estado,
                           int cilindraje, bool esDeportiva)
            : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            Cilindraje = cilindraje;
            EsDeportiva = esDeportiva;
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (EsDeportiva ? Cilindraje * 10 : 0);
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.07m; // 7% comisión
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine($"Factura Motocicleta: {Marca} {Modelo}, Precio Final: {CalcularPrecioFinal():C}, Comisión: {CalcularComisionVendedor():C}");
        }
    }
}
