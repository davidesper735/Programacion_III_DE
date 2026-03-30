using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosTema2.Ejercicio1
{
    public abstract class Mascota
    {
        public string nombre;

        public Mascota()
        {
            this.nombre = "Sin nombre";
        }

        public Mascota(string nombre)
        {
            this.nombre = nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public abstract string HacerTruco();

    }
}
