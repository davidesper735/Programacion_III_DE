namespace MedSalud
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbListaPacientes = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatosPaciente = new System.Windows.Forms.GroupBox();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lstEPS = new System.Windows.Forms.ListBox();
            this.lstGenero = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEPS = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbListaPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbDatosPaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbListaPacientes);
            this.splitContainer1.Panel2.Controls.Add(this.gbDatosPaciente);
            this.splitContainer1.Size = new System.Drawing.Size(800, 580);
            this.splitContainer1.SplitterDistance = 121;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbListaPacientes
            // 
            this.gbListaPacientes.Controls.Add(this.dataGridView1);
            this.gbListaPacientes.Location = new System.Drawing.Point(4, 248);
            this.gbListaPacientes.Name = "gbListaPacientes";
            this.gbListaPacientes.Size = new System.Drawing.Size(793, 180);
            this.gbListaPacientes.TabIndex = 1;
            this.gbListaPacientes.TabStop = false;
            this.gbListaPacientes.Text = "Lista de Pacientes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Documento,
            this.Nacimiento,
            this.Genero,
            this.EPS,
            this.Telefono,
            this.Motivo});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Documento
            // 
            this.Documento.HeaderText = "N° Documento";
            this.Documento.Name = "Documento";
            // 
            // Nacimiento
            // 
            this.Nacimiento.HeaderText = "F. Nacimiento";
            this.Nacimiento.Name = "Nacimiento";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            // 
            // EPS
            // 
            this.EPS.HeaderText = "EPS";
            this.EPS.Name = "EPS";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            // 
            // gbDatosPaciente
            // 
            this.gbDatosPaciente.Controls.Add(this.dateNacimiento);
            this.gbDatosPaciente.Controls.Add(this.lstEPS);
            this.gbDatosPaciente.Controls.Add(this.lstGenero);
            this.gbDatosPaciente.Controls.Add(this.btnLimpiar);
            this.gbDatosPaciente.Controls.Add(this.btnEliminar);
            this.gbDatosPaciente.Controls.Add(this.btnActualizar);
            this.gbDatosPaciente.Controls.Add(this.btnGuardar);
            this.gbDatosPaciente.Controls.Add(this.lblMotivo);
            this.gbDatosPaciente.Controls.Add(this.txtMotivo);
            this.gbDatosPaciente.Controls.Add(this.lblTelefono);
            this.gbDatosPaciente.Controls.Add(this.txtTelefono);
            this.gbDatosPaciente.Controls.Add(this.lblEPS);
            this.gbDatosPaciente.Controls.Add(this.lblGenero);
            this.gbDatosPaciente.Controls.Add(this.lblNacimiento);
            this.gbDatosPaciente.Controls.Add(this.lblDocumento);
            this.gbDatosPaciente.Controls.Add(this.txtDocumento);
            this.gbDatosPaciente.Controls.Add(this.lblApellido);
            this.gbDatosPaciente.Controls.Add(this.txtApellido);
            this.gbDatosPaciente.Controls.Add(this.lblNombre);
            this.gbDatosPaciente.Controls.Add(this.txtNombre);
            this.gbDatosPaciente.Controls.Add(this.label1);
            this.gbDatosPaciente.Controls.Add(this.txtID);
            this.gbDatosPaciente.Location = new System.Drawing.Point(4, 4);
            this.gbDatosPaciente.Name = "gbDatosPaciente";
            this.gbDatosPaciente.Size = new System.Drawing.Size(796, 237);
            this.gbDatosPaciente.TabIndex = 0;
            this.gbDatosPaciente.TabStop = false;
            this.gbDatosPaciente.Text = "Datos del Paciente";
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNacimiento.Location = new System.Drawing.Point(122, 126);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(209, 20);
            this.dateNacimiento.TabIndex = 24;
            // 
            // lstEPS
            // 
            this.lstEPS.FormattingEnabled = true;
            this.lstEPS.Items.AddRange(new object[] {
            "SantaSalud",
            "Sanitas",
            "Ferrocarril",
            "NuevaEPS"});
            this.lstEPS.Location = new System.Drawing.Point(465, 48);
            this.lstEPS.Name = "lstEPS";
            this.lstEPS.Size = new System.Drawing.Size(209, 17);
            this.lstEPS.TabIndex = 23;
            // 
            // lstGenero
            // 
            this.lstGenero.FormattingEnabled = true;
            this.lstGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.lstGenero.Location = new System.Drawing.Point(465, 22);
            this.lstGenero.Name = "lstGenero";
            this.lstGenero.Size = new System.Drawing.Size(209, 17);
            this.lstGenero.TabIndex = 22;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(709, 208);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(170, 208);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(89, 208);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(8, 208);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(417, 104);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblMotivo.TabIndex = 17;
            this.lblMotivo.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(465, 100);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(209, 20);
            this.txtMotivo.TabIndex = 16;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(407, 77);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(465, 74);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(209, 20);
            this.txtTelefono.TabIndex = 14;
            // 
            // lblEPS
            // 
            this.lblEPS.AutoSize = true;
            this.lblEPS.Location = new System.Drawing.Point(428, 51);
            this.lblEPS.Name = "lblEPS";
            this.lblEPS.Size = new System.Drawing.Size(31, 13);
            this.lblEPS.TabIndex = 13;
            this.lblEPS.Text = "EPS:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(414, 22);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 11;
            this.lblGenero.Text = "Genero:";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(36, 126);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(72, 13);
            this.lblNacimiento.TabIndex = 9;
            this.lblNacimiento.Text = "F. Nacimiento";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(36, 100);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(80, 13);
            this.lblDocumento.TabIndex = 7;
            this.lblDocumento.Text = "N° Documento:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(122, 97);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(209, 20);
            this.txtDocumento.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(69, 74);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(122, 71);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(209, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(69, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(122, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(209, 20);
            this.txtID.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbListaPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbDatosPaciente.ResumeLayout(false);
            this.gbDatosPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbListaPacientes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbDatosPaciente;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblEPS;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstEPS;
        private System.Windows.Forms.ListBox lstGenero;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
    }
}

