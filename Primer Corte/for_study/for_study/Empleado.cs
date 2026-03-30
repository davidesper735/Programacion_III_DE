using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_study
{
    public abstract class Empleado : Persona
    {
        public double Sueldo { get; set; } = 0;

        public int HorasExtras { get; set; } = 0;

        public abstract double CalcularSueldo();
    }
}
