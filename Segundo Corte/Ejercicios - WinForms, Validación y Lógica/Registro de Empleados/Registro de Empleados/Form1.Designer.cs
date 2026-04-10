namespace Registro_de_Empleados
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
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numSueldoBase = new System.Windows.Forms.NumericUpDown();
            this.lblSueldoBase = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblResultadoSueldo = new System.Windows.Forms.Label();
            this.lblValidacionNombres = new System.Windows.Forms.Label();
            this.lblValidacionApellidos = new System.Windows.Forms.Label();
            this.lblValidacionEmail = new System.Windows.Forms.Label();
            this.lblValidacionIdentificacion = new System.Windows.Forms.Label();
            this.lblValidacionDepartamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSueldoBase)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(12, 53);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(174, 20);
            this.txtNombres.TabIndex = 0;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(13, 34);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(76, 17);
            this.lblNombres.TabIndex = 1;
            this.lblNombres.Text = "Nombres";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(224, 53);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(174, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apellidos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(438, 53);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(435, 33);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(12, 146);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(174, 20);
            this.txtIdentificacion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Identificación";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numSueldoBase
            // 
            this.numSueldoBase.Location = new System.Drawing.Point(12, 275);
            this.numSueldoBase.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSueldoBase.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSueldoBase.Name = "numSueldoBase";
            this.numSueldoBase.Size = new System.Drawing.Size(120, 20);
            this.numSueldoBase.TabIndex = 8;
            this.numSueldoBase.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblSueldoBase
            // 
            this.lblSueldoBase.AutoSize = true;
            this.lblSueldoBase.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoBase.Location = new System.Drawing.Point(9, 245);
            this.lblSueldoBase.Name = "lblSueldoBase";
            this.lblSueldoBase.Size = new System.Drawing.Size(96, 17);
            this.lblSueldoBase.TabIndex = 9;
            this.lblSueldoBase.Text = "Sueldo Base";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Items.AddRange(new object[] {
            "Ventas",
            "IT",
            "Recursos Humanos",
            "Contabilidad"});
            this.cmbDepartamento.Location = new System.Drawing.Point(438, 146);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartamento.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Departamento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(482, 275);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(139, 33);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(627, 275);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 33);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblResultadoSueldo
            // 
            this.lblResultadoSueldo.AutoSize = true;
            this.lblResultadoSueldo.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoSueldo.Location = new System.Drawing.Point(331, 275);
            this.lblResultadoSueldo.Name = "lblResultadoSueldo";
            this.lblResultadoSueldo.Size = new System.Drawing.Size(33, 27);
            this.lblResultadoSueldo.TabIndex = 14;
            this.lblResultadoSueldo.Text = "lbl";
            this.lblResultadoSueldo.Visible = false;
            this.lblResultadoSueldo.Click += new System.EventHandler(this.lblResultadoSueldo_Click);
            // 
            // lblValidacionNombres
            // 
            this.lblValidacionNombres.AutoSize = true;
            this.lblValidacionNombres.Location = new System.Drawing.Point(16, 80);
            this.lblValidacionNombres.Name = "lblValidacionNombres";
            this.lblValidacionNombres.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionNombres.TabIndex = 15;
            this.lblValidacionNombres.Text = "label4";
            this.lblValidacionNombres.Visible = false;
            // 
            // lblValidacionApellidos
            // 
            this.lblValidacionApellidos.AutoSize = true;
            this.lblValidacionApellidos.Location = new System.Drawing.Point(221, 80);
            this.lblValidacionApellidos.Name = "lblValidacionApellidos";
            this.lblValidacionApellidos.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionApellidos.TabIndex = 16;
            this.lblValidacionApellidos.Text = "label4";
            this.lblValidacionApellidos.Visible = false;
            // 
            // lblValidacionEmail
            // 
            this.lblValidacionEmail.AutoSize = true;
            this.lblValidacionEmail.Location = new System.Drawing.Point(435, 80);
            this.lblValidacionEmail.Name = "lblValidacionEmail";
            this.lblValidacionEmail.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionEmail.TabIndex = 17;
            this.lblValidacionEmail.Text = "label4";
            this.lblValidacionEmail.Visible = false;
            // 
            // lblValidacionIdentificacion
            // 
            this.lblValidacionIdentificacion.AutoSize = true;
            this.lblValidacionIdentificacion.Location = new System.Drawing.Point(13, 169);
            this.lblValidacionIdentificacion.Name = "lblValidacionIdentificacion";
            this.lblValidacionIdentificacion.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionIdentificacion.TabIndex = 18;
            this.lblValidacionIdentificacion.Text = "label4";
            this.lblValidacionIdentificacion.Visible = false;
            this.lblValidacionIdentificacion.Click += new System.EventHandler(this.lblValidacionIdentificacion_Click);
            // 
            // lblValidacionDepartamento
            // 
            this.lblValidacionDepartamento.AutoSize = true;
            this.lblValidacionDepartamento.Location = new System.Drawing.Point(435, 169);
            this.lblValidacionDepartamento.Name = "lblValidacionDepartamento";
            this.lblValidacionDepartamento.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionDepartamento.TabIndex = 19;
            this.lblValidacionDepartamento.Text = "label4";
            this.lblValidacionDepartamento.Visible = false;
            this.lblValidacionDepartamento.Click += new System.EventHandler(this.lblValidacionDepartamento_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValidacionDepartamento);
            this.Controls.Add(this.lblValidacionIdentificacion);
            this.Controls.Add(this.lblValidacionEmail);
            this.Controls.Add(this.lblValidacionApellidos);
            this.Controls.Add(this.lblValidacionNombres);
            this.Controls.Add(this.lblResultadoSueldo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.lblSueldoBase);
            this.Controls.Add(this.numSueldoBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txtNombres);
            this.Name = "Form1";
            this.Text = "Sistema de Registro de Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.numSueldoBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSueldoBase;
        private System.Windows.Forms.Label lblSueldoBase;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblResultadoSueldo;
        private System.Windows.Forms.Label lblValidacionNombres;
        private System.Windows.Forms.Label lblValidacionApellidos;
        private System.Windows.Forms.Label lblValidacionEmail;
        private System.Windows.Forms.Label lblValidacionIdentificacion;
        private System.Windows.Forms.Label lblValidacionDepartamento;
    }
}

