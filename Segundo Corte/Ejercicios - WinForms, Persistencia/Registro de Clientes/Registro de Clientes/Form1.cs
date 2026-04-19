using System;
using System.Windows.Forms;
using System.IO;

namespace Registro_de_Clientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            string ruta = "clientes.csv";

            string dni = txtDNI.Text;
            string ciudad = txtCiudad.Text;
            string nombre = txtNombre.Text;

            if (dni == "" || nombre == "")
            {
                MessageBox.Show("El DNI y el nombre son campos obligatorios.");
                return;

            } else if (!int.TryParse(dni, out _))
            {
                MessageBox.Show("El DNI debe ser un número válido.");
                return;

            } else if(ciudad == "")
            {
                ciudad = "No especificado";
            }

            File.AppendAllText(ruta, $"{dni},{ciudad}, {nombre}" + Environment.NewLine);

            MessageBox.Show("Cliente registrado exitosamente.");

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

            string ruta = "clientes.csv";

            if (File.Exists(ruta))
            {
                lstClientes.Items.Clear();

                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');

                    int dniCliente = int.Parse(datos[0]);
                    string ciudadCliente = datos[1].Trim();
                    string nombreCliente = datos[2].Trim();

                    lstClientes.Items.Add($"DNI: {dniCliente}, Ciudad: {ciudadCliente}, Nombre: {nombreCliente}");
                }
            }
            else
            {
                MessageBox.Show("El archivo no existe.");
            }
        }
    }
}