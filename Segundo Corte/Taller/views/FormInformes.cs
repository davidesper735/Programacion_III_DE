using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Taller.views
{
    public partial class FormInformes : Form
    {
        private class Movimiento
        {
            public string Fecha { get; set; }
            public string Tipo { get; set; }
            public string CodigoProducto { get; set; }
            public string NombreProducto { get; set; }
            public int Cantidad { get; set; }
            public int StockActual { get; set; }
        }

        private class ResumenStock
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public int StockInicial { get; set; }
            public int Entradas { get; set; }
            public int Salidas { get; set; }
            public int StockActual { get; set; }
        }

        private List<Movimiento> todosMovimientos = new List<Movimiento>();

        public FormInformes()
        {
            InitializeComponent();

            // dataGridView1 — movimientos
            dataGridView1.AutoGenerateColumns = false;
            Fecha.DataPropertyName = "Fecha";
            Tipo.DataPropertyName = "Tipo";
            Codigo.DataPropertyName = "CodigoProducto";
            Producto.DataPropertyName = "NombreProducto";
            Cantidad.DataPropertyName = "Cantidad";
            Stock.DataPropertyName = "StockActual";

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // dataGridView2 — resumen stock
            dataGridView2.AutoGenerateColumns = false;
            CodigoStockActual.DataPropertyName = "Codigo";
            NombreStockActual.DataPropertyName = "Nombre";
            StockStockActual.DataPropertyName = "StockInicial";
            EntradasStockActual.DataPropertyName = "Entradas";
            SalidasStockActual.DataPropertyName = "Salidas";
            StockActualStockActual.DataPropertyName = "StockActual";

            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // RichTextBox readonly
            rtUnidadesIngresadasInf.ReadOnly = true;
            rtUnidadesDespachadasInf.ReadOnly = true;
            rtProductosStockBajoInf.ReadOnly = true;

            // ComboBox tipo movimiento
            cbTipoMovimientoInf.Items.Add("Todos");
            cbTipoMovimientoInf.Items.Add("Entrada");
            cbTipoMovimientoInf.Items.Add("Salida");
            cbTipoMovimientoInf.SelectedIndex = 0;

            // Eventos
            btnFiltrarInf.Click += btnFiltrarInf_Click;
            btnVerTodoInf.Click += btnVerTodoInf_Click;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView2.CellFormatting += dataGridView2_CellFormatting;

            this.Load += FormInformes_Load;
        }

        private void FormInformes_Load(object sender, EventArgs e)
        {
            CargarComboProductos();
            CargarTodo();
        }

        private void CargarComboProductos()
        {
            cbProductoInf.Items.Clear();
            cbProductoInf.Items.Add("— Todos los productos —");

            var productos = new controllers.Productos().Listar();
            foreach (var p in productos)
                cbProductoInf.Items.Add(p.Codigo.ToString());

            cbProductoInf.SelectedIndex = 0;
        }

        private void CargarTodo()
        {
            todosMovimientos.Clear();

            var ctrlSalidas = new controllers.Salidas();
            var productos = new controllers.Productos().Listar();
            var entradas = new models.Entrada().Listar();
            var salidas = new models.Salida().Listar();

            // Agregar entradas como movimientos
            foreach (var e in entradas)
            {
                todosMovimientos.Add(new Movimiento
                {
                    Fecha = e.Fecha,
                    Tipo = "Entrada",
                    CodigoProducto = e.CodigoProducto,
                    NombreProducto = e.NombreProducto,
                    Cantidad = e.Cantidad,   // cantidad de ESA entrada
                    StockActual = ctrlSalidas.CalcularStock(e.CodigoProducto)
                });
            }

            // Agregar salidas como movimientos
            foreach (var s in salidas)
            {
                todosMovimientos.Add(new Movimiento
                {
                    Fecha = s.Fecha,
                    Tipo = "Salida",
                    CodigoProducto = s.CodigoProducto,
                    NombreProducto = s.NombreProducto,
                    Cantidad = s.Cantidad,   // cantidad de ESA salida
                    StockActual = ctrlSalidas.CalcularStock(s.CodigoProducto)
                });
            }

            // Ordenar por fecha
            todosMovimientos.Sort((a, b) => string.Compare(a.Fecha, b.Fecha));

            // Cargar en dataGridView1
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = todosMovimientos;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
                fila.Height = 28;

            // Construir resumen stock para dataGridView2
            var resumen = new List<ResumenStock>();
            foreach (var p in productos)
            {
                int totalEnt = 0, totalSal = 0;
                string codigo = p.Codigo.ToString();

                foreach (var e in entradas)
                    if (e.CodigoProducto == codigo) totalEnt += e.Cantidad;

                foreach (var s in salidas)
                    if (s.CodigoProducto == codigo) totalSal += s.Cantidad;

                resumen.Add(new ResumenStock
                {
                    Codigo = codigo,
                    Nombre = p.Nombre,
                    StockInicial = p.Stock,
                    Entradas = totalEnt,
                    Salidas = totalSal,
                    StockActual = p.Stock + totalEnt - totalSal
                });
            }

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = resumen;

            foreach (DataGridViewRow fila in dataGridView2.Rows)
                fila.Height = 28;

            // Actualizar tarjetas
            ActualizarTarjetas(entradas, salidas, resumen);
        }

        private void ActualizarTarjetas(
            List<models.Entrada> entradas,
            List<models.Salida> salidas,
            List<ResumenStock> resumen)
        {
            int totalIngresadas = 0;
            int totalDespachadas = 0;
            int productosStockBajo = 0;

            foreach (var e in entradas) totalIngresadas += e.Cantidad;
            foreach (var s in salidas) totalDespachadas += s.Cantidad;
            foreach (var r in resumen) if (r.StockActual <= 5) productosStockBajo++;

            rtUnidadesIngresadasInf.Clear();
            rtUnidadesIngresadasInf.SelectionFont = new Font("Segoe UI", 22, FontStyle.Bold);
            rtUnidadesIngresadasInf.SelectionColor = Color.Green;
            rtUnidadesIngresadasInf.AppendText($"+{totalIngresadas}\n");
            rtUnidadesIngresadasInf.SelectionFont = new Font("Segoe UI", 9, FontStyle.Regular);
            rtUnidadesIngresadasInf.SelectionColor = Color.Gray;
            rtUnidadesIngresadasInf.AppendText("Total unidades ingresadas");

            rtUnidadesDespachadasInf.Clear();
            rtUnidadesDespachadasInf.SelectionFont = new Font("Segoe UI", 22, FontStyle.Bold);
            rtUnidadesDespachadasInf.SelectionColor = Color.Red;
            rtUnidadesDespachadasInf.AppendText($"-{totalDespachadas}\n");
            rtUnidadesDespachadasInf.SelectionFont = new Font("Segoe UI", 9, FontStyle.Regular);
            rtUnidadesDespachadasInf.SelectionColor = Color.Gray;
            rtUnidadesDespachadasInf.AppendText("Total unidades despachadas");

            rtProductosStockBajoInf.Clear();
            rtProductosStockBajoInf.SelectionFont = new Font("Segoe UI", 22, FontStyle.Bold);
            rtProductosStockBajoInf.SelectionColor = Color.Orange;
            rtProductosStockBajoInf.AppendText($"{productosStockBajo}\n");
            rtProductosStockBajoInf.SelectionFont = new Font("Segoe UI", 9, FontStyle.Regular);
            rtProductosStockBajoInf.SelectionColor = Color.Gray;
            rtProductosStockBajoInf.AppendText("Productos con stock bajo");
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            string tipo = fila.Cells["Tipo"].Value?.ToString();

            // Cantidad con + o - según tipo
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int cant))
                {
                    if (tipo == "Entrada")
                    {
                        e.Value = $"+{cant}";
                        e.FormattingApplied = true;
                    }
                    else if (tipo == "Salida")
                    {
                        e.Value = $"-{cant}";
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Entradas con +
            if (dataGridView2.Columns[e.ColumnIndex].Name == "EntradasStockActual")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int val))
                {
                    e.Value = $"+{val}";
                    e.FormattingApplied = true;
                }
            }

            // Salidas con -
            if (dataGridView2.Columns[e.ColumnIndex].Name == "SalidasStockActual")
            {
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int val))
                {
                    e.Value = $"-{val}";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnFiltrarInf_Click(object sender, EventArgs e)
        {
            string filtroCodigo = cbProductoInf.SelectedIndex == 0
                ? null
                : cbProductoInf.SelectedItem.ToString();

            string filtroTipo = cbTipoMovimientoInf.SelectedItem?.ToString() == "Todos"
                ? null
                : cbTipoMovimientoInf.SelectedItem?.ToString();

            var filtrados = todosMovimientos.FindAll(m =>
                (filtroCodigo == null || m.CodigoProducto == filtroCodigo) &&
                (filtroTipo == null || m.Tipo == filtroTipo)
            );

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filtrados;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
                fila.Height = 28;
        }

        private void btnVerTodoInf_Click(object sender, EventArgs e)
        {
            cbProductoInf.SelectedIndex = 0;
            cbTipoMovimientoInf.SelectedIndex = 0;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = todosMovimientos;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
                fila.Height = 28;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}