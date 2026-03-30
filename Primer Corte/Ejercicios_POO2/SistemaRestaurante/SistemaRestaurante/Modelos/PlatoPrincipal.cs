using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;

namespace SistemaRestaurante.Modelos
{
    public class PlatoPrincipal : Plato, IPreparable
    {
        public string ProteinaPrincipal { get; set; }
        public bool IncluyeGuarnicion { get; set; }
        public PlatoPrincipal(string id, string nombre, string descripcion, decimal precioBase, TipoComida tipoComida, NivelDificultad dificultad, EstadoOrden estadoOrden, string proteinaPrincipal, bool incluyeGuarnicion) : base(id, nombre, descripcion, precioBase, tipoComida, dificultad, estadoOrden)
        {
            ProteinaPrincipal = proteinaPrincipal;
            IncluyeGuarnicion = incluyeGuarnicion;
        }

        public decimal CalcularCostoTotal()
        {
            return PrecioBase + (IncluyeGuarnicion ? 5 : 0);
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            int factor = (int)Dificultad;
            return TimeSpan.FromMinutes(30) + TimeSpan.FromMinutes(15 * factor);

        }

        public override void MostrarInformacionNutricional()
        {
            base.MostrarInformacionNutricional();
            Console.WriteLine($"Proteína Principal: {ProteinaPrincipal}");
            Console.WriteLine($"Incluye Guarnición: {(IncluyeGuarnicion ? "Sí" : "No")}");
            Console.WriteLine("Tipo de Plato: Plato Principal");
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine($"Orden de Cocina para {Nombre}:");
            Console.WriteLine("Tipo de Plato: Plato Principal");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Proteína Principal: {ProteinaPrincipal}");
            Console.WriteLine($"Incluye Guarnición: {(IncluyeGuarnicion ? "Sí" : "No")}");
            Console.WriteLine($"Tiempo de Preparación: {CalcularTiempoPreparacion().TotalMinutes} minutos");
            Console.WriteLine($"Costo Total: {CalcularCostoTotal():C}");
            Console.WriteLine($"Estado de Orden: {EstadoOrden}");
            Console.WriteLine($"Dificultad: {Dificultad}");
            Console.WriteLine($"Tipo de Comida: {TipoComida}");
            Console.WriteLine($"Precio Base: {PrecioBase:C}");
            Console.WriteLine("-----------------------------------");
        }
    }
}
