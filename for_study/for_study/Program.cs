using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Cliente cliente = new Cliente("David", "david@gmail.com", "Calle 13", "3201323123", 21);

            Console.WriteLine(cliente.MostrarInformacion(true, false));
            */

            /*
            var empresa = new Empresa()
            {
                Nombre = "David",
                Email = "david@gmail.com",
                Telefono = "3201323123",
                Direccion = "Calle 13"
            };
            
            Console.WriteLine(empresa.Codigo);
            */

            Vendedor vendedor = new Vendedor();
            vendedor.Sueldo = 100;

            Console.WriteLine(vendedor.MostrarInformacion());
        }
    }
}
