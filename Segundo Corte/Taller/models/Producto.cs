using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Taller.models
{
    public class Producto
    {

        private static readonly string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "productos.csv");
        
        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public String Categoria { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }

        public Producto()
        {

        }

        public void Crear(int codigo, string nombre, string categoria, int precio, int stock)
        {

            Codigo = codigo;
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            Stock = stock;

            String linea = $"{Codigo},{Nombre},{Categoria},{Precio},{Stock}";

            string directorio = Path.GetDirectoryName(ruta);

            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }

            File.AppendAllText(ruta, linea + Environment.NewLine);

        }

        public List<Producto> Listar()
        {
            List<Producto> productos = new List<Producto>();

            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);

                foreach(var linea in lineas)
                {
                    var datos = linea.Split(',');

                    if(datos.Length == 5)
                    {
                        int codigo = int.Parse(datos[0]);
                        String nombre = datos[1];
                        String categoria = datos[2];
                        int precio = int.Parse(datos[3]);
                        int stock = int.Parse(datos[4]);

                        Producto producto = new Producto();

                        producto.Codigo = codigo;
                        producto.Nombre = nombre;
                        producto.Categoria = categoria;
                        producto.Precio = precio;
                        producto.Stock = stock;

                        productos.Add(producto);
                    }
                }
            }

            return productos;

        }

        public void Eliminar(int codigo)
        {
            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);
                var lineasActualizadas = lineas.Where(linea => !linea.StartsWith(codigo.ToString())).ToArray();
                
                File.WriteAllLines(ruta, lineasActualizadas);
            }
        }

        public void Actualizar(int codigo, string nombre, string categoria, int precio, int stock)
        {
            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);

                for (int i = 0; i < lineas.Length; i++)
                {
                    var datos = lineas[i].Split(',');

                    if (datos.Length == 5 && int.Parse(datos[0]) == codigo)
                    {
                        lineas[i] = $"{codigo},{nombre},{categoria},{precio},{stock}";
                        break;
                    }
                }

                File.WriteAllLines(ruta, lineas);
            }
        }

        public Producto Buscar(int codigo)
        {
            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);
                foreach (var linea in lineas)
                {
                    var datos = linea.Split(',');

                    if (datos.Length == 5 && int.Parse(datos[0]) == codigo)
                    {
                        String nombre = datos[1];
                        String categoria = datos[2];
                        int precio = int.Parse(datos[3]);
                        int stock = int.Parse(datos[4]);
                    
                        Producto producto = new Producto();

                        producto.Codigo = codigo;
                        producto.Nombre = nombre;
                        producto.Categoria = categoria;
                        producto.Precio = precio;
                        producto.Stock = stock;

                        return producto;
                    }
                }
            }
            return null;
        }
    }
}