namespace NotasAlumnos
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
            this.gbNuevoRegistro = new System.Windows.Forms.GroupBox();
            this.lblNombreAlumno = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnGuardarProcesar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDesaprobados = new System.Windows.Forms.GroupBox();
            this.lstAprobados = new System.Windows.Forms.ListBox();
            this.lstDesaprobados = new System.Windows.Forms.ListBox();
            this.gbNuevoRegistro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbDesaprobados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNuevoRegistro
            // 
            this.gbNuevoRegistro.Controls.Add(this.btnGuardarProcesar);
            this.gbNuevoRegistro.Controls.Add(this.lblNota);
            this.gbNuevoRegistro.Controls.Add(this.txtNota);
            this.gbNuevoRegistro.Controls.Add(this.txtNombreAlumno);
            this.gbNuevoRegistro.Controls.Add(this.lblNombreAlumno);
            this.gbNuevoRegistro.Location = new System.Drawing.Point(13, 13);
            this.gbNuevoRegistro.Name = "gbNuevoRegistro";
            this.gbNuevoRegistro.Size = new System.Drawing.Size(775, 177);
            this.gbNuevoRegistro.TabIndex = 0;
            this.gbNuevoRegistro.TabStop = false;
            this.gbNuevoRegistro.Text = "Nuevo Registro";
            // 
            // lblNombreAlumno
            // 
            this.lblNombreAlumno.AutoSize = true;
            this.lblNombreAlumno.Location = new System.Drawing.Point(7, 41);
            this.lblNombreAlumno.Name = "lblNombreAlumno";
            this.lblNombreAlumno.Size = new System.Drawing.Size(99, 13);
            this.lblNombreAlumno.TabIndex = 0;
            this.lblNombreAlumno.Text = "Nombre del Alumno";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(10, 58);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(278, 20);
            this.txtNombreAlumno.TabIndex = 1;
            this.txtNombreAlumno.Text = "Ej: David Esper";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(395, 58);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(278, 20);
            this.txtNota.TabIndex = 2;
            this.txtNota.Text = "Ej: 5.0";
            this.txtNota.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(392, 41);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(78, 13);
            this.lblNota.TabIndex = 3;
            this.lblNota.Text = "Nota (0.0 - 5.0)";
            // 
            // btnGuardarProcesar
            // 
            this.btnGuardarProcesar.Location = new System.Drawing.Point(578, 109);
            this.btnGuardarProcesar.Name = "btnGuardarProcesar";
            this.btnGuardarProcesar.Size = new System.Drawing.Size(172, 49);
            this.btnGuardarProcesar.TabIndex = 4;
            this.btnGuardarProcesar.Text = "Guardar y Procesar";
            this.btnGuardarProcesar.UseVisualStyleBackColor = true;
            this.btnGuardarProcesar.Click += new System.EventHandler(this.btnGuardarProcesar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstAprobados);
            this.groupBox1.Location = new System.Drawing.Point(13, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aprobados (>= 3.0)";
            // 
            // gbDesaprobados
            // 
            this.gbDesaprobados.Controls.Add(this.lstDesaprobados);
            this.gbDesaprobados.Location = new System.Drawing.Point(437, 197);
            this.gbDesaprobados.Name = "gbDesaprobados";
            this.gbDesaprobados.Size = new System.Drawing.Size(338, 241);
            this.gbDesaprobados.TabIndex = 2;
            this.gbDesaprobados.TabStop = false;
            this.gbDesaprobados.Text = "Desaprobados (< 3.0)";
            // 
            // lstAprobados
            // 
            this.lstAprobados.FormattingEnabled = true;
            this.lstAprobados.Location = new System.Drawing.Point(19, 42);
            this.lstAprobados.Name = "lstAprobados";
            this.lstAprobados.Size = new System.Drawing.Size(298, 186);
            this.lstAprobados.TabIndex = 0;
            // 
            // lstDesaprobados
            // 
            this.lstDesaprobados.FormattingEnabled = true;
            this.lstDesaprobados.Location = new System.Drawing.Point(16, 42);
            this.lstDesaprobados.Name = "lstDesaprobados";
            this.lstDesaprobados.Size = new System.Drawing.Size(298, 186);
            this.lstDesaprobados.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDesaprobados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbNuevoRegistro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbNuevoRegistro.ResumeLayout(false);
            this.gbNuevoRegistro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbDesaprobados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNuevoRegistro;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblNombreAlumno;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnGuardarProcesar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstAprobados;
        private System.Windows.Forms.GroupBox gbDesaprobados;
        private System.Windows.Forms.ListBox lstDesaprobados;
    }
}

