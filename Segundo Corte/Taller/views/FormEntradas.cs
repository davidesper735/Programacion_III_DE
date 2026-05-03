using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Taller.views
{
    public partial class FormEntradas : Form
    {
        private controllers.Entradas _controller = new controllers.Entradas();

        public FormEntradas()
        {
            InitializeComponent();

            datagridEntradasEnt.AutoGenerateColumns = false;
            Fecha.DataPropertyName = "Fecha";
            Codigo.DataPropertyName = "CodigoProducto";
            Producto.DataPropertyName = "NombreProducto";
            Cantidad.DataPropertyName = "Cantidad";
            Observacion.DataPropertyName = "Observacion";

            datagridEntradasEnt.ReadOnly = true;
            datagridEntradasEnt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridEntradasEnt.EditMode = DataGridViewEditMode.EditOnKeystroke;

            txtFechaEnt.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtFechaEnt.Enabled = false;

            nudCantidadEnt.Minimum = 1;
            txtStockActualEnt.ReadOnly = true;

            btnRegistrarEntradaEnt.Click += btnRegistrarEntradaEnt_Click;

            // ← Primero suscribe el evento, luego carga el combo
            cbCodigoEnt.SelectedIndexChanged += cbCodigoEnt_SelectedIndexChanged;
            CargarComboProductos(); // ahora sí dispara el evento al cargar el primer item

            this.Load += FormEntradas_Load;
        }

        private void FormEntradas_Load(object sender, EventArgs e)
        {
            CargarEntradas();
        }

        private void CargarComboProductos()
        {
            controllers.Productos ctrl = new controllers.Productos();
            var productos = ctrl.Listar();

            cbCodigoEnt.Items.Clear();
            foreach (var p in productos)
                cbCodigoEnt.Items.Add(p.Codigo.ToString());

            if (cbCodigoEnt.Items.Count > 0)
                cbCodigoEnt.SelectedIndex = 0;
        }

        private void CargarEntradas()
        {
            datagridEntradasEnt.DataSource = null;
            datagridEntradasEnt.DataSource = _controller.Listar();

            foreach (DataGridViewRow fila in datagridEntradasEnt.Rows)
                fila.Height = 30;

            datagridEntradasEnt.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void cbCodigoEnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCodigoEnt.SelectedItem == null) return;

            string codigoStr = cbCodigoEnt.SelectedItem.ToString();

            if (!int.TryParse(codigoStr, out int codigo)) return;

            // Buscar producto
            models.Producto modelo = new models.Producto();
            var producto = modelo.Buscar(codigo);

            if (producto == null)
            {
                txtStockActualEnt.Text = "Producto no encontrado";
                return;
            }

            // Calcular stock: StockInicial + Entradas - Salidas
            int stockInicial = producto.Stock;

            int totalEntradas = 0;
            var entradas = new models.Entrada().Listar();
            foreach (var ent in entradas)
                if (ent.CodigoProducto == codigoStr)
                    totalEntradas += ent.Cantidad;

            int totalSalidas = 0;
            var salidas = new models.Salida().Listar();
            foreach (var sal in salidas)
                if (sal.CodigoProducto == codigoStr)
                    totalSalidas += sal.Cantidad;

            int stockActual = stockInicial + totalEntradas - totalSalidas;

            txtStockActualEnt.Text =
                $"Producto : {producto.Nombre}\r\n" +
                $"Stock inicial : {stockInicial}\r\n" +
                $"Stock actual  : {stockActual}";
        }

        private void LimpiarCampos()
        {
            txtFechaEnt.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (cbCodigoEnt.Items.Count > 0)
                cbCodigoEnt.SelectedIndex = 0;
            nudCantidadEnt.Value = 1;
            txtObservacionEnt.Text = "";
        }

        private void btnRegistrarEntradaEnt_Click(object sender, EventArgs e)
        {
            if (cbCodigoEnt.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un producto.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = cbCodigoEnt.SelectedItem.ToString();
            int cantidad = (int)nudCantidadEnt.Value;
            string observacion = string.IsNullOrWhiteSpace(txtObservacionEnt.Text)
                                 ? "Sin observación"
                                 : txtObservacionEnt.Text.Trim();

            string resultado = _controller.Crear(codigo, cantidad, observacion);

            if (resultado == "ok")
            {
                MessageBox.Show("Entrada registrada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEntradas();
                LimpiarCampos();
                cbCodigoEnt_SelectedIndexChanged(null, null);

                // ← Refresca FormProductos si está abierto
                if (FormProductos.Instancia != null)
                    FormProductos.Instancia.RefrescarProductos();
            }
            else
            {
                MessageBox.Show(resultado, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cbCodigoEnt_SelectedIndexChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarEntradas();
        }

        private void datagridEntradasEnt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // vacío por ahora
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // vacío
        }
    }
}