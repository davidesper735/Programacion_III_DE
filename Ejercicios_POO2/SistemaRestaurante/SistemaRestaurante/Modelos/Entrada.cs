using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;
using SistemaRestaurante.Interfaces;

namespace SistemaRestaurante.Modelos
{
    public class Entrada : Plato, IPreparable
    {
        public bool EsFria { get; set; }
        public int Porciones { get; set; }
        public Entrada(string id, string nombre, string descripcion, decimal precioBase, TipoComida tipoComida, NivelDificultad dificultad, EstadoOrden estadoOrden, bool esFria, int porciones) : base(id, nombre, descripcion, precioBase, tipoComida, dificultad, estadoOrden)
        {
            EsFria = esFria;
            Porciones = porciones;
        }

        public decimal CalcularCostoTotal()
        {
            return PrecioBase * Porciones;
        }

        public TimeSpan CalcularTiempoPreparacion()
        {
            return EsFria ? TimeSpan.FromMinutes(10) : TimeSpan.FromMinutes(20);
        }

        public override void MostrarInformacionNutricional()
        {
            base.MostrarInformacionNutricional();
            Console.WriteLine($"Es Fría: {(EsFria ? "Sí" : "No")}");
            Console.WriteLine($"Porciones: {Porciones}");
            Console.WriteLine("Tipo de Plato: Entrada");
        }

        public void GenerarOrdenCocina()
        {
            Console.WriteLine($"Orden de Cocina para {Nombre}:");
            Console.WriteLine("Tipo de Plato: Entrada");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Porciones: {Porciones}");
            Console.WriteLine($"Tiempo de Preparación: {CalcularTiempoPreparacion().TotalMinutes} minutos");
            Console.WriteLine($"Costo Total: {CalcularCostoTotal():C}");
            Console.WriteLine($"Estado de Orden: {EstadoOrden}");
            
        }
    }
}
