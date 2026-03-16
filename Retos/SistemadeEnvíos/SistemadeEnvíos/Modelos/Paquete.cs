using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemadeEnvíos.Enum;

namespace SistemadeEnvíos.Modelos
{
    public class Paquete
    {
        public int Guia { get; set; }
        public string Destinatario { get; set; }
        public decimal Peso { get; set; }
        public TipoEnvío Tipo { get; set; }

        public string ToCSV() => $"{Guia};{Destinatario};{Peso};{Tipo}";
    }
}
