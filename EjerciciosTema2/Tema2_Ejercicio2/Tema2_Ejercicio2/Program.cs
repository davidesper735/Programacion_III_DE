using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Gestión de Inventario de Tienda: 
 * Define una clase Producto con nombre, 
 * precio y stock. 
 * Crea un método que permita "vender" el producto, 
 * restando del stock y mostrando el total de la venta. 
 * Si no hay stock, debe avisar al usuario.
 */

namespace Tema2_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto camiseta = new Producto("Camiseta", 30000, 10);
            Producto pantalon = new Producto("Pantalón", 70000, 5);

            camiseta.Vender(3);
            pantalon.Vender(6);
        }
    }
}
