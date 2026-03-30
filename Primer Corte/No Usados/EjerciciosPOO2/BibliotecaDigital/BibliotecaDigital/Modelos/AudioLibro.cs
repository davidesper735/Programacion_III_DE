using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;
using System;

namespace BibliotecaDigital.Modelos
{
    public class AudioLibro : MaterialBiblioteca, IPrestable
    {
        public TimeSpan Duracion { get; private set; }
        public string Narrador { get; private set; }

        public AudioLibro(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria, TimeSpan duracion, string narrador)
            : base(id, titulo, autor, añoPublicacion, categoria)
        {
            Duracion = duracion;
            Narrador = narrador;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Duración: {Duracion}, Narrador: {Narrador}");
        }

        public DateTime CalcularFechaDevolucion()
        {
            return DateTime.Now.AddDays(20);
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine($"Préstamo de AudioLibro: {Titulo} | Fecha devolución: {CalcularFechaDevolucion():dd/MM/yyyy}");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso) 
        {
            return diasRetraso * 3m;
        } 
    }
}