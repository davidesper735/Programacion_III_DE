namespace Registro_de_Clientes
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
            this.gbListadoProductos = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.gbCrearProducto = new System.Windows.Forms.GroupBox();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbListadoProductos.SuspendLayout();
            this.gbCrearProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListadoProductos
            // 
            this.gbListadoProductos.Controls.Add(this.btnCargar);
            this.gbListadoProductos.Controls.Add(this.lstClientes);
            this.gbListadoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoProductos.Location = new System.Drawing.Point(12, 278);
            this.gbListadoProductos.Name = "gbListadoProductos";
            this.gbListadoProductos.Size = new System.Drawing.Size(595, 242);
            this.gbListadoProductos.TabIndex = 3;
            this.gbListadoProductos.TabStop = false;
            this.gbListadoProductos.Text = "Clientes Registrados";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(20, 190);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(233, 46);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar desde Archivo";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 20;
            this.lstClientes.Location = new System.Drawing.Point(12, 30);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(571, 144);
            this.lstClientes.TabIndex = 0;
            // 
            // gbCrearProducto
            // 
            this.gbCrearProducto.Controls.Add(this.lblNombre);
            this.gbCrearProducto.Controls.Add(this.txtNombre);
            this.gbCrearProducto.Controls.Add(this.lblCiudad);
            this.gbCrearProducto.Controls.Add(this.txtCiudad);
            this.gbCrearProducto.Controls.Add(this.btnRegistrarCliente);
            this.gbCrearProducto.Controls.Add(this.lblDNI);
            this.gbCrearProducto.Controls.Add(this.txtDNI);
            this.gbCrearProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrearProducto.Location = new System.Drawing.Point(12, 21);
            this.gbCrearProducto.Name = "gbCrearProducto";
            this.gbCrearProducto.Size = new System.Drawing.Size(596, 232);
            this.gbCrearProducto.TabIndex = 2;
            this.gbCrearProducto.TabStop = false;
            this.gbCrearProducto.Text = "Datos del Cliente";
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Location = new System.Drawing.Point(20, 167);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(198, 47);
            this.btnRegistrarCliente.TabIndex = 8;
            this.btnRegistrarCliente.Text = "Registrar Cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(16, 32);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(113, 20);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI (Código)";
            // 
            // txtDNI
            // 
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.Location = new System.Drawing.Point(20, 55);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(257, 26);
            this.txtDNI.TabIndex = 0;
            // 
            // txtCiudad
            // 
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCiudad.Location = new System.Drawing.Point(283, 55);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(278, 26);
            this.txtCiudad.TabIndex = 9;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(283, 32);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(65, 20);
            this.lblCiudad.TabIndex = 10;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(20, 120);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(541, 26);
            this.txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(152, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 560);
            this.Controls.Add(this.gbListadoProductos);
            this.Controls.Add(this.gbCrearProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbListadoProductos.ResumeLayout(false);
            this.gbCrearProducto.ResumeLayout(false);
            this.gbCrearProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListadoProductos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.GroupBox gbCrearProducto;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
    }
}

