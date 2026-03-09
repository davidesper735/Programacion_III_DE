using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;

namespace ConcesionarioVehiculos.Modelos
{
    public class Camion : Vehiculo, IVendible
    {
        public decimal CapacidadCarga { get; set; }
        public int NumeroEjes { get; set; }
        public Camion(string id, string marca, string modelo, int año, double precioBase, EstadoVehiculo estado, TipoCombustible combustible, decimal capacidadCarga, int numeroEjes) : 
            base(id, marca, modelo, año, precioBase, estado, combustible)
        {
            CapacidadCarga = capacidadCarga;
            NumeroEjes = numeroEjes;
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (CapacidadCarga * 500)
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine($"Factura Camión: {Marca} {Modelo}, Precio Final: {CalcularPrecioFinal():C}, Comisión: {CalcularComisionVendedor():C}");
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.10m;
        }
    }
}
