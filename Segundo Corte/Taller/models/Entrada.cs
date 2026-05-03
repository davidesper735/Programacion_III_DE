using System;
using System.Collections.Generic;
using System.IO;

namespace Taller.models
{
    public class Entrada
    {
        private static readonly string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "db", "entradas.csv");

        public string Fecha { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }

        public Entrada() { }

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

        public List<Entrada> Listar()
        {
            List<Entrada> entradas = new List<Entrada>();

            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);
                foreach (var linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    var datos = linea.Split(',');
                    if (datos.Length == 4)
                    {
                        Entrada entrada = new Entrada();
                        entrada.Fecha = datos[0];
                        entrada.CodigoProducto = datos[1];
                        entrada.Cantidad = int.Parse(datos[2]);
                        entrada.Observacion = datos[3];

                        // Buscar nombre del producto
                        Producto modeloProducto = new Producto();
                        if (int.TryParse(entrada.CodigoProducto, out int cod))
                        {
                            var prod = modeloProducto.Buscar(cod);
                            entrada.NombreProducto = prod != null ? prod.Nombre : "N/A";
                        }
                        else
                        {
                            entrada.NombreProducto = "N/A";
                        }

                        entradas.Add(entrada);
                    }
                }
            }

            return entradas;
        }
    }
}