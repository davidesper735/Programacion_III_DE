using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_Productos
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        // Lógica de Interfaz: El dtpFechaVencimiento solo debe habilitarse(Enabled = true) si el chkEsPerecedero está marcado.
        private void chkEsPerecedero_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Enabled = chkEsPerecedero.Checked;
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool esValido = true;

            // Código de Producto: Validar que el código comience con el prefijo "PROD-".
            if (txtCodigo.Text == "")
            {
                lblValidacionCodigo.Visible = true;
                lblValidacionCodigo.Text = "Obligatorio";
                esValido = false;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtCodigo.Text, @"^PROD-\d{4}$"))
            {
                lblValidacionCodigo.Visible = true;
                lblValidacionCodigo.Text = "Formato inválido. Ejemplo: PROD-1234";
                esValido = false;
            }
            else
            {
                lblValidacionCodigo.Visible = false;
            }

            if (txtNombreProducto.Text == "")
            {
                lblValidacionNombre.Visible = true;
                lblValidacionNombre.Text = "Obligatorio";
                esValido = false;
            }
            else
            {
                lblValidacionNombre.Visible = false;
            }

            if (cmbCategoria.SelectedIndex < 0)
            {
                lblValidacionCategoria.Visible = true;
                lblValidacionCategoria.Text = "Obligatorio";
                esValido = false;
            }
            else
            {
                lblValidacionCategoria.Visible = false;
            }

            // Validación Cruzada: El numStockInicial no puede ser menor al numStockMinimo.

            if (numStockInicial.Value < numStockMinimo.Value)
            {
                lblValidacionStock.Visible = true;
                lblValidacionStock.Text = "El stock inicial no puede ser menor al stock mínimo";
                esValido = false;
            }
            else
            {
                lblValidacionStock.Visible = false;
            }

            // Selección de IVA: Asegurarse de que al menos un RadioButton de IVA esté seleccionado antes de procesar.
            if (!rbExento.Checked && !rbGeneral.Checked && !rbReducido.Checked)
            {
                lblValidacionIVA.Visible = true;
                lblValidacionIVA.Text = "Seleccione un tipo de IVA";
                esValido = false;
            }
            else
            {
                lblValidacionIVA.Visible = false;
            }

            if (esValido)
            {
                decimal iva = 0;
                if (rbGeneral.Checked) iva = 0.19m;
                if (rbReducido.Checked) iva = 0.05m;

                MessageBox.Show("Producto registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombreProducto.Text = "";
            cmbCategoria.SelectedIndex = -1;
            numStockInicial.Value = numStockInicial.Minimum;
            numStockMinimo.Value = numStockMinimo.Minimum;
            rbExento.Checked = false;
            rbGeneral.Checked = false;
            rbReducido.Checked = false;
            chkEsPerecedero.Checked = false;
            dtpFechaVencimiento.Enabled = false;

            lblValidacionCodigo.Visible = false;
            lblValidacionNombre.Visible = false;
            lblValidacionCategoria.Visible = false;
            lblValidacionStock.Visible = false;
            lblValidacionIVA.Visible = false;
        }
    }
}
