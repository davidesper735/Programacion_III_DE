using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Taller.views
{
    public partial class FormSalidas : Form
    {
        private controllers.Salidas _controller = new controllers.Salidas();

        public FormSalidas()
        {
            InitializeComponent();

            // Configurar DataGridView
            dgdHistorialdeSalidasSal.AutoGenerateColumns = false;
            Fecha.DataPropertyName = "Fecha";
            Codigo.DataPropertyName = "CodigoProducto";
            Producto.DataPropertyName = "NombreProducto";
            Cantidad.DataPropertyName = "Cantidad";
            Observacion.DataPropertyName = "Observacion";

            dgdHistorialdeSalidasSal.ReadOnly = true;
            dgdHistorialdeSalidasSal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Fecha automática
            txtFechaSal.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFechaSal.Enabled = false;

            // Cantidad mínima
            nudCantidadSal.Minimum = 1;

            // textBox1 es el panel de stock — readonly
            textBox1.ReadOnly = true;

            // Placeholder observación
            txtObservacionSal.GotFocus += (s, e) => {
                if (txtObservacionSal.Text == "Ej: Venta Cliente")
                    txtObservacionSal.Text = "";
            };
            txtObservacionSal.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(txtObservacionSal.Text))
                    txtObservacionSal.Text = "Ej: Venta Cliente";
            };

            // Al cambiar producto mostrar stock
            cbCodigoSal.SelectedIndexChanged += cbCodigoSal_SelectedIndexChanged;

            // Botones
            btnRegistrarSalidaSal.Click += btnRegistrarSalidaSal_Click;
            btnActualizarSal.Click += btnActualizarSal_Click;

            CargarComboProductos();

            this.Load += FormSalidas_Load;
        }

        private void FormSalidas_Load(object sender, EventArgs e)
        {
            CargarSalidas();
        }

        private void CargarComboProductos()
        {
            controllers.Productos ctrl = new controllers.Productos();
            var productos = ctrl.Listar();

            cbCodigoSal.Items.Clear();
            foreach (var p in productos)
                cbCodigoSal.Items.Add(p.Codigo.ToString());

            if (cbCodigoSal.Items.Count > 0)
                cbCodigoSal.SelectedIndex = 0;
        }

        private void CargarSalidas()
        {
            dgdHistorialdeSalidasSal.DataSource = null;
            dgdHistorialdeSalidasSal.DataSource = _controller.Listar();

            foreach (DataGridViewRow fila in dgdHistorialdeSalidasSal.Rows)
                fila.Height = 30;

            dgdHistorialdeSalidasSal.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void cbCodigoSal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCodigoSal.SelectedItem == null) return;

            string codigoStr = cbCodigoSal.SelectedItem.ToString();
            int stockActual = _controller.CalcularStock(codigoStr);

            if (stockActual < 0)
            {
                textBox1.Text = "Producto no encontrado.";
                return;
            }

            // Buscar nombre del producto
            string nombre = "N/A";
            if (int.TryParse(codigoStr, out int cod))
            {
                var prod = new models.Producto().Buscar(cod);
                if (prod != null) nombre = prod.Nombre;
            }

            // Alerta si stock es bajo
            string alerta = stockActual <= 5 ? $"\r\n⚠ {stockActual} unidades disponibles — stock bajo" : "";

            textBox1.Text =
                $"⚠ Stock disponible: {codigoStr} — {nombre}\r\n" +
                $"Stock actual: {stockActual} unidades{alerta}";
        }

        private void LimpiarCampos()
        {
            txtFechaSal.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (cbCodigoSal.Items.Count > 0)
                cbCodigoSal.SelectedIndex = 0;
            nudCantidadSal.Value = 1;
            txtObservacionSal.Text = "Ej: Venta Cliente";
        }

        private void btnRegistrarSalidaSal_Click(object sender, EventArgs e)
        {
            if (cbCodigoSal.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un producto.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = cbCodigoSal.SelectedItem.ToString();
            int cantidad = (int)nudCantidadSal.Value;
            string observacion = txtObservacionSal.Text == "Ej: Venta Cliente" || string.IsNullOrWhiteSpace(txtObservacionSal.Text)
                                 ? "Sin observación"
                                 : txtObservacionSal.Text.Trim();

            string resultado = _controller.Crear(codigo, cantidad, observacion);

            if (resultado == "ok")
            {
                MessageBox.Show("Salida registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSalidas();
                LimpiarCampos();
                cbCodigoSal_SelectedIndexChanged(null, null);

                // ← Refresca FormProductos si está abierto
                if (FormProductos.Instancia != null)
                    FormProductos.Instancia.RefrescarProductos();
            }
            else
            {
                // Si es stock insuficiente muestra warning, si no error normal
                MessageBoxIcon icono = resultado.Contains("Stock")
                    ? MessageBoxIcon.Warning
                    : MessageBoxIcon.Error;

                MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, icono);
            }
        }

        private void btnActualizarSal_Click(object sender, EventArgs e)
        {
            CargarSalidas();
        }
    }
}