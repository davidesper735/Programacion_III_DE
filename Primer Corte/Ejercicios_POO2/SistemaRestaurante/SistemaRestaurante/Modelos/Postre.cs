using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;

namespace SistemaRestaurante.Modelos
{
    public class Postre : Plato, IPreparable
    {
        public bool ContieneLactosa { get; set; }
        public int CaloriasPorPorcion { get; set; }
        public Postre(string id, string nombre, string descripcion, decimal precioBase, TipoComida tipoComida, NivelDificultad dificultad, EstadoOrden estadoOrden, bool contieneLactosa, int caloriasPorPorcion) : base(id, nombre, descripcion, precioBase, tipoComida, dificultad, estadoOrden)
        {
            ContieneLactosa = contieneLactosa;
            CaloriasPorPorcion = caloriasPorPorcion;
        }

        public decimal CalcularCostoTotal()
        {
            return PrecioBase + (ContieneLactosa ? 2 : 0);
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            return TimeSpan.FromMinutes(25) + (ContieneLactosa ? TimeSpan.FromMinutes(5) : TimeSpan.Zero);
        }

        public override void MostrarInformacionNutricional()
        {
            base.MostrarInformacionNutricional();
            Console.WriteLine($"Contiene Lactosa: {(ContieneLactosa ? "Sí" : "No")}");
            Console.WriteLine($"Calorías por Porción: {CaloriasPorPorcion}");
            Console.WriteLine("Tipo de Plato: Postre");
        }
        public void GenerarOrdenCocina()
        {
            Console.WriteLine("Orden de Cocina para Postre:");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Contiene Lactosa: {(ContieneLactosa ? "Sí" : "No")}");
            Console.WriteLine($"Calorías por Porción: {CaloriasPorPorcion}");
            Console.WriteLine($"Tiempo de Preparación: {CalcularTiempoPreparacion().TotalMinutes} minutos");
            Console.WriteLine($"Costo Total: {CalcularCostoTotal():C}");
            Console.WriteLine($"Estado de Orden: {EstadoOrden}");
            Console.WriteLine($"Tipo de Comida: {TipoComida}");
            Console.WriteLine("-----------------------------------");
        }
    }
}
