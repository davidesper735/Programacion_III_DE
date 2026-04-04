namespace Catálogo_de_Producto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.nudCantidad);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.txtbDescripcion);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(256, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 349);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTitulo.Location = new System.Drawing.Point(3, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(228, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "AMD Ryzen 5 5000 Series";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbDescripcion.Location = new System.Drawing.Point(3, 84);
            this.txtbDescripcion.Multiline = true;
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.ReadOnly = true;
            this.txtbDescripcion.Size = new System.Drawing.Size(273, 105);
            this.txtbDescripcion.TabIndex = 1;
            this.txtbDescripcion.Text = "El AMD Ryzen 5 de la serie 5000 es un procesador de gama media-alta, ideal para g" +
    "aming y productividad, basado en la arquitectura Zen 3 de 7nm.";
            this.txtbDescripcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPrecio.Location = new System.Drawing.Point(186, 214);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(90, 25);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "$299.99";
            this.lblPrecio.Click += new System.EventHandler(this.label2_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(156, 264);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 22);
            this.nudCantidad.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(77, 263);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.Olive;
            this.btnAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(112, 292);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(164, 40);
            this.btnAñadir.TabIndex = 5;
            this.btnAñadir.Text = "Añadir al Carrito";
            this.btnAñadir.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Catálogo de Producto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAñadir;
    }
}

