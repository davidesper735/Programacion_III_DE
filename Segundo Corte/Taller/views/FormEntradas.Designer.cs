namespace Taller.views
{
    partial class FormEntradas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbHistorialdeEntradas = new System.Windows.Forms.GroupBox();
            this.btnActualizarEnt = new System.Windows.Forms.Button();
            this.datagridEntradasEnt = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRegistrarEntrada = new System.Windows.Forms.GroupBox();
            this.btnRegistrarEntradaEnt = new System.Windows.Forms.Button();
            this.txtStockActualEnt = new System.Windows.Forms.TextBox();
            this.lblObservacionEnt = new System.Windows.Forms.Label();
            this.txtObservacionEnt = new System.Windows.Forms.TextBox();
            this.lblCantidadEnt = new System.Windows.Forms.Label();
            this.nudCantidadEnt = new System.Windows.Forms.NumericUpDown();
            this.lblCodigoEnt = new System.Windows.Forms.Label();
            this.cbCodigoEnt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaEnt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbHistorialdeEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridEntradasEnt)).BeginInit();
            this.gbRegistrarEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadEnt)).BeginInit();
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 133;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbHistorialdeEntradas);
            this.panel1.Controls.Add(this.gbRegistrarEntrada);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 318);
            this.panel1.TabIndex = 0;
            // 
            // gbHistorialdeEntradas
            // 
            this.gbHistorialdeEntradas.Controls.Add(this.btnActualizarEnt);
            this.gbHistorialdeEntradas.Controls.Add(this.datagridEntradasEnt);
            this.gbHistorialdeEntradas.Location = new System.Drawing.Point(289, 4);
            this.gbHistorialdeEntradas.Name = "gbHistorialdeEntradas";
            this.gbHistorialdeEntradas.Size = new System.Drawing.Size(502, 226);
            this.gbHistorialdeEntradas.TabIndex = 1;
            this.gbHistorialdeEntradas.TabStop = false;
            this.gbHistorialdeEntradas.Text = "Historial de Entradas";
            // 
            // btnActualizarEnt
            // 
            this.btnActualizarEnt.Location = new System.Drawing.Point(355, 176);
            this.btnActualizarEnt.Name = "btnActualizarEnt";
            this.btnActualizarEnt.Size = new System.Drawing.Size(141, 34);
            this.btnActualizarEnt.TabIndex = 1;
            this.btnActualizarEnt.Text = "Actualizar Historial";
            this.btnActualizarEnt.UseVisualStyleBackColor = true;
            this.btnActualizarEnt.Click += new System.EventHandler(this.button1_Click);
            // 
            // datagridEntradasEnt
            // 
            this.datagridEntradasEnt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridEntradasEnt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridEntradasEnt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Codigo,
            this.Producto,
            this.Cantidad,
            this.Observacion});
            this.datagridEntradasEnt.Location = new System.Drawing.Point(7, 20);
            this.datagridEntradasEnt.Name = "datagridEntradasEnt";
            this.datagridEntradasEnt.Size = new System.Drawing.Size(489, 150);
            this.datagridEntradasEnt.TabIndex = 0;
            this.datagridEntradasEnt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridEntradasEnt_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
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
            // Observacion
            // 
            this.Observacion.HeaderText = "Observacion";
            this.Observacion.Name = "Observacion";
            // 
            // gbRegistrarEntrada
            // 
            this.gbRegistrarEntrada.Controls.Add(this.btnRegistrarEntradaEnt);
            this.gbRegistrarEntrada.Controls.Add(this.txtStockActualEnt);
            this.gbRegistrarEntrada.Controls.Add(this.lblObservacionEnt);
            this.gbRegistrarEntrada.Controls.Add(this.txtObservacionEnt);
            this.gbRegistrarEntrada.Controls.Add(this.lblCantidadEnt);
            this.gbRegistrarEntrada.Controls.Add(this.nudCantidadEnt);
            this.gbRegistrarEntrada.Controls.Add(this.lblCodigoEnt);
            this.gbRegistrarEntrada.Controls.Add(this.cbCodigoEnt);
            this.gbRegistrarEntrada.Controls.Add(this.label1);
            this.gbRegistrarEntrada.Controls.Add(this.txtFechaEnt);
            this.gbRegistrarEntrada.Location = new System.Drawing.Point(4, 4);
            this.gbRegistrarEntrada.Name = "gbRegistrarEntrada";
            this.gbRegistrarEntrada.Size = new System.Drawing.Size(279, 305);
            this.gbRegistrarEntrada.TabIndex = 0;
            this.gbRegistrarEntrada.TabStop = false;
            this.gbRegistrarEntrada.Text = "Registrar Entrada";
            // 
            // btnRegistrarEntradaEnt
            // 
            this.btnRegistrarEntradaEnt.Location = new System.Drawing.Point(25, 232);
            this.btnRegistrarEntradaEnt.Name = "btnRegistrarEntradaEnt";
            this.btnRegistrarEntradaEnt.Size = new System.Drawing.Size(219, 33);
            this.btnRegistrarEntradaEnt.TabIndex = 9;
            this.btnRegistrarEntradaEnt.Text = "Registrar Entrada";
            this.btnRegistrarEntradaEnt.UseVisualStyleBackColor = true;
            // 
            // txtStockActualEnt
            // 
            this.txtStockActualEnt.Location = new System.Drawing.Point(7, 163);
            this.txtStockActualEnt.Multiline = true;
            this.txtStockActualEnt.Name = "txtStockActualEnt";
            this.txtStockActualEnt.Size = new System.Drawing.Size(251, 63);
            this.txtStockActualEnt.TabIndex = 8;
            // 
            // lblObservacionEnt
            // 
            this.lblObservacionEnt.AutoSize = true;
            this.lblObservacionEnt.Location = new System.Drawing.Point(55, 127);
            this.lblObservacionEnt.Name = "lblObservacionEnt";
            this.lblObservacionEnt.Size = new System.Drawing.Size(67, 13);
            this.lblObservacionEnt.TabIndex = 7;
            this.lblObservacionEnt.Text = "Observación";
            // 
            // txtObservacionEnt
            // 
            this.txtObservacionEnt.Location = new System.Drawing.Point(128, 124);
            this.txtObservacionEnt.Name = "txtObservacionEnt";
            this.txtObservacionEnt.Size = new System.Drawing.Size(130, 20);
            this.txtObservacionEnt.TabIndex = 6;
            // 
            // lblCantidadEnt
            // 
            this.lblCantidadEnt.AutoSize = true;
            this.lblCantidadEnt.Location = new System.Drawing.Point(73, 100);
            this.lblCantidadEnt.Name = "lblCantidadEnt";
            this.lblCantidadEnt.Size = new System.Drawing.Size(49, 13);
            this.lblCantidadEnt.TabIndex = 5;
            this.lblCantidadEnt.Text = "Cantidad";
            // 
            // nudCantidadEnt
            // 
            this.nudCantidadEnt.Location = new System.Drawing.Point(128, 98);
            this.nudCantidadEnt.Name = "nudCantidadEnt";
            this.nudCantidadEnt.Size = new System.Drawing.Size(130, 20);
            this.nudCantidadEnt.TabIndex = 4;
            // 
            // lblCodigoEnt
            // 
            this.lblCodigoEnt.AutoSize = true;
            this.lblCodigoEnt.Location = new System.Drawing.Point(47, 73);
            this.lblCodigoEnt.Name = "lblCodigoEnt";
            this.lblCodigoEnt.Size = new System.Drawing.Size(75, 13);
            this.lblCodigoEnt.TabIndex = 3;
            this.lblCodigoEnt.Text = "Cod. Producto";
            // 
            // cbCodigoEnt
            // 
            this.cbCodigoEnt.FormattingEnabled = true;
            this.cbCodigoEnt.Location = new System.Drawing.Point(128, 70);
            this.cbCodigoEnt.Name = "cbCodigoEnt";
            this.cbCodigoEnt.Size = new System.Drawing.Size(130, 21);
            this.cbCodigoEnt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFechaEnt
            // 
            this.txtFechaEnt.Location = new System.Drawing.Point(128, 44);
            this.txtFechaEnt.Name = "txtFechaEnt";
            this.txtFechaEnt.Size = new System.Drawing.Size(130, 20);
            this.txtFechaEnt.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Taller.Properties.Resources.bannerEntradas;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormEntradas";
            this.Text = "FormEntradas";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbHistorialdeEntradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridEntradasEnt)).EndInit();
            this.gbRegistrarEntrada.ResumeLayout(false);
            this.gbRegistrarEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadEnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbHistorialdeEntradas;
        private System.Windows.Forms.GroupBox gbRegistrarEntrada;
        private System.Windows.Forms.DataGridView datagridEntradasEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.Button btnActualizarEnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFechaEnt;
        private System.Windows.Forms.ComboBox cbCodigoEnt;
        private System.Windows.Forms.Button btnRegistrarEntradaEnt;
        private System.Windows.Forms.TextBox txtStockActualEnt;
        private System.Windows.Forms.Label lblObservacionEnt;
        private System.Windows.Forms.TextBox txtObservacionEnt;
        private System.Windows.Forms.Label lblCantidadEnt;
        private System.Windows.Forms.NumericUpDown nudCantidadEnt;
        private System.Windows.Forms.Label lblCodigoEnt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}