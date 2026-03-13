using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;

namespace ConcesionarioVehiculos.Modelos
{
    public class Camion : Vehiculo, IVendible
    {
        public decimal CapacidadCarga { get; set; }
        public int NumeroEjes { get; set; }

        public Camion(int id, string marca, string modelo, int año, decimal precioBase,
                      TipoCombustible combustible, EstadoVehiculo estado,
                      decimal capacidadCarga, int numeroEjes)
            : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            CapacidadCarga = capacidadCarga;
            NumeroEjes = numeroEjes;
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (CapacidadCarga * 500);
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.1m; // 10% comisión
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine($"Factura Camión: {Marca} {Modelo}, Precio Final: {CalcularPrecioFinal():C}, Comisión: {CalcularComisionVendedor():C}");
        }
    }
}
