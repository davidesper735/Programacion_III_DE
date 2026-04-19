namespace Gestión_de_Inventario
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
            this.gbCrearProducto = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.nudCosto = new System.Windows.Forms.NumericUpDown();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gbListadoProductos = new System.Windows.Forms.GroupBox();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbCrearProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
            this.gbListadoProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCrearProducto
            // 
            this.gbCrearProducto.Controls.Add(this.btnCrear);
            this.gbCrearProducto.Controls.Add(this.lblCantidad);
            this.gbCrearProducto.Controls.Add(this.nudCantidad);
            this.gbCrearProducto.Controls.Add(this.nudCosto);
            this.gbCrearProducto.Controls.Add(this.lblCosto);
            this.gbCrearProducto.Controls.Add(this.txtCodigo);
            this.gbCrearProducto.Controls.Add(this.lblCodigo);
            this.gbCrearProducto.Controls.Add(this.lblNombre);
            this.gbCrearProducto.Controls.Add(this.txtNombre);
            this.gbCrearProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrearProducto.Location = new System.Drawing.Point(14, 13);
            this.gbCrearProducto.Name = "gbCrearProducto";
            this.gbCrearProducto.Size = new System.Drawing.Size(596, 255);
            this.gbCrearProducto.TabIndex = 0;
            this.gbCrearProducto.TabStop = false;
            this.gbCrearProducto.Text = "Crear Producto";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(20, 191);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(154, 47);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(390, 94);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(81, 20);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCantidad.Location = new System.Drawing.Point(394, 118);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(141, 26);
            this.nudCantidad.TabIndex = 6;
            // 
            // nudCosto
            // 
            this.nudCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCosto.Location = new System.Drawing.Point(225, 118);
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(141, 26);
            this.nudCosto.TabIndex = 5;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(221, 95);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(56, 20);
            this.lblCosto.TabIndex = 4;
            this.lblCosto.Text = "Costo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(20, 118);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(172, 26);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 94);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 20);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(20, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(564, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // gbListadoProductos
            // 
            this.gbListadoProductos.Controls.Add(this.btnActualizar);
            this.gbListadoProductos.Controls.Add(this.lstProductos);
            this.gbListadoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoProductos.Location = new System.Drawing.Point(14, 297);
            this.gbListadoProductos.Name = "gbListadoProductos";
            this.gbListadoProductos.Size = new System.Drawing.Size(595, 242);
            this.gbListadoProductos.TabIndex = 1;
            this.gbListadoProductos.TabStop = false;
            this.gbListadoProductos.Text = "Listado de Productos";
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 20;
            this.lstProductos.Location = new System.Drawing.Point(12, 30);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(571, 144);
            this.lstProductos.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(20, 190);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(154, 46);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 551);
            this.Controls.Add(this.gbListadoProductos);
            this.Controls.Add(this.gbCrearProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCrearProducto.ResumeLayout(false);
            this.gbCrearProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).EndInit();
            this.gbListadoProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCrearProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.NumericUpDown nudCosto;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox gbListadoProductos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ListBox lstProductos;
    }
}

