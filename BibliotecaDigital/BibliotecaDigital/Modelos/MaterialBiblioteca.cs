using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDigital.Enums;

namespace BibliotecaDigital.Modelos
{
    public abstract class MaterialBiblioteca
    {
        public int Id { get; protected set; }
        public string Titulo { get; protected set; }
        public string Autor { get; protected set; }
        public int AñoPublicacion { get; protected set; }
        public TipoCategoria Categoria { get; protected set; }

        protected MaterialBiblioteca(int id, string titulo, string autor, int añoPublicacion, TipoCategoria categoria)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Categoria = categoria;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"[{Id}] {Titulo} - {Autor} ({AñoPublicacion}) | Categoría: {Categoria}");
        }
    }
}
