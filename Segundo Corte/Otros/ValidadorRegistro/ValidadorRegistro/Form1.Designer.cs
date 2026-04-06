namespace ValidadorRegistro
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
            this.lblCorreoTitulo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValidarCorreo = new System.Windows.Forms.TextBox();
            this.lblValidarCorreo = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.lblNombreTitulo = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblRegistroExitoso = new System.Windows.Forms.Label();
            this.gbGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCorreoTitulo
            // 
            this.lblCorreoTitulo.AutoSize = true;
            this.lblCorreoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblCorreoTitulo.Name = "lblCorreoTitulo";
            this.lblCorreoTitulo.Size = new System.Drawing.Size(136, 16);
            this.lblCorreoTitulo.TabIndex = 0;
            this.lblCorreoTitulo.Text = "Correo Electrónico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(13, 33);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(239, 20);
            this.txtCorreo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirmar Correo Electrónico";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValidarCorreo
            // 
            this.txtValidarCorreo.Location = new System.Drawing.Point(297, 33);
            this.txtValidarCorreo.Name = "txtValidarCorreo";
            this.txtValidarCorreo.Size = new System.Drawing.Size(239, 20);
            this.txtValidarCorreo.TabIndex = 3;
            // 
            // lblValidarCorreo
            // 
            this.lblValidarCorreo.AutoSize = true;
            this.lblValidarCorreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblValidarCorreo.Location = new System.Drawing.Point(297, 60);
            this.lblValidarCorreo.Name = "lblValidarCorreo";
            this.lblValidarCorreo.Size = new System.Drawing.Size(35, 13);
            this.lblValidarCorreo.TabIndex = 4;
            this.lblValidarCorreo.Text = "label2";
            this.lblValidarCorreo.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(16, 256);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(133, 54);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCorreo.Location = new System.Drawing.Point(13, 60);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(35, 13);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "label3";
            this.lblCorreo.Visible = false;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenero.Location = new System.Drawing.Point(297, 121);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(276, 97);
            this.gbGenero.TabIndex = 7;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Genero";
            this.gbGenero.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(7, 35);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(98, 24);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(7, 66);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(98, 24);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // lblNombreTitulo
            // 
            this.lblNombreTitulo.AutoSize = true;
            this.lblNombreTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTitulo.Location = new System.Drawing.Point(13, 121);
            this.lblNombreTitulo.Name = "lblNombreTitulo";
            this.lblNombreTitulo.Size = new System.Drawing.Size(70, 16);
            this.lblNombreTitulo.TabIndex = 8;
            this.lblNombreTitulo.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(13, 150);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(239, 20);
            this.txtNombres.TabIndex = 9;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(13, 177);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(35, 13);
            this.lblNombres.TabIndex = 10;
            this.lblNombres.Text = "label3";
            this.lblNombres.Visible = false;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(304, 225);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(35, 13);
            this.lblGenero.TabIndex = 11;
            this.lblGenero.Text = "label2";
            this.lblGenero.Visible = false;
            // 
            // lblRegistroExitoso
            // 
            this.lblRegistroExitoso.AutoSize = true;
            this.lblRegistroExitoso.Location = new System.Drawing.Point(156, 276);
            this.lblRegistroExitoso.Name = "lblRegistroExitoso";
            this.lblRegistroExitoso.Size = new System.Drawing.Size(35, 13);
            this.lblRegistroExitoso.TabIndex = 12;
            this.lblRegistroExitoso.Text = "label2";
            this.lblRegistroExitoso.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRegistroExitoso);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombreTitulo);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblValidarCorreo);
            this.Controls.Add(this.txtValidarCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreoTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorreoTitulo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValidarCorreo;
        private System.Windows.Forms.Label lblValidarCorreo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lblNombreTitulo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblRegistroExitoso;
    }
}

