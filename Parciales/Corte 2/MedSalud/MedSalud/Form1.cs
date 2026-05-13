using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MedSalud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string ruta = "pacientes.csv";

            int totalPacientes = dataGridView1.Rows.Count;
            

            string nuevoID = "PAC-" + (totalPacientes + 1).ToString("D3");


            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string documento = txtDocumento.Text;
            string nacimiento = dateNacimiento.Text;
            string genero = lstGenero.Text;
            string eps = lstEPS.Text;
            string telefono = txtTelefono.Text;
            string motivo = txtMotivo.Text;

            
            if (nombre == "" || apellido == "")
            {
                MessageBox.Show("Nombre y Apellido son obligatorios.");
                return;
            }

           
            string linea = $"{nuevoID},{nombre},{apellido},{documento},{nacimiento},{genero},{eps},{telefono},{motivo}";
            File.AppendAllText(ruta, linea + Environment.NewLine);

            dataGridView1.Rows.Add(nuevoID, nombre, apellido, documento, nacimiento, genero, eps, telefono, motivo);

            txtID.Text = "PAC-" + (dataGridView1.Rows.Count).ToString("D3");
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtNombre.Focus();

            MessageBox.Show("Paciente registrado con el código: " + nuevoID);
        }

        private void LimpiarFormulario()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtMotivo.Clear();
            dateNacimiento.Value = DateTime.Now;
            txtID.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Selecciona un paciente de la lista primero.");
                return;
            }

            DataGridViewRow fila = dataGridView1.CurrentRow;

            fila.Cells["ID"].Value = txtID.Text;
            fila.Cells["Nombre"].Value = txtNombre.Text;
            fila.Cells["Apellido"].Value = txtApellido.Text;
            fila.Cells["Documento"].Value = txtDocumento.Text;
            fila.Cells["Nacimiento"].Value = dateNacimiento.Text;
            fila.Cells["Genero"].Value = lstGenero.Text;
            fila.Cells["EPS"].Value = lstEPS.Text;
            fila.Cells["Telefono"].Value = txtTelefono.Text;
            fila.Cells["Motivo"].Value = txtMotivo.Text;

            ActualizarArchivoCSV();

            MessageBox.Show("Datos actualizados correctamente.");
        }

        private void ActualizarArchivoCSV()
        {
            string ruta = "pacientes.csv";
            List<string> lineas = new List<string>();

            foreach (DataGridViewRow filaGrid in dataGridView1.Rows)
            {
                if (!filaGrid.IsNewRow)
                {
                    string id = filaGrid.Cells["ID"].Value?.ToString();
                    string nombre = filaGrid.Cells["Nombre"].Value?.ToString();
                    string apellido = filaGrid.Cells["Apellido"].Value?.ToString();
                    string documento = filaGrid.Cells["Documento"].Value?.ToString();
                    string nacimiento = filaGrid.Cells["Nacimiento"].Value?.ToString();
                    string genero = filaGrid.Cells["Genero"].Value?.ToString();
                    string eps = filaGrid.Cells["EPS"].Value?.ToString();
                    string telefono = filaGrid.Cells["Telefono"].Value?.ToString();
                    string motivo = filaGrid.Cells["Motivo"].Value?.ToString();

                    lineas.Add($"{id},{nombre},{apellido},{documento},{nacimiento},{genero},{eps},{telefono},{motivo}");
                }
            }

            File.WriteAllLines(ruta, lineas);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Por favor, seleccione una fila válida para eliminar.");
                return;
            }

            
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar a este paciente?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                
                string ruta = "pacientes.csv";
                string nuevoContenido = "";

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        nuevoContenido += $"{fila.Cells["ID"].Value},{fila.Cells["Nombre"].Value},{fila.Cells["Apellido"].Value},{fila.Cells["Documento"].Value},{fila.Cells["Nacimiento"].Value}" + Environment.NewLine;
                    }
                }

                File.WriteAllText(ruta, nuevoContenido);

                MessageBox.Show("Paciente eliminado con éxito.");
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string ruta = "pacientes.csv";

            if (!File.Exists(ruta)) return;

            string[] lineas = File.ReadAllLines(ruta);

            foreach (string linea in lineas)
            {

                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] datos = linea.Split(',');

                dataGridView1.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
            }
        }
    }
}