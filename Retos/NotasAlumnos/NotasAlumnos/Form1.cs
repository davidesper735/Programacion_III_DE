using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NotasAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarProcesar_Click(object sender, EventArgs e)
        {
            string ruta = "estudiantes.csv";

            string nombre = txtNombreAlumno.Text;
            string nota = txtNota.Text;

            File.AppendAllText(ruta, $"{nombre},{nota}" + Environment.NewLine);

            if (File.Exists(ruta))
            {
                lstAprobados.Items.Clear();
                lstDesaprobados.Items.Clear();

                string[] lineas = File.ReadAllLines(ruta);

                foreach(string linea in lineas)
                {
                    string[] datos = linea.Split(',');

                    if(datos.Length >= 2)
                    {
                        string nombreAlumno = datos[0];
                        double notaAlumno = double.Parse(datos[1]);

                        if(notaAlumno >= 30 && notaAlumno <= 50)
                        {

                            lstAprobados.Items.Add($"Nombre: {nombreAlumno} Nota: {notaAlumno}");

                        }
                        else
                        {
                            
                            lstDesaprobados.Items.Add($"Nombre: {nombreAlumno} Nota: {notaAlumno}");
                        }
                    }
                }
            }
        }
    }
}
