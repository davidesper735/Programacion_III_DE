using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
 * Control de Vehículos Eléctricos: 
 * Crea una clase VehiculoElectrico con un nivel de batería. 
 * Implementa un método Viajar(int km) que reste 1% de batería por cada kilómetro. 
 * Si la batería llega a 0, el coche debe avisar que necesita carga inmediata.
 */

namespace Tema2_Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehiculoElectrico carro = new VehiculoElectrico();

            carro.Viajar(100);
        }
    }
}
