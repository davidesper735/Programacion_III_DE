namespace Taller.views
{
    partial class FormSalidas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizarSal = new System.Windows.Forms.Button();
            this.dgdHistorialdeSalidasSal = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRegistrarSalidaSal = new System.Windows.Forms.GroupBox();
            this.btnRegistrarSalidaSal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblObservacionSal = new System.Windows.Forms.Label();
            this.txtObservacionSal = new System.Windows.Forms.TextBox();
            this.lblCantidadSal = new System.Windows.Forms.Label();
            this.lblCodigoSal = new System.Windows.Forms.Label();
            this.nudCantidadSal = new System.Windows.Forms.NumericUpDown();
            this.cbCodigoSal = new System.Windows.Forms.ComboBox();
            this.lblFechaSal = new System.Windows.Forms.Label();
            this.txtFechaSal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdHistorialdeSalidasSal)).BeginInit();
            this.gbRegistrarSalidaSal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadSal)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.gbRegistrarSalidaSal);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizarSal);
            this.groupBox1.Controls.Add(this.dgdHistorialdeSalidasSal);
            this.groupBox1.Location = new System.Drawing.Point(263, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de Salidas";
            // 
            // btnActualizarSal
            // 
            this.btnActualizarSal.Location = new System.Drawing.Point(337, 223);
            this.btnActualizarSal.Name = "btnActualizarSal";
            this.btnActualizarSal.Size = new System.Drawing.Size(182, 30);
            this.btnActualizarSal.TabIndex = 1;
            this.btnActualizarSal.Text = "Actualizar Historial";
            this.btnActualizarSal.UseVisualStyleBackColor = true;
            // 
            // dgdHistorialdeSalidasSal
            // 
            this.dgdHistorialdeSalidasSal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdHistorialdeSalidasSal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdHistorialdeSalidasSal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Codigo,
            this.Producto,
            this.Cantidad,
            this.Observacion});
            this.dgdHistorialdeSalidasSal.Location = new System.Drawing.Point(7, 19);
            this.dgdHistorialdeSalidasSal.Name = "dgdHistorialdeSalidasSal";
            this.dgdHistorialdeSalidasSal.Size = new System.Drawing.Size(512, 198);
            this.dgdHistorialdeSalidasSal.TabIndex = 0;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
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
            // Observacion
            // 
            this.Observacion.HeaderText = "Observación";
            this.Observacion.Name = "Observacion";
            // 
            // gbRegistrarSalidaSal
            // 
            this.gbRegistrarSalidaSal.Controls.Add(this.btnRegistrarSalidaSal);
            this.gbRegistrarSalidaSal.Controls.Add(this.textBox1);
            this.gbRegistrarSalidaSal.Controls.Add(this.lblObservacionSal);
            this.gbRegistrarSalidaSal.Controls.Add(this.txtObservacionSal);
            this.gbRegistrarSalidaSal.Controls.Add(this.lblCantidadSal);
            this.gbRegistrarSalidaSal.Controls.Add(this.lblCodigoSal);
            this.gbRegistrarSalidaSal.Controls.Add(this.nudCantidadSal);
            this.gbRegistrarSalidaSal.Controls.Add(this.cbCodigoSal);
            this.gbRegistrarSalidaSal.Controls.Add(this.lblFechaSal);
            this.gbRegistrarSalidaSal.Controls.Add(this.txtFechaSal);
            this.gbRegistrarSalidaSal.Location = new System.Drawing.Point(12, 3);
            this.gbRegistrarSalidaSal.Name = "gbRegistrarSalidaSal";
            this.gbRegistrarSalidaSal.Size = new System.Drawing.Size(245, 259);
            this.gbRegistrarSalidaSal.TabIndex = 0;
            this.gbRegistrarSalidaSal.TabStop = false;
            this.gbRegistrarSalidaSal.Text = "Registrar Salida";
            // 
            // btnRegistrarSalidaSal
            // 
            this.btnRegistrarSalidaSal.Location = new System.Drawing.Point(23, 223);
            this.btnRegistrarSalidaSal.Name = "btnRegistrarSalidaSal";
            this.btnRegistrarSalidaSal.Size = new System.Drawing.Size(197, 28);
            this.btnRegistrarSalidaSal.TabIndex = 9;
            this.btnRegistrarSalidaSal.Text = "Registrar Salida";
            this.btnRegistrarSalidaSal.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 83);
            this.textBox1.TabIndex = 8;
            // 
            // lblObservacionSal
            // 
            this.lblObservacionSal.AutoSize = true;
            this.lblObservacionSal.Location = new System.Drawing.Point(41, 102);
            this.lblObservacionSal.Name = "lblObservacionSal";
            this.lblObservacionSal.Size = new System.Drawing.Size(70, 13);
            this.lblObservacionSal.TabIndex = 7;
            this.lblObservacionSal.Text = "Observación:";
            // 
            // txtObservacionSal
            // 
            this.txtObservacionSal.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtObservacionSal.Location = new System.Drawing.Point(117, 99);
            this.txtObservacionSal.Name = "txtObservacionSal";
            this.txtObservacionSal.Size = new System.Drawing.Size(121, 20);
            this.txtObservacionSal.TabIndex = 6;
            this.txtObservacionSal.Text = "Ej: Venta Cliente";
            // 
            // lblCantidadSal
            // 
            this.lblCantidadSal.AutoSize = true;
            this.lblCantidadSal.Location = new System.Drawing.Point(59, 75);
            this.lblCantidadSal.Name = "lblCantidadSal";
            this.lblCantidadSal.Size = new System.Drawing.Size(52, 13);
            this.lblCantidadSal.TabIndex = 5;
            this.lblCantidadSal.Text = "Cantidad:";
            // 
            // lblCodigoSal
            // 
            this.lblCodigoSal.AutoSize = true;
            this.lblCodigoSal.Location = new System.Drawing.Point(37, 48);
            this.lblCodigoSal.Name = "lblCodigoSal";
            this.lblCodigoSal.Size = new System.Drawing.Size(78, 13);
            this.lblCodigoSal.TabIndex = 4;
            this.lblCodigoSal.Text = "Cod. Producto:";
            // 
            // nudCantidadSal
            // 
            this.nudCantidadSal.Location = new System.Drawing.Point(118, 73);
            this.nudCantidadSal.Name = "nudCantidadSal";
            this.nudCantidadSal.Size = new System.Drawing.Size(120, 20);
            this.nudCantidadSal.TabIndex = 3;
            // 
            // cbCodigoSal
            // 
            this.cbCodigoSal.FormattingEnabled = true;
            this.cbCodigoSal.Location = new System.Drawing.Point(118, 45);
            this.cbCodigoSal.Name = "cbCodigoSal";
            this.cbCodigoSal.Size = new System.Drawing.Size(121, 21);
            this.cbCodigoSal.TabIndex = 2;
            // 
            // lblFechaSal
            // 
            this.lblFechaSal.AutoSize = true;
            this.lblFechaSal.Location = new System.Drawing.Point(71, 22);
            this.lblFechaSal.Name = "lblFechaSal";
            this.lblFechaSal.Size = new System.Drawing.Size(40, 13);
            this.lblFechaSal.TabIndex = 1;
            this.lblFechaSal.Text = "Fecha:";
            // 
            // txtFechaSal
            // 
            this.txtFechaSal.Location = new System.Drawing.Point(118, 19);
            this.txtFechaSal.Name = "txtFechaSal";
            this.txtFechaSal.Size = new System.Drawing.Size(121, 20);
            this.txtFechaSal.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Taller.Properties.Resources.bannerSalidas;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(793, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormSalidas";
            this.Text = "Registrar Salida";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdHistorialdeSalidasSal)).EndInit();
            this.gbRegistrarSalidaSal.ResumeLayout(false);
            this.gbRegistrarSalidaSal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadSal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbRegistrarSalidaSal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgdHistorialdeSalidasSal;
        private System.Windows.Forms.Button btnActualizarSal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.Label lblFechaSal;
        private System.Windows.Forms.TextBox txtFechaSal;
        private System.Windows.Forms.ComboBox cbCodigoSal;
        private System.Windows.Forms.Label lblCodigoSal;
        private System.Windows.Forms.NumericUpDown nudCantidadSal;
        private System.Windows.Forms.Label lblObservacionSal;
        private System.Windows.Forms.TextBox txtObservacionSal;
        private System.Windows.Forms.Label lblCantidadSal;
        private System.Windows.Forms.Button btnRegistrarSalidaSal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}