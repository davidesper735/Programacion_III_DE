namespace Control_de_Ventas_Diarias
{
    partial class Form1
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
            this.gbNuevaVenta = new System.Windows.Forms.GroupBox();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.btnGuardarTransaccion = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalPre = new System.Windows.Forms.Label();
            this.lblTotalStr = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.gbNuevaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNuevaVenta
            // 
            this.gbNuevaVenta.Controls.Add(this.nudMonto);
            this.gbNuevaVenta.Controls.Add(this.btnGuardarTransaccion);
            this.gbNuevaVenta.Controls.Add(this.lblMonto);
            this.gbNuevaVenta.Controls.Add(this.txtID);
            this.gbNuevaVenta.Controls.Add(this.lblID);
            this.gbNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNuevaVenta.Location = new System.Drawing.Point(13, 13);
            this.gbNuevaVenta.Name = "gbNuevaVenta";
            this.gbNuevaVenta.Size = new System.Drawing.Size(553, 216);
            this.gbNuevaVenta.TabIndex = 0;
            this.gbNuevaVenta.TabStop = false;
            this.gbNuevaVenta.Text = "Nueva Venta";
            // 
            // nudMonto
            // 
            this.nudMonto.Location = new System.Drawing.Point(288, 60);
            this.nudMonto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(245, 26);
            this.nudMonto.TabIndex = 5;
            // 
            // btnGuardarTransaccion
            // 
            this.btnGuardarTransaccion.Location = new System.Drawing.Point(11, 146);
            this.btnGuardarTransaccion.Name = "btnGuardarTransaccion";
            this.btnGuardarTransaccion.Size = new System.Drawing.Size(200, 46);
            this.btnGuardarTransaccion.TabIndex = 4;
            this.btnGuardarTransaccion.Text = "Guardar Transacción";
            this.btnGuardarTransaccion.UseVisualStyleBackColor = true;
            this.btnGuardarTransaccion.Click += new System.EventHandler(this.btnGuardarTransaccion_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(284, 36);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(86, 20);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Monto ($)";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(11, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(233, 26);
            this.txtID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(7, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(130, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID Transacción";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalPre);
            this.groupBox1.Controls.Add(this.lblTotalStr);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.lstHistorial);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial";
            // 
            // lblTotalPre
            // 
            this.lblTotalPre.AutoSize = true;
            this.lblTotalPre.Location = new System.Drawing.Point(429, 246);
            this.lblTotalPre.Name = "lblTotalPre";
            this.lblTotalPre.Size = new System.Drawing.Size(44, 20);
            this.lblTotalPre.TabIndex = 3;
            this.lblTotalPre.Text = "0.00";
            // 
            // lblTotalStr
            // 
            this.lblTotalStr.AutoSize = true;
            this.lblTotalStr.Location = new System.Drawing.Point(354, 246);
            this.lblTotalStr.Name = "lblTotalStr";
            this.lblTotalStr.Size = new System.Drawing.Size(69, 20);
            this.lblTotalStr.TabIndex = 2;
            this.lblTotalStr.Text = "TOTAL:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(11, 235);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(172, 42);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lstHistorial
            // 
            this.lstHistorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 20;
            this.lstHistorial.Location = new System.Drawing.Point(7, 26);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(526, 202);
            this.lstHistorial.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbNuevaVenta);
            this.Name = "Form1";
            this.Text = "Ventas V1.0";
            this.gbNuevaVenta.ResumeLayout(false);
            this.gbNuevaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNuevaVenta;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.Button btnGuardarTransaccion;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Label lblTotalPre;
        private System.Windows.Forms.Label lblTotalStr;
        private System.Windows.Forms.Button btnCargar;
    }
}

