namespace ReproductorMusica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgCancion = new System.Windows.Forms.PictureBox();
            this.lblTituloCancion = new System.Windows.Forms.Label();
            this.lblArtista = new System.Windows.Forms.Label();
            this.pbCancion = new System.Windows.Forms.ProgressBar();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAdelantar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgCancion)).BeginInit();
            this.SuspendLayout();
            // 
            // imgCancion
            // 
            this.imgCancion.Image = ((System.Drawing.Image)(resources.GetObject("imgCancion.Image")));
            this.imgCancion.Location = new System.Drawing.Point(265, 12);
            this.imgCancion.Name = "imgCancion";
            this.imgCancion.Size = new System.Drawing.Size(276, 277);
            this.imgCancion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCancion.TabIndex = 0;
            this.imgCancion.TabStop = false;
            // 
            // lblTituloCancion
            // 
            this.lblTituloCancion.AutoSize = true;
            this.lblTituloCancion.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCancion.Location = new System.Drawing.Point(321, 292);
            this.lblTituloCancion.Name = "lblTituloCancion";
            this.lblTituloCancion.Size = new System.Drawing.Size(183, 24);
            this.lblTituloCancion.TabIndex = 1;
            this.lblTituloCancion.Text = "Serve The Servants";
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtista.Location = new System.Drawing.Point(381, 316);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(57, 19);
            this.lblArtista.TabIndex = 2;
            this.lblArtista.Text = "Nirvana";
            // 
            // pbCancion
            // 
            this.pbCancion.Location = new System.Drawing.Point(229, 338);
            this.pbCancion.Name = "pbCancion";
            this.pbCancion.Size = new System.Drawing.Size(360, 23);
            this.pbCancion.TabIndex = 3;
            this.pbCancion.Value = 45;
            this.pbCancion.Click += new System.EventHandler(this.pbCancion_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(287, 377);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(75, 23);
            this.btnRetroceder.TabIndex = 4;
            this.btnRetroceder.Text = "<<";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(368, 377);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdelantar
            // 
            this.btnAdelantar.Location = new System.Drawing.Point(449, 377);
            this.btnAdelantar.Name = "btnAdelantar";
            this.btnAdelantar.Size = new System.Drawing.Size(75, 23);
            this.btnAdelantar.TabIndex = 6;
            this.btnAdelantar.Text = ">>";
            this.btnAdelantar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdelantar);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.pbCancion);
            this.Controls.Add(this.lblArtista);
            this.Controls.Add(this.lblTituloCancion);
            this.Controls.Add(this.imgCancion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCancion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgCancion;
        private System.Windows.Forms.Label lblTituloCancion;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.ProgressBar pbCancion;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAdelantar;
    }
}

