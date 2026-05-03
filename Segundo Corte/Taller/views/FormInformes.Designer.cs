namespace Taller.views
{
    partial class FormInformes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbStockActualPorProductoInf = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CodigoStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntradasStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalidasStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockActualStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerTodoInf = new System.Windows.Forms.Button();
            this.btnFiltrarInf = new System.Windows.Forms.Button();
            this.lblTipoMovimientoInf = new System.Windows.Forms.Label();
            this.cbTipoMovimientoInf = new System.Windows.Forms.ComboBox();
            this.lblProductoInf = new System.Windows.Forms.Label();
            this.cbProductoInf = new System.Windows.Forms.ComboBox();
            this.rtProductosStockBajoInf = new System.Windows.Forms.RichTextBox();
            this.rtUnidadesDespachadasInf = new System.Windows.Forms.RichTextBox();
            this.rtUnidadesIngresadasInf = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbStockActualPorProductoInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbStockActualPorProductoInf);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.rtProductosStockBajoInf);
            this.splitContainer1.Panel2.Controls.Add(this.rtUnidadesDespachadasInf);
            this.splitContainer1.Panel2.Controls.Add(this.rtUnidadesIngresadasInf);
            this.splitContainer1.Size = new System.Drawing.Size(800, 593);
            this.splitContainer1.SplitterDistance = 127;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbStockActualPorProductoInf
            // 
            this.gbStockActualPorProductoInf.Controls.Add(this.dataGridView2);
            this.gbStockActualPorProductoInf.Location = new System.Drawing.Point(13, 279);
            this.gbStockActualPorProductoInf.Name = "gbStockActualPorProductoInf";
            this.gbStockActualPorProductoInf.Size = new System.Drawing.Size(775, 170);
            this.gbStockActualPorProductoInf.TabIndex = 5;
            this.gbStockActualPorProductoInf.TabStop = false;
            this.gbStockActualPorProductoInf.Text = "Stock actual por producto";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoStockActual,
            this.NombreStockActual,
            this.StockStockActual,
            this.EntradasStockActual,
            this.SalidasStockActual,
            this.StockActualStockActual});
            this.dataGridView2.Location = new System.Drawing.Point(7, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(762, 144);
            this.dataGridView2.TabIndex = 0;
            // 
            // CodigoStockActual
            // 
            this.CodigoStockActual.HeaderText = "Código";
            this.CodigoStockActual.Name = "CodigoStockActual";
            // 
            // NombreStockActual
            // 
            this.NombreStockActual.HeaderText = "Nombre";
            this.NombreStockActual.Name = "NombreStockActual";
            // 
            // StockStockActual
            // 
            this.StockStockActual.HeaderText = "Stock Ini.";
            this.StockStockActual.Name = "StockStockActual";
            // 
            // EntradasStockActual
            // 
            this.EntradasStockActual.HeaderText = "+ Entradas";
            this.EntradasStockActual.Name = "EntradasStockActual";
            // 
            // SalidasStockActual
            // 
            this.SalidasStockActual.HeaderText = "- Salidas";
            this.SalidasStockActual.Name = "SalidasStockActual";
            // 
            // StockActualStockActual
            // 
            this.StockActualStockActual.HeaderText = "Stock Actual";
            this.StockActualStockActual.Name = "StockActualStockActual";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Tipo,
            this.Codigo,
            this.Producto,
            this.Cantidad,
            this.Stock});
            this.dataGridView1.Location = new System.Drawing.Point(13, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 109);
            this.dataGridView1.TabIndex = 4;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVerTodoInf);
            this.panel1.Controls.Add(this.btnFiltrarInf);
            this.panel1.Controls.Add(this.lblTipoMovimientoInf);
            this.panel1.Controls.Add(this.cbTipoMovimientoInf);
            this.panel1.Controls.Add(this.lblProductoInf);
            this.panel1.Controls.Add(this.cbProductoInf);
            this.panel1.Location = new System.Drawing.Point(13, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 61);
            this.panel1.TabIndex = 3;
            // 
            // btnVerTodoInf
            // 
            this.btnVerTodoInf.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVerTodoInf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerTodoInf.Location = new System.Drawing.Point(511, 12);
            this.btnVerTodoInf.Name = "btnVerTodoInf";
            this.btnVerTodoInf.Size = new System.Drawing.Size(93, 36);
            this.btnVerTodoInf.TabIndex = 5;
            this.btnVerTodoInf.Text = "Ver Todo";
            this.btnVerTodoInf.UseVisualStyleBackColor = true;
            this.btnVerTodoInf.Click += new System.EventHandler(this.btnVerTodoInf_Click);
            // 
            // btnFiltrarInf
            // 
            this.btnFiltrarInf.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltrarInf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrarInf.Location = new System.Drawing.Point(403, 12);
            this.btnFiltrarInf.Name = "btnFiltrarInf";
            this.btnFiltrarInf.Size = new System.Drawing.Size(102, 36);
            this.btnFiltrarInf.TabIndex = 4;
            this.btnFiltrarInf.Text = "Filtrar";
            this.btnFiltrarInf.UseVisualStyleBackColor = false;
            this.btnFiltrarInf.Click += new System.EventHandler(this.btnFiltrarInf_Click);
            // 
            // lblTipoMovimientoInf
            // 
            this.lblTipoMovimientoInf.AutoSize = true;
            this.lblTipoMovimientoInf.Location = new System.Drawing.Point(238, 11);
            this.lblTipoMovimientoInf.Name = "lblTipoMovimientoInf";
            this.lblTipoMovimientoInf.Size = new System.Drawing.Size(109, 13);
            this.lblTipoMovimientoInf.TabIndex = 3;
            this.lblTipoMovimientoInf.Text = "Tipo de Moviemiento:";
            // 
            // cbTipoMovimientoInf
            // 
            this.cbTipoMovimientoInf.FormattingEnabled = true;
            this.cbTipoMovimientoInf.Location = new System.Drawing.Point(241, 27);
            this.cbTipoMovimientoInf.Name = "cbTipoMovimientoInf";
            this.cbTipoMovimientoInf.Size = new System.Drawing.Size(136, 21);
            this.cbTipoMovimientoInf.TabIndex = 2;
            // 
            // lblProductoInf
            // 
            this.lblProductoInf.AutoSize = true;
            this.lblProductoInf.Location = new System.Drawing.Point(14, 8);
            this.lblProductoInf.Name = "lblProductoInf";
            this.lblProductoInf.Size = new System.Drawing.Size(53, 13);
            this.lblProductoInf.TabIndex = 1;
            this.lblProductoInf.Text = "Producto:";
            // 
            // cbProductoInf
            // 
            this.cbProductoInf.FormattingEnabled = true;
            this.cbProductoInf.Location = new System.Drawing.Point(14, 27);
            this.cbProductoInf.Name = "cbProductoInf";
            this.cbProductoInf.Size = new System.Drawing.Size(209, 21);
            this.cbProductoInf.TabIndex = 0;
            // 
            // rtProductosStockBajoInf
            // 
            this.rtProductosStockBajoInf.Location = new System.Drawing.Point(540, 24);
            this.rtProductosStockBajoInf.Name = "rtProductosStockBajoInf";
            this.rtProductosStockBajoInf.Size = new System.Drawing.Size(248, 64);
            this.rtProductosStockBajoInf.TabIndex = 2;
            this.rtProductosStockBajoInf.Text = "Productos con stock bajo";
            // 
            // rtUnidadesDespachadasInf
            // 
            this.rtUnidadesDespachadasInf.Location = new System.Drawing.Point(273, 24);
            this.rtUnidadesDespachadasInf.Name = "rtUnidadesDespachadasInf";
            this.rtUnidadesDespachadasInf.Size = new System.Drawing.Size(261, 64);
            this.rtUnidadesDespachadasInf.TabIndex = 1;
            this.rtUnidadesDespachadasInf.Text = "Total unidades despachadas";
            // 
            // rtUnidadesIngresadasInf
            // 
            this.rtUnidadesIngresadasInf.Location = new System.Drawing.Point(12, 24);
            this.rtUnidadesIngresadasInf.Name = "rtUnidadesIngresadasInf";
            this.rtUnidadesIngresadasInf.Size = new System.Drawing.Size(255, 64);
            this.rtUnidadesIngresadasInf.TabIndex = 0;
            this.rtUnidadesIngresadasInf.Text = "Total unidades ingresadas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Taller.Properties.Resources.bannerInformes;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormInformes";
            this.Text = "FormInformes";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbStockActualPorProductoInf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtProductosStockBajoInf;
        private System.Windows.Forms.RichTextBox rtUnidadesDespachadasInf;
        private System.Windows.Forms.RichTextBox rtUnidadesIngresadasInf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductoInf;
        private System.Windows.Forms.ComboBox cbProductoInf;
        private System.Windows.Forms.Button btnVerTodoInf;
        private System.Windows.Forms.Button btnFiltrarInf;
        private System.Windows.Forms.Label lblTipoMovimientoInf;
        private System.Windows.Forms.ComboBox cbTipoMovimientoInf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.GroupBox gbStockActualPorProductoInf;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntradasStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalidasStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockActualStockActual;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}