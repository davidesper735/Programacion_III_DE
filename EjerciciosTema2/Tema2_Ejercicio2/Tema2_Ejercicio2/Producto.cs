using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2_Ejercicio2
{
    public class Producto
    {
        public string nombre;
        public double precio;
        public int stock;
        public Producto() 
        {

        }

        public Producto(string nombre, double precio, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }

        public void Vender(int cantidad)
        {
            if (stock >= cantidad)
            {
                stock -= cantidad;
                double totalVenta = precio * cantidad;

                Console.WriteLine($"Venta realizada: {cantidad} unidades de {nombre}. Total: ${totalVenta}");
            }
            else
            {
                Console.WriteLine($"No hay suficiente stock para vender {cantidad} unidades de {nombre}. Stock disponible: {stock}");
            }
        }
    }
}
