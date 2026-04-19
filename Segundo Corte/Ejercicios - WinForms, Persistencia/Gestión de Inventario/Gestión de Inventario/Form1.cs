using System;
using System.Windows.Forms;
using System.IO;

namespace Gestión_de_Inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string ruta = "productos.csv";

            string nombre = txtNombre.Text;
            string codigoString = txtCodigo.Text;
            string costoString = nudCosto.Text;
            string cantidadString = nudCantidad.Text;

            int codigo = int.Parse(codigoString);
            double costo = double.Parse(costoString);
            int cantidad = int.Parse(cantidadString);

            File.AppendAllText(ruta, $"{nombre},{codigo},{costo},{cantidad}{Environment.NewLine}");

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string ruta = "productos.csv";

            if (File.Exists(ruta)) 
            {
                lstProductos.Items.Clear();

                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');

                    if (datos.Length == 4)
                    {

                        string nombreProducto = datos[0];
                        string codigoProducto = datos[1];
                        string costoProducto = datos[2];
                        string cantidadProducto = datos[3]; 

                        lstProductos.Items.Add($"Nombre: {nombreProducto}, Código: {codigoProducto}, Costo: {costoProducto}, Cantidad: {cantidadProducto}");
                    
                    }
                }
            } else
            {
                MessageBox.Show("Este archivo no existe.");
            }
        }
    }
}
