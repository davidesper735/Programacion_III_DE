using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_study
{
    public class Cliente
    {

        public string nombre;
        public string email;
        public string direccion;
        public string telefono;
        private int edad;

        public Cliente()
        {
            this.nombre = "Por defecto";
        }

        public Cliente(string nombre, string email, string direccion, string telefono, int edad)
        {
            this.nombre = nombre;
            this.email = email;
            this.direccion = direccion;
            this.telefono = telefono;
            this.edad = edad;
        }

        public string MostrarInformacion(bool mayusculas, bool mostrarEdad)
        {
            var informacion = ConcatenarInformacion(mostrarEdad);

            if (mayusculas)
            {
                informacion = ConvertirAMayusculas(informacion);

            } else
            {
                informacion = ConvertirAMinusculas(informacion);
            }

            return informacion;
        }

        private string ConcatenarInformacion(bool mostrarEdad)
        {
            var informacion = $"Nombre: {this.nombre}, Email: {this.email}";

            if (mostrarEdad)
            {
                informacion += $", Edad: {this.edad}";
            }

            return informacion;
        }

        private string ConvertirAMinusculas(string texto)
        {
            return texto.ToLower();
        }

        private string ConvertirAMayusculas(string texto)
        {
            return texto.ToUpper();
        }
    }
}