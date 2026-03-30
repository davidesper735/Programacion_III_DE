using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRestaurante.Enums;

namespace SistemaRestaurante.Modelos
{
    public abstract class Plato
    {
        // Propiedades: Id, Nombre, Descripcion, PrecioBase, TipoComida, Dificultad
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoComida TipoComida { get; set; }
        public NivelDificultad Dificultad { get; set; }
        public EstadoOrden EstadoOrden { get; set; }
        // Constructor protegido

        protected Plato(string id, string nombre, string descripcion, decimal precioBase, TipoComida tipoComida, NivelDificultad dificultad, EstadoOrden estadoOrden)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioBase = precioBase;
            TipoComida = tipoComida;
            Dificultad = dificultad;
            EstadoOrden = estadoOrden;
        }
        // Método virtual: MostrarInformacionNutricional()

        public virtual void MostrarInformacionNutricional()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Plato: {Nombre}");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Tipo de Comida: {TipoComida}");
            Console.WriteLine($"Dificultad: {Dificultad}");
            Console.WriteLine($"Estado de Orden: {EstadoOrden}");
            Console.WriteLine($"Precio Base: {PrecioBase:C}");
        }
    }
}
