namespace Inventario_Productos
{
    partial class form1
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.numStockInicial = new System.Windows.Forms.NumericUpDown();
            this.lblStockInicial = new System.Windows.Forms.Label();
            this.numStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblStockFinal = new System.Windows.Forms.Label();
            this.gbIva = new System.Windows.Forms.GroupBox();
            this.rbReducido = new System.Windows.Forms.RadioButton();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.rbExento = new System.Windows.Forms.RadioButton();
            this.chkEsPerecedero = new System.Windows.Forms.CheckBox();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFehaVencimiento = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblValidacionCodigo = new System.Windows.Forms.Label();
            this.lblValidacionNombre = new System.Windows.Forms.Label();
            this.lblValidacionCategoria = new System.Windows.Forms.Label();
            this.lblValidacionStock = new System.Windows.Forms.Label();
            this.lblValidacionIVA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).BeginInit();
            this.gbIva.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(144, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(256, 51);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(170, 20);
            this.txtNombreProducto.TabIndex = 2;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(253, 35);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(107, 13);
            this.lblNombreProducto.TabIndex = 3;
            this.lblNombreProducto.Text = "Nombre del Producto";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Electrónica",
            "Alimentos",
            "Ropa"});
            this.cmbCategoria.Location = new System.Drawing.Point(16, 132);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 4;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(13, 116);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría";
            // 
            // numStockInicial
            // 
            this.numStockInicial.Location = new System.Drawing.Point(16, 227);
            this.numStockInicial.Name = "numStockInicial";
            this.numStockInicial.Size = new System.Drawing.Size(120, 20);
            this.numStockInicial.TabIndex = 6;
            // 
            // lblStockInicial
            // 
            this.lblStockInicial.AutoSize = true;
            this.lblStockInicial.Location = new System.Drawing.Point(13, 211);
            this.lblStockInicial.Name = "lblStockInicial";
            this.lblStockInicial.Size = new System.Drawing.Size(65, 13);
            this.lblStockInicial.TabIndex = 7;
            this.lblStockInicial.Text = "Stock Inicial";
            // 
            // numStockMinimo
            // 
            this.numStockMinimo.Location = new System.Drawing.Point(204, 227);
            this.numStockMinimo.Name = "numStockMinimo";
            this.numStockMinimo.Size = new System.Drawing.Size(120, 20);
            this.numStockMinimo.TabIndex = 8;
            // 
            // lblStockFinal
            // 
            this.lblStockFinal.AutoSize = true;
            this.lblStockFinal.Location = new System.Drawing.Point(201, 211);
            this.lblStockFinal.Name = "lblStockFinal";
            this.lblStockFinal.Size = new System.Drawing.Size(60, 13);
            this.lblStockFinal.TabIndex = 9;
            this.lblStockFinal.Text = "Stock Final";
            // 
            // gbIva
            // 
            this.gbIva.Controls.Add(this.rbReducido);
            this.gbIva.Controls.Add(this.rbGeneral);
            this.gbIva.Controls.Add(this.rbExento);
            this.gbIva.Location = new System.Drawing.Point(446, 132);
            this.gbIva.Name = "gbIva";
            this.gbIva.Size = new System.Drawing.Size(319, 92);
            this.gbIva.TabIndex = 10;
            this.gbIva.TabStop = false;
            this.gbIva.Text = "IVA";
            // 
            // rbReducido
            // 
            this.rbReducido.AutoSize = true;
            this.rbReducido.Location = new System.Drawing.Point(7, 66);
            this.rbReducido.Name = "rbReducido";
            this.rbReducido.Size = new System.Drawing.Size(71, 17);
            this.rbReducido.TabIndex = 2;
            this.rbReducido.TabStop = true;
            this.rbReducido.Text = "Reducido";
            this.rbReducido.UseVisualStyleBackColor = true;
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Location = new System.Drawing.Point(7, 43);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(62, 17);
            this.rbGeneral.TabIndex = 1;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "General";
            this.rbGeneral.UseVisualStyleBackColor = true;
            // 
            // rbExento
            // 
            this.rbExento.AutoSize = true;
            this.rbExento.Location = new System.Drawing.Point(7, 20);
            this.rbExento.Name = "rbExento";
            this.rbExento.Size = new System.Drawing.Size(58, 17);
            this.rbExento.TabIndex = 0;
            this.rbExento.TabStop = true;
            this.rbExento.Text = "Exento";
            this.rbExento.UseVisualStyleBackColor = true;
            // 
            // chkEsPerecedero
            // 
            this.chkEsPerecedero.AutoSize = true;
            this.chkEsPerecedero.Location = new System.Drawing.Point(446, 251);
            this.chkEsPerecedero.Name = "chkEsPerecedero";
            this.chkEsPerecedero.Size = new System.Drawing.Size(96, 17);
            this.chkEsPerecedero.TabIndex = 11;
            this.chkEsPerecedero.Text = "Es Perecedero";
            this.chkEsPerecedero.UseVisualStyleBackColor = true;
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Enabled = false;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(16, 297);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaVencimiento.TabIndex = 12;
            // 
            // lblFehaVencimiento
            // 
            this.lblFehaVencimiento.AutoSize = true;
            this.lblFehaVencimiento.Location = new System.Drawing.Point(16, 278);
            this.lblFehaVencimiento.Name = "lblFehaVencimiento";
            this.lblFehaVencimiento.Size = new System.Drawing.Size(113, 13);
            this.lblFehaVencimiento.TabIndex = 13;
            this.lblFehaVencimiento.Text = "Fecha de Vencimiento";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(453, 378);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(138, 40);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(616, 378);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(138, 40);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblValidacionCodigo
            // 
            this.lblValidacionCodigo.AutoSize = true;
            this.lblValidacionCodigo.Location = new System.Drawing.Point(16, 78);
            this.lblValidacionCodigo.Name = "lblValidacionCodigo";
            this.lblValidacionCodigo.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionCodigo.TabIndex = 16;
            this.lblValidacionCodigo.Text = "label1";
            // 
            // lblValidacionNombre
            // 
            this.lblValidacionNombre.AutoSize = true;
            this.lblValidacionNombre.Location = new System.Drawing.Point(264, 78);
            this.lblValidacionNombre.Name = "lblValidacionNombre";
            this.lblValidacionNombre.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionNombre.TabIndex = 17;
            this.lblValidacionNombre.Text = "label1";
            this.lblValidacionNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblValidacionCategoria
            // 
            this.lblValidacionCategoria.AutoSize = true;
            this.lblValidacionCategoria.Location = new System.Drawing.Point(18, 156);
            this.lblValidacionCategoria.Name = "lblValidacionCategoria";
            this.lblValidacionCategoria.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionCategoria.TabIndex = 18;
            this.lblValidacionCategoria.Text = "label1";
            // 
            // lblValidacionStock
            // 
            this.lblValidacionStock.AutoSize = true;
            this.lblValidacionStock.Location = new System.Drawing.Point(153, 255);
            this.lblValidacionStock.Name = "lblValidacionStock";
            this.lblValidacionStock.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionStock.TabIndex = 19;
            this.lblValidacionStock.Text = "label1";
            // 
            // lblValidacionIVA
            // 
            this.lblValidacionIVA.AutoSize = true;
            this.lblValidacionIVA.Location = new System.Drawing.Point(450, 227);
            this.lblValidacionIVA.Name = "lblValidacionIVA";
            this.lblValidacionIVA.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionIVA.TabIndex = 20;
            this.lblValidacionIVA.Text = "label1";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValidacionIVA);
            this.Controls.Add(this.lblValidacionStock);
            this.Controls.Add(this.lblValidacionCategoria);
            this.Controls.Add(this.lblValidacionNombre);
            this.Controls.Add(this.lblValidacionCodigo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblFehaVencimiento);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.chkEsPerecedero);
            this.Controls.Add(this.gbIva);
            this.Controls.Add(this.lblStockFinal);
            this.Controls.Add(this.numStockMinimo);
            this.Controls.Add(this.lblStockInicial);
            this.Controls.Add(this.numStockInicial);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Name = "form1";
            this.Text = "Gestión de Inventario de Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStockInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).EndInit();
            this.gbIva.ResumeLayout(false);
            this.gbIva.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.NumericUpDown numStockInicial;
        private System.Windows.Forms.Label lblStockInicial;
        private System.Windows.Forms.NumericUpDown numStockMinimo;
        private System.Windows.Forms.Label lblStockFinal;
        private System.Windows.Forms.GroupBox gbIva;
        private System.Windows.Forms.RadioButton rbReducido;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.RadioButton rbExento;
        private System.Windows.Forms.CheckBox chkEsPerecedero;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label lblFehaVencimiento;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblValidacionCodigo;
        private System.Windows.Forms.Label lblValidacionNombre;
        private System.Windows.Forms.Label lblValidacionCategoria;
        private System.Windows.Forms.Label lblValidacionStock;
        private System.Windows.Forms.Label lblValidacionIVA;
    }
}

