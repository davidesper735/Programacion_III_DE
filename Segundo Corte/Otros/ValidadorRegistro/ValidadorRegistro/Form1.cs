using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorRegistro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (txtCorreo.Text == "")
            {
                lblCorreo.Visible = true;
                lblCorreo.Text = "El correo es obligatorio.";
                isValid = false;
            }
            else
            {
                lblCorreo.Visible = false;
                lblCorreo.Text = "";
            }

            if (txtCorreo.Text != txtValidarCorreo.Text)
            {
                lblValidarCorreo.Visible = true;
                lblValidarCorreo.Text = "Los correos no coinciden.";
                isValid = false;
            }
            else
            {
                lblValidarCorreo.Visible = false;
                lblValidarCorreo.Text = "";
            }

            if(txtNombres.Text == "")
            {
                lblNombres.Visible = true;
                lblNombres.Text = "Los nombres son obligatorios.";
                isValid = false;
            }
            else
            {
                lblNombres.Visible = false;
                lblNombres.Text = "";
            }

            if (!rbMasculino.Checked && !rbFemenino.Checked)
            {
                lblGenero.Visible = true;
                lblGenero.Text = "El género es obligatorio.";
                isValid = false;
            }
            else
            {
                lblGenero.Visible = false;
            }

            if (isValid) 
            {
                if (rbMasculino.Checked)
                {
                    lblRegistroExitoso.Visible = true;
                    lblRegistroExitoso.Text = $"Bienvenido Mr.{txtNombres.Text}";
                }
                else
                {
                    lblRegistroExitoso.Visible = true;
                    lblRegistroExitoso.Text = $"Bienvenido Ms.{txtNombres.Text}";
                }
            }
        }
    }
}
