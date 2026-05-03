using System;
using System.Collections.Generic;
using System.IO;

namespace Taller.models
{
    public class Salida
    {
        private static readonly string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "salidas.csv");

        public string Fecha { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }

        public Salida() { }

        public void Crear(string fecha, string codigoProducto, int cantidad, string observacion)
        {
            Fecha = fecha;
            CodigoProducto = codigoProducto;
            Cantidad = cantidad;
            Observacion = observacion;

            string linea = $"{Fecha},{CodigoProducto},{Cantidad},{Observacion}";
            string directorio = Path.GetDirectoryName(ruta);

            if (!Directory.Exists(directorio))
                Directory.CreateDirectory(directorio);

            File.AppendAllText(ruta, linea + Environment.NewLine);
        }

        public List<Salida> Listar()
        {
            List<Salida> salidas = new List<Salida>();

            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);
                foreach (var linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    var datos = linea.Split(',');
                    if (datos.Length == 4)
                    {
                        Salida salida = new Salida();
                        salida.Fecha = datos[0];
                        salida.CodigoProducto = datos[1];
                        salida.Cantidad = int.Parse(datos[2]);
                        salida.Observacion = datos[3];

                        // Buscar nombre del producto
                        Producto modeloProducto = new Producto();
                        if (int.TryParse(salida.CodigoProducto, out int cod))
                        {
                            var prod = modeloProducto.Buscar(cod);
                            salida.NombreProducto = prod != null ? prod.Nombre : "N/A";
                        }
                        else
                        {
                            salida.NombreProducto = "N/A";
                        }

                        salidas.Add(salida);
                    }
                }
            }

            return salidas;
        }
    }
}