using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reserva_Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblEntrada_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularReserva_Click(object sender, EventArgs e)
        {
            bool esValido = true;

            if (txtCliente.Text == "")
            {
                lblValidacionCliente.Visible = true;
                lblValidacionCliente.Text = "Obligatorio";
                esValido = false;
            }
            else
            {
                lblValidacionCliente.Visible = false;
            }

            if (dtpEntrada.Value.Date < DateTime.Today)
            {
                lblValidacionEntrada.Visible = true;
                lblValidacionEntrada.Text = "La fecha de entrada no puede ser anterior a hoy";
                esValido = false;
            }
            else
            {
                lblValidacionEntrada.Visible = false;
            }

            if (dtpSalida.Value.Date <= dtpEntrada.Value.Date)
            {
                lblValidacionSalida.Visible = true;
                lblValidacionSalida.Text = "La salida debe ser al menos un día después de la entrada";
                esValido = false;
            }
            else
            {
                lblValidacionSalida.Visible = false;
            }

            if (esValido)
            {
                TimeSpan duracion = dtpSalida.Value.Date - dtpEntrada.Value.Date;
                int dias = duracion.Days;

                decimal costoPorNoche = 50;
                decimal costoBase = costoPorNoche * dias;

                int personas = (int)numPersonas.Value;
                decimal costoPersonas = 0;

                if (personas > 1)
                {
                    costoPersonas = (personas - 1) * 15 * dias;
                }

                decimal costoServicios = 0;
                List<string> serviciosSeleccionados = new List<string>();

                foreach (var item in clbServicios.CheckedItems)
                {
                    serviciosSeleccionados.Add(item.ToString());
                    costoServicios += 10 * dias;
                }

                decimal totalAPagar = costoBase + costoPersonas + costoServicios;

                string serviciosTexto;

                if (serviciosSeleccionados.Count > 0)
                {
                    serviciosTexto = string.Join(", ", serviciosSeleccionados);
                }
                else
                {
                    serviciosTexto = "Ninguno";
                }

                rtbResumen.Text =
                    "--- RESUMEN DE RESERVA ---\n" +
                    "Cliente: " + txtCliente.Text + "\n" +
                    "Estancia: " + dias + " noches.\n" +
                    "Personas: " + personas + "\n" +
                    "Servicios: " + serviciosTexto + "\n" +
                    "--------------------------\n" +
                    "TOTAL A PAGAR: $" + totalAPagar;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCliente.Text = "";
            dtpEntrada.Value = DateTime.Today;
            dtpSalida.Value = DateTime.Today.AddDays(1);
            numPersonas.Value = 1;

            // Desmarcar todos los servicios
            for (int i = 0; i < clbServicios.Items.Count; i++)
                clbServicios.SetItemChecked(i, false);

            rtbResumen.Text = "";

            lblValidacionCliente.Visible = false;
            lblValidacionEntrada.Visible = false;
            lblValidacionSalida.Visible = false;
        }
    }
}
