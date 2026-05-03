using System;
using System.Collections.Generic;

namespace Taller.controllers
{
    public class Salidas
    {
        public string Crear(string codigoProducto, int cantidad, string observacion)
        {
            if (cantidad <= 0)
                return "La cantidad debe ser mayor a 0.";

            // Calcular stock disponible
            int stockActual = CalcularStock(codigoProducto);

            if (stockActual < 0)
                return "El producto con código " + codigoProducto + " no existe.";

            if (cantidad > stockActual)
                return $"Stock insuficiente. Stock disponible: {stockActual} unidades.";

            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            models.Salida salida = new models.Salida();
            salida.Crear(fecha, codigoProducto, cantidad, observacion);

            return "ok";
        }

        public List<models.Salida> Listar()
        {
            models.Salida salida = new models.Salida();
            return salida.Listar();
        }

        public int CalcularStock(string codigoProducto)
        {
            // Buscar producto
            models.Producto modeloProducto = new models.Producto();
            models.Producto producto = null;

            if (int.TryParse(codigoProducto, out int cod))
                producto = modeloProducto.Buscar(cod);

            if (producto == null) return -1;

            int stockInicial = producto.Stock;

            // Sumar entradas
            int totalEntradas = 0;
            var entradas = new models.Entrada().Listar();
            foreach (var e in entradas)
                if (e.CodigoProducto == codigoProducto)
                    totalEntradas += e.Cantidad;

            // Sumar salidas previas
            int totalSalidas = 0;
            var salidas = new models.Salida().Listar();
            foreach (var s in salidas)
                if (s.CodigoProducto == codigoProducto)
                    totalSalidas += s.Cantidad;

            return stockInicial + totalEntradas - totalSalidas;
        }
    }
}