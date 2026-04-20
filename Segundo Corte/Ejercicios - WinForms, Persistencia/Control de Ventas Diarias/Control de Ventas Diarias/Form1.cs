using System;
using System.Windows.Forms;
using System.IO;

namespace Control_de_Ventas_Diarias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardarTransaccion_Click(object sender, EventArgs e)
        {
            string ruta = "ventas.csv";

            string idString = txtID.Text;
            string monto = nudMonto.Text;

            if(!double.TryParse(monto, out _))
            {
                MessageBox.Show("El Monto deben ser número válidos.");

            } else if(idString == "")
            {
                MessageBox.Show("El ID de Transacción no puede estar vacío.");
            }

            File.AppendAllText(ruta, $"{idString},{monto}" + Environment.NewLine);

            MessageBox.Show("Transacción guardada exitosamente.");
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            string ruta = "ventas.csv";

            if (File.Exists(ruta))
            {
                lstHistorial.Items.Clear();

                string[] lineas = File.ReadAllLines(ruta);

                double total = 0;

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');

                    if (datos.Length == 2)
                    {
                        string id = datos[0];
                        double montoTransaccion = double.Parse(datos[1]);
                        lstHistorial.Items.Add($"ID: {id} - Monto: {montoTransaccion}");

                        total += montoTransaccion;
                    }
                }

                lblTotalPre.Text = total.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Este archivo no existe.");
            }
        }
    }
}
