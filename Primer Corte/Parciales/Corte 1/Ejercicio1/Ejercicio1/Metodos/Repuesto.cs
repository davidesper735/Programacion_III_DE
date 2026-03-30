using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio1.Interfaces;

namespace Ejercicio1.Metodos
{
    public class Repuesto : IGestionable
    {
        public string Id { set; get; }

        public string Nombre { set; get; }

        public decimal Precio { set; get;  }

        public void Actualizar()
        {
            throw new NotImplementedException();
        }

        public void Crear()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void Leer()
        {
            throw new NotImplementedException();
        }
    }
}
