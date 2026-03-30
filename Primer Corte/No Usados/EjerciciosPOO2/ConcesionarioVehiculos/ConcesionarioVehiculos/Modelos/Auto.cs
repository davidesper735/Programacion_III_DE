using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcesionarioVehiculos.Enums;
using ConcesionarioVehiculos.Interfaces;

namespace ConcesionarioVehiculos.Modelos
{
    public class Auto : Vehiculo, IVendible
    {
        public int NumeroPuertas { get; set; }
        public bool TieneAireAcondicionado { get; set; }

        public Auto(int id, string marca, string modelo, int año, decimal precioBase,
                    TipoCombustible combustible, EstadoVehiculo estado,
                    int numeroPuertas, bool tieneAireAcondicionado)
            : base(id, marca, modelo, año, precioBase, combustible, estado)
        {
            NumeroPuertas = numeroPuertas;
            TieneAireAcondicionado = tieneAireAcondicionado;
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (TieneAireAcondicionado ? 2000 : 0);
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.05m; // 5% comisión
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine($"Factura Auto: {Marca} {Modelo}, Precio Final: {CalcularPrecioFinal():C}, Comisión: {CalcularComisionVendedor():C}");
        }
    }
}
