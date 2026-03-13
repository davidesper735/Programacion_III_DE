using BibliotecaDigital.Enums;
using BibliotecaDigital.Interfaces;
using System;

namespace BibliotecaDigital.Modelos
{
    public class Libro : MaterialBiblioteca, IPrestable
    {
        public int NumeroPaginas { get; private set; }
        public string ISBN { get; private set; }

        public Libro(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria, int numeroPaginas, string isbn)
            : base(id, titulo, autor, añoPublicacion, categoria)
        {
            NumeroPaginas = numeroPaginas;
            ISBN = isbn;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Páginas: {NumeroPaginas}, ISBN: {ISBN}");
        }

        public DateTime CalcularFechaDevolucion() 
        { 
            return DateTime.Now.AddDays(15);
        }

        public void GenerarComprobantePrestramo()
        {
            Console.WriteLine($"Préstamo de Libro: {Titulo} | Fecha devolución: {CalcularFechaDevolucion():dd/MM/yyyy}");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 2m;
        }
    }
}