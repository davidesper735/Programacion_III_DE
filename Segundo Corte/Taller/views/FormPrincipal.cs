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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.ShowDialog();
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            var formEntradas = new FormEntradas();
            formEntradas.ShowDialog();
        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            var formSalidas = new FormSalidas();
            formSalidas.ShowDialog();
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            var formInformes = new FormInformes();
            formInformes.ShowDialog();
        }
    }
}
