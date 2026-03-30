using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Ejercicio5
{
    public class VehiculoElectrico
    {
        private double nivelBateria;

        public VehiculoElectrico()
        {
            this.nivelBateria = 100.0;
        }

        public VehiculoElectrico(double nivelBateria)
        {
            this.nivelBateria = nivelBateria;
        }

        public void Viajar(int km)
        {
            double consumo = km;

            if (consumo >= nivelBateria)
            {
                Console.WriteLine($"Batería agotada. Has viajado {km} km");
                nivelBateria = 0;
            }
            else
            {
                nivelBateria -= consumo;
                Console.WriteLine($"Has viajado {km} km. Nivel de batería restante: {nivelBateria}%");
            }

        }
    }
}
