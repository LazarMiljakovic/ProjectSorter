namespace StudentskiProjekat.Forme
{
    partial class IzmeniProfesoraForma
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
            this.dodajPb = new System.Windows.Forms.Button();
            this.sifrabox = new System.Windows.Forms.TextBox();
            this.sifral = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodajPb
            // 
            this.dodajPb.BackColor = System.Drawing.Color.BlueViolet;
            this.dodajPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajPb.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajPb.Location = new System.Drawing.Point(64, 126);
            this.dodajPb.Name = "dodajPb";
            this.dodajPb.Size = new System.Drawing.Size(170, 52);
            this.dodajPb.TabIndex = 66;
            this.dodajPb.Text = "IZMENI PROFESORA";
            this.dodajPb.UseVisualStyleBackColor = false;
            this.dodajPb.Click += new System.EventHandler(this.dodajPb_Click);
            // 
            // sifrabox
            // 
            this.sifrabox.Location = new System.Drawing.Point(64, 72);
            this.sifrabox.Margin = new System.Windows.Forms.Padding(4);
            this.sifrabox.Name = "sifrabox";
            this.sifrabox.Size = new System.Drawing.Size(170, 29);
            this.sifrabox.TabIndex = 65;
            // 
            // sifral
            // 
            this.sifral.AutoSize = true;
            this.sifral.Location = new System.Drawing.Point(58, 39);
            this.sifral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifral.Name = "sifral";
            this.sifral.Size = new System.Drawing.Size(103, 19);
            this.sifral.TabIndex = 64;
            this.sifral.Text = "Ime i Prezime";
            // 
            // IzmeniProfesoraForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 219);
            this.Controls.Add(this.dodajPb);
            this.Controls.Add(this.sifrabox);
            this.Controls.Add(this.sifral);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IzmeniProfesoraForma";
            this.Text = "IzmeniProfesoraForma";
            this.Load += new System.EventHandler(this.IzmeniProfesoraForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajPb;
        private System.Windows.Forms.TextBox sifrabox;
        private System.Windows.Forms.Label sifral;
    }
}