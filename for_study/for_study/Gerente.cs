using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_study
{
    public class Gerente : Empleado
    {
        public double Sueldo { get; set; } = 0;

        public override double CalcularSueldo()
        {
            return Sueldo + (HorasExtras * 20);
        }

        public void M()
        {
            this.Nombre = "";
            this.Clave = "";
        }
    }
}
