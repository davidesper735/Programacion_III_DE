using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;
using System;

namespace BibliotecaDigital.Modelos
{
    public class Revista : MaterialBiblioteca, IPrestable
    {
        public int NumeroEdicion { get; private set; }
        public string Periodicidad { get; private set; }

        public Revista(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria, int numeroEdicion, string periodicidad)
            : base(id, titulo, autor, añoPublicacion, categoria)
        {
            NumeroEdicion = numeroEdicion;
            Periodicidad = periodicidad;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Edición: {NumeroEdicion}, Periodicidad: {Periodicidad}");
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(7);
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine($"Préstamo de Revista: {Titulo} | Fecha devolución: {CalcularFechaDevolucion():dd/MM/yyyy}");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 1.5m;
        }
    }
}