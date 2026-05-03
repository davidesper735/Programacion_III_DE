using System;
using System.Collections.Generic;

namespace Taller.controllers
{
    public class Entradas
    {
        public string Crear(string codigoProducto, int cantidad, string observacion)
        {
            if (cantidad <= 0)
                return "La cantidad debe ser mayor a 0.";

            // Verificar que el producto existe
            if (!int.TryParse(codigoProducto, out int cod))
                return "El código del producto no es válido.";

            models.Producto modelo = new models.Producto();
            models.Producto producto = modelo.Buscar(cod);

            if (producto == null)
                return "El producto con código " + codigoProducto + " no existe.";

            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            models.Entrada entrada = new models.Entrada();
            entrada.Crear(fecha, codigoProducto, cantidad, observacion);

            return "ok";
        }

        public List<models.Entrada> Listar()
        {
            models.Entrada entrada = new models.Entrada();
            return entrada.Listar();
        }
    }
}