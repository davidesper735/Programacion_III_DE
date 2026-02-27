using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Ejercicios
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public double Precio { get; set; }
        public int CantidadStock { get; set; }

        public void AgregarStock(int cantidad)
        {
            if (cantidad > 0)
            {
                this.CantidadStock += cantidad;

                Console.WriteLine($"Stock agregado exitosamente. Nuevo stock: {this.CantidadStock}");
            }
            else
            {
                Console.WriteLine("La cantidad a agregar debe ser mayor a cero.");
            }
        }

        public void VenderProducto(int cantidad)
        {
            if (cantidad > 0 && cantidad <= this.CantidadStock)
            {
                this.CantidadStock -= cantidad;
                double totalVenta = cantidad * this.Precio;

                Console.WriteLine($"Venta exitosa. Total a pagar: {totalVenta}\nStock restante: {this.CantidadStock}");
            }
            else
            {
                Console.WriteLine("Cantidad inválida o stock insuficiente.");
            }
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Información del Producto:");

            Console.WriteLine(" ");

            Console.WriteLine($"Nombre: {this.Nombre}");
            Console.WriteLine($"Código: {this.Codigo}");
            Console.WriteLine($"Precio: {this.Precio}");
            Console.WriteLine($"Cantidad en Stock: {this.CantidadStock}");
        }
    }

    public static class Ejercicio2
    {
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 2: Gestión de Productos");

            Console.WriteLine(" ");

            Console.WriteLine("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el código del producto: ");
            string codigo = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto: ");
            double precio = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad en stock: ");
            int cantidadStock = int.Parse(Console.ReadLine());

            Console.Clear();

            Producto producto = new Producto { Nombre = nombre, Codigo = codigo, Precio = precio, CantidadStock = cantidadStock };

            producto.MostrarInfo();

            Console.WriteLine(" ");

            Console.WriteLine("¿Desea agregar stock? (S para 'Si' y N para 'No')");
            string respuestaAgregar = Console.ReadLine().ToLower();

            if (respuestaAgregar == "s")
            {
                Console.WriteLine("Ingrese la cantidad a agregar: ");
                int cantidadAgregar = int.Parse(Console.ReadLine());

                producto.AgregarStock(cantidadAgregar);
            }

            Console.WriteLine(" ");

            Console.WriteLine("¿Desea vender el producto? (S para 'Si' y N para 'No')");
            string respuestaVender = Console.ReadLine().ToLower();

            if (respuestaVender == "s")
            {
                Console.WriteLine("Ingrese la cantidad a vender: ");
                int cantidadVender = int.Parse(Console.ReadLine());

                producto.VenderProducto(cantidadVender);
            }
        }
    }
}
