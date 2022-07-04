namespace StudentskiProjekat.Forme
{
    partial class IzmeniIzvestajForma
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
            this.imeBox = new System.Windows.Forms.TextBox();
            this.imePred = new System.Windows.Forms.Label();
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
            this.dodajPb.Location = new System.Drawing.Point(75, 233);
            this.dodajPb.Name = "dodajPb";
            this.dodajPb.Size = new System.Drawing.Size(170, 52);
            this.dodajPb.TabIndex = 55;
            this.dodajPb.Text = "DODAJ IZVESTAJ";
            this.dodajPb.UseVisualStyleBackColor = false;
            this.dodajPb.Click += new System.EventHandler(this.dodajPb_Click);
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(75, 157);
            this.imeBox.Margin = new System.Windows.Forms.Padding(4);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(170, 29);
            this.imeBox.TabIndex = 54;
            // 
            // imePred
            // 
            this.imePred.AutoSize = true;
            this.imePred.Location = new System.Drawing.Point(69, 125);
            this.imePred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imePred.Name = "imePred";
            this.imePred.Size = new System.Drawing.Size(99, 19);
            this.imePred.TabIndex = 53;
            this.imePred.Text = "Odnosi se na";
            // 
            // sifrabox
            // 
            this.sifrabox.Location = new System.Drawing.Point(75, 76);
            this.sifrabox.Margin = new System.Windows.Forms.Padding(4);
            this.sifrabox.Name = "sifrabox";
            this.sifrabox.Size = new System.Drawing.Size(170, 29);
            this.sifrabox.TabIndex = 52;
            // 
            // sifral
            // 
            this.sifral.AutoSize = true;
            this.sifral.Location = new System.Drawing.Point(69, 43);
            this.sifral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifral.Name = "sifral";
            this.sifral.Size = new System.Drawing.Size(60, 19);
            this.sifral.TabIndex = 51;
            this.sifral.Text = "Sadrzaj";
            // 
            // IzmeniIzvestajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 343);
            this.Controls.Add(this.dodajPb);
            this.Controls.Add(this.imeBox);
            this.Controls.Add(this.imePred);
            this.Controls.Add(this.sifrabox);
            this.Controls.Add(this.sifral);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IzmeniIzvestajForma";
            this.Text = "IzmeniIzvestajForma";
            this.Load += new System.EventHandler(this.IzmeniIzvestajForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajPb;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.Label imePred;
        private System.Windows.Forms.TextBox sifrabox;
        private System.Windows.Forms.Label sifral;
    }
}