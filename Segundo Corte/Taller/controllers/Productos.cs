using System;
using System.Collections.Generic;

namespace Taller.controllers
{
    public class Productos
    {
        public String Crear(int codigo, string nombre, string categoria, int precio, int stock)
        {
            models.Producto producto = new models.Producto();

            if (producto.Buscar(codigo) != null)
            {
                return "El producto con el id " + codigo + " ya existe.";
            }

            producto.Crear(codigo, nombre, categoria, precio, stock);

            return "ok";
        }

        public List<models.Producto> Listar()
        {
            models.Producto producto = new models.Producto();
            return producto.Listar();
        }

        public String Eliminar(int codigo)
        {
            models.Producto producto = new models.Producto();

            if (producto.Buscar(codigo) == null)
            {
                return "El producto con el id " + codigo + " no existe.";
            }
            producto.Eliminar(codigo);

            return "ok";
        }

        public String Actualizar(int codigo, string nombre, string categoria, int precio, int stock)
        {
            models.Producto producto = new models.Producto();

            if (producto.Buscar(codigo) == null)
            {
                return "El producto con el id " + codigo + " no existe.";
            }

            producto.Actualizar(codigo, nombre, categoria, precio, stock);

            return "ok";
        }
    }
}