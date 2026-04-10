using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblResultadoSueldo_Click(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblValidacionIdentificacion_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            bool esValido = true;
            // Campos Obligatorios: Todos los campos de texto deben estar llenos.

            if (txtNombres.Text == "")
            {
                lblValidacionNombres.Visible = true;
                lblValidacionNombres.Text = ("Obligatorio");

                esValido = false;
            }
            else
            {
                lblValidacionNombres.Visible = false;
            }

            if (txtApellidos.Text == "")
            {
                lblValidacionApellidos.Visible = true;
                lblValidacionApellidos.Text = ("Obligatorio");

                esValido = false;
            }
            else
            {
                lblValidacionApellidos.Visible = false;
            }

            if (txtEmail.Text == "")
            {
                lblValidacionEmail.Visible = true;
                lblValidacionEmail.Text = ("Obligatorio");

                esValido = false;
            }

            // Formato de Email: Validar que el texto en txtEmail contenga un @ y un . (usar System.Text.RegularExpressions).

            else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {

                lblValidacionEmail.Visible = true;
                lblValidacionEmail.Text = ("Formato de email inválido");

                esValido = false;
            }
            else
            {
                lblValidacionEmail.Visible = false;
            }

            if (txtIdentificacion.Text == "")
            {
                lblValidacionIdentificacion.Visible = true;
                lblValidacionIdentificacion.Text = ("Obligatorio");

                esValido = false;
            }

            // Identificación: El campo txtIdentificacion debe contener exactamente 10 dígitos numéricos.

            else if (txtIdentificacion.Text.Length != 10)
            {
                lblValidacionIdentificacion.Visible = true;
                lblValidacionIdentificacion.Text = ("La identificación debe tener exactamente 10 dígitos");

                esValido = false;
            }
            else
            {
                lblValidacionIdentificacion.Visible = false;
            }

            if (cmbDepartamento.SelectedIndex < 0) 
            { 
                lblValidacionDepartamento.Visible = true;
                lblValidacionDepartamento.Text = ("Obligatorio");

                esValido = false;
            }
            else
            {
                lblValidacionDepartamento.Visible = false;
            }

            // Lógica de Negocio: Al presionar "Registrar",
            // si los datos son válidos,
            // calcular el Sueldo Neto restando un 10% de retención de impuestos al sueldo base.
            // Mostrar el resultado en un Label con formato de moneda.

            if (esValido)
            {
                decimal sueldoBase = numSueldoBase.Value;
                decimal sueldoNeto = sueldoBase - (sueldoBase * 0.10m);

                lblResultadoSueldo.Text = sueldoNeto.ToString("C");
                lblResultadoSueldo.Visible = true;
            }
    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblValidacionDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblValidacionIdentificacion.Visible = false;
            lblValidacionNombres.Visible = false;
            lblValidacionApellidos.Visible = false;
            lblValidacionEmail.Visible = false;
            lblValidacionDepartamento.Visible = false;
            lblResultadoSueldo.Visible = false;

            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtEmail.Text = "";
            txtIdentificacion.Text = "";
            cmbDepartamento.SelectedIndex = -1;
            numSueldoBase.Value = numSueldoBase.Minimum;
        }
    }
}
