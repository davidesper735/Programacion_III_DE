using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_study
{
    public class Empresa
    {
		public string Codigo { get; } = "123456";
        public string Nombre { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public string Direccion { get; set; } = string.Empty;
		public string Telefono { get; set; } = string.Empty;


        /*
		private string nombre;
		public string Nombre
		{
			get 
			{ 
				return nombre; 
			}

			set 
			{
				if (string.IsNullOrEmpty(value))
				{
					Console.WriteLine("Error, debes enviar el nombre");
				} else
				{
                    nombre = value.ToUpper();
                }
				 
			}
		}
		*/

    }
}
