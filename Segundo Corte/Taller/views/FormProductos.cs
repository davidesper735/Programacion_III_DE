using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller.views
{
    public partial class FormProductos : Form
    {
        private controllers.Productos _controller = new controllers.Productos();
        public static FormProductos Instancia { get; private set; }

        public FormProductos()
        {
            Instancia = this;
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            Codigo.DataPropertyName = "Codigo";
            Nombre.DataPropertyName = "Nombre";
            Categoria.DataPropertyName = "Categoria";
            Precio.DataPropertyName = "Precio";
            Stock.DataPropertyName = "Stock";

            // Codigo no se puede editar (es la llave primaria)
            Codigo.ReadOnly = true;

            // Editar con doble clic directo en la celda
            dataGridView1.EditMode = DataGridViewEditMode.EditOnKeystroke;

            this.Load += Productos_Load;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {

            MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);

            var lista = _controller.Listar();

            // Calcular stock actual de cada producto
            controllers.Salidas ctrlSalidas = new controllers.Salidas();
            foreach (var p in lista)
            {
                int stockActual = ctrlSalidas.CalcularStock(p.Codigo.ToString());
                p.Stock = stockActual >= 0 ? stockActual : p.Stock;
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
                fila.Height = 35;

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            cbCategoria.Text = "";
            nudPrecio.Value = 0;
            nudStock.Value = 0;
        }

        private void btnGuardarProductoProd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            string categoria = cbCategoria.Text;
            int precio = (int)nudPrecio.Value;
            int stock = (int)nudStock.Value;

            string resultado = _controller.Crear(codigo, nombre, categoria, precio, stock);

            if (resultado == "ok")
            {
                MessageBox.Show("Producto guardado correctamente.");
                CargarProductos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }

        private void btnLimpiarCamposProd_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Selecciona un producto de la lista primero.");
                return;
            }

            DataGridViewRow fila = dataGridView1.CurrentRow;

            if (fila.Cells["Codigo"].Value == null) return;

            int codigo = Convert.ToInt32(fila.Cells["Codigo"].Value);

            DialogResult confirm = MessageBox.Show(
                $"¿Seguro que deseas eliminar el producto {codigo}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                string resultado = _controller.Eliminar(codigo);

                if (resultado == "ok")
                {
                    MessageBox.Show("Producto eliminado correctamente.");
                    CargarProductos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(resultado);
                }
            }
        }

        private void btnActualizarProd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Selecciona un producto de la lista primero.");
                return;
            }

            DataGridViewRow fila = dataGridView1.CurrentRow;

            if (fila.Cells["Codigo"].Value == null) return;

            int codigo = Convert.ToInt32(fila.Cells["Codigo"].Value);
            string nombre = fila.Cells["Nombre"].Value?.ToString();
            string categoria = fila.Cells["Categoria"].Value?.ToString();
            int precio = Convert.ToInt32(fila.Cells["Precio"].Value);
            int stock = Convert.ToInt32(fila.Cells["Stock"].Value);

            string resultado = _controller.Actualizar(codigo, nombre, categoria, precio, stock);

            if (resultado == "ok")
            {
                MessageBox.Show("Producto actualizado correctamente.");
                CargarProductos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(resultado);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // vacío — la edición se hace directo en la celda con doble clic
        }

        public void RefrescarProductos()
        {
            CargarProductos();
        }
    }
}