namespace Reserva_Hotel
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.clbServicios = new System.Windows.Forms.CheckedListBox();
            this.lblServicios = new System.Windows.Forms.Label();
            this.rtbResumen = new System.Windows.Forms.RichTextBox();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnCalcularReserva = new System.Windows.Forms.Button();
            this.lblValidacionCliente = new System.Windows.Forms.Label();
            this.lblValidacionEntrada = new System.Windows.Forms.Label();
            this.lblValidacionSalida = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.lblPersonas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(12, 25);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(177, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(9, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(12, 105);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(200, 20);
            this.dtpEntrada.TabIndex = 2;
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(252, 105);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpSalida.TabIndex = 3;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(12, 89);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(44, 13);
            this.lblEntrada.TabIndex = 4;
            this.lblEntrada.Text = "Entrada";
            this.lblEntrada.Click += new System.EventHandler(this.lblEntrada_Click);
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(249, 89);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(36, 13);
            this.lblSalida.TabIndex = 5;
            this.lblSalida.Text = "Salida";
            // 
            // clbServicios
            // 
            this.clbServicios.FormattingEnabled = true;
            this.clbServicios.Items.AddRange(new object[] {
            "WiFi Premium",
            "Desayuno Buffet",
            "Estacionamiento",
            "Spa"});
            this.clbServicios.Location = new System.Drawing.Point(12, 171);
            this.clbServicios.Name = "clbServicios";
            this.clbServicios.Size = new System.Drawing.Size(120, 94);
            this.clbServicios.TabIndex = 6;
            // 
            // lblServicios
            // 
            this.lblServicios.AutoSize = true;
            this.lblServicios.Location = new System.Drawing.Point(12, 152);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(50, 13);
            this.lblServicios.TabIndex = 7;
            this.lblServicios.Text = "Servicios";
            // 
            // rtbResumen
            // 
            this.rtbResumen.Location = new System.Drawing.Point(252, 171);
            this.rtbResumen.Name = "rtbResumen";
            this.rtbResumen.ReadOnly = true;
            this.rtbResumen.Size = new System.Drawing.Size(200, 183);
            this.rtbResumen.TabIndex = 8;
            this.rtbResumen.Text = "";
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(252, 152);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(52, 13);
            this.lblResumen.TabIndex = 9;
            this.lblResumen.Text = "Resumen";
            // 
            // btnCalcularReserva
            // 
            this.btnCalcularReserva.Location = new System.Drawing.Point(453, 372);
            this.btnCalcularReserva.Name = "btnCalcularReserva";
            this.btnCalcularReserva.Size = new System.Drawing.Size(139, 42);
            this.btnCalcularReserva.TabIndex = 10;
            this.btnCalcularReserva.Text = "Calcular Reserva";
            this.btnCalcularReserva.UseVisualStyleBackColor = true;
            this.btnCalcularReserva.Click += new System.EventHandler(this.btnCalcularReserva_Click);
            // 
            // lblValidacionCliente
            // 
            this.lblValidacionCliente.AutoSize = true;
            this.lblValidacionCliente.Location = new System.Drawing.Point(12, 52);
            this.lblValidacionCliente.Name = "lblValidacionCliente";
            this.lblValidacionCliente.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionCliente.TabIndex = 11;
            this.lblValidacionCliente.Text = "label1";
            this.lblValidacionCliente.Visible = false;
            // 
            // lblValidacionEntrada
            // 
            this.lblValidacionEntrada.AutoSize = true;
            this.lblValidacionEntrada.Location = new System.Drawing.Point(13, 128);
            this.lblValidacionEntrada.Name = "lblValidacionEntrada";
            this.lblValidacionEntrada.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionEntrada.TabIndex = 12;
            this.lblValidacionEntrada.Text = "label1";
            this.lblValidacionEntrada.Visible = false;
            // 
            // lblValidacionSalida
            // 
            this.lblValidacionSalida.AutoSize = true;
            this.lblValidacionSalida.Location = new System.Drawing.Point(252, 128);
            this.lblValidacionSalida.Name = "lblValidacionSalida";
            this.lblValidacionSalida.Size = new System.Drawing.Size(35, 13);
            this.lblValidacionSalida.TabIndex = 13;
            this.lblValidacionSalida.Text = "label1";
            this.lblValidacionSalida.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(629, 372);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(139, 42);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // numPersonas
            // 
            this.numPersonas.Location = new System.Drawing.Point(252, 25);
            this.numPersonas.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPersonas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPersonas.Name = "numPersonas";
            this.numPersonas.Size = new System.Drawing.Size(120, 20);
            this.numPersonas.TabIndex = 15;
            this.numPersonas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(252, 9);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(51, 13);
            this.lblPersonas.TabIndex = 16;
            this.lblPersonas.Text = "Personas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.numPersonas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblValidacionSalida);
            this.Controls.Add(this.lblValidacionEntrada);
            this.Controls.Add(this.lblValidacionCliente);
            this.Controls.Add(this.btnCalcularReserva);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.rtbResumen);
            this.Controls.Add(this.lblServicios);
            this.Controls.Add(this.clbServicios);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.dtpEntrada);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.CheckedListBox clbServicios;
        private System.Windows.Forms.Label lblServicios;
        private System.Windows.Forms.RichTextBox rtbResumen;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnCalcularReserva;
        private System.Windows.Forms.Label lblValidacionCliente;
        private System.Windows.Forms.Label lblValidacionEntrada;
        private System.Windows.Forms.Label lblValidacionSalida;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.Label lblPersonas;
    }
}

