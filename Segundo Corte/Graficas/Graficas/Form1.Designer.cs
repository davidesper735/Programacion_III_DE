namespace Graficas
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
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.trackResolucion = new System.Windows.Forms.TrackBar();
            this.trackEscalaZ = new System.Windows.Forms.TrackBar();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.lblEscalaZ = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackResolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEscalaZ)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnReset);
            this.splitContainer1.Panel1.Controls.Add(this.lblEscalaZ);
            this.splitContainer1.Panel1.Controls.Add(this.lblResolucion);
            this.splitContainer1.Panel1.Controls.Add(this.trackEscalaZ);
            this.splitContainer1.Panel1.Controls.Add(this.trackResolucion);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.elementHost1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(530, 450);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // trackResolucion
            // 
            this.trackResolucion.Location = new System.Drawing.Point(44, 77);
            this.trackResolucion.Maximum = 100;
            this.trackResolucion.Minimum = 20;
            this.trackResolucion.Name = "trackResolucion";
            this.trackResolucion.Size = new System.Drawing.Size(167, 45);
            this.trackResolucion.TabIndex = 0;
            this.trackResolucion.Value = 40;
            // 
            // trackEscalaZ
            // 
            this.trackEscalaZ.Location = new System.Drawing.Point(44, 166);
            this.trackEscalaZ.Minimum = 1;
            this.trackEscalaZ.Name = "trackEscalaZ";
            this.trackEscalaZ.Size = new System.Drawing.Size(167, 45);
            this.trackEscalaZ.TabIndex = 1;
            this.trackEscalaZ.Value = 4;
            // 
            // lblResolucion
            // 
            this.lblResolucion.AutoSize = true;
            this.lblResolucion.Location = new System.Drawing.Point(44, 58);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(78, 13);
            this.lblResolucion.TabIndex = 2;
            this.lblResolucion.Text = "Resolución: 40";
            // 
            // lblEscalaZ
            // 
            this.lblEscalaZ.AutoSize = true;
            this.lblEscalaZ.Location = new System.Drawing.Point(47, 147);
            this.lblEscalaZ.Name = "lblEscalaZ";
            this.lblEscalaZ.Size = new System.Drawing.Size(61, 13);
            this.lblEscalaZ.TabIndex = 3;
            this.lblEscalaZ.Text = "Escala Z: 4";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(50, 314);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(161, 39);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset Cámara";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackResolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEscalaZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TrackBar trackResolucion;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblEscalaZ;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.TrackBar trackEscalaZ;
    }
}

