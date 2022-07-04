namespace StudentskiProjekat.Forme
{
    partial class IzmeniPredmetForma
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
            this.label5 = new System.Windows.Forms.Label();
            this.KatedBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imeBox = new System.Windows.Forms.TextBox();
            this.imePred = new System.Windows.Forms.Label();
            this.sifrabox = new System.Windows.Forms.TextBox();
            this.SemNum = new System.Windows.Forms.NumericUpDown();
            this.sifral = new System.Windows.Forms.Label();
            this.izmeniPb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SemNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Semestar";
            // 
            // KatedBox
            // 
            this.KatedBox.Location = new System.Drawing.Point(45, 308);
            this.KatedBox.Margin = new System.Windows.Forms.Padding(4);
            this.KatedBox.Name = "KatedBox";
            this.KatedBox.Size = new System.Drawing.Size(173, 29);
            this.KatedBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 276);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Katedra";
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(45, 140);
            this.imeBox.Margin = new System.Windows.Forms.Padding(4);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(170, 29);
            this.imeBox.TabIndex = 15;
            // 
            // imePred
            // 
            this.imePred.AutoSize = true;
            this.imePred.Location = new System.Drawing.Point(39, 108);
            this.imePred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imePred.Name = "imePred";
            this.imePred.Size = new System.Drawing.Size(35, 19);
            this.imePred.TabIndex = 14;
            this.imePred.Text = "Ime";
            // 
            // sifrabox
            // 
            this.sifrabox.Location = new System.Drawing.Point(45, 59);
            this.sifrabox.Margin = new System.Windows.Forms.Padding(4);
            this.sifrabox.Name = "sifrabox";
            this.sifrabox.Size = new System.Drawing.Size(170, 29);
            this.sifrabox.TabIndex = 13;
            // 
            // SemNum
            // 
            this.SemNum.Location = new System.Drawing.Point(45, 230);
            this.SemNum.Margin = new System.Windows.Forms.Padding(4);
            this.SemNum.Name = "SemNum";
            this.SemNum.Size = new System.Drawing.Size(170, 29);
            this.SemNum.TabIndex = 12;
            // 
            // sifral
            // 
            this.sifral.AutoSize = true;
            this.sifral.Location = new System.Drawing.Point(39, 26);
            this.sifral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifral.Name = "sifral";
            this.sifral.Size = new System.Drawing.Size(41, 19);
            this.sifral.TabIndex = 11;
            this.sifral.Text = "Sifra";
            // 
            // izmeniPb
            // 
            this.izmeniPb.BackColor = System.Drawing.Color.BlueViolet;
            this.izmeniPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmeniPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izmeniPb.ForeColor = System.Drawing.SystemColors.Control;
            this.izmeniPb.Location = new System.Drawing.Point(45, 362);
            this.izmeniPb.Name = "izmeniPb";
            this.izmeniPb.Size = new System.Drawing.Size(170, 52);
            this.izmeniPb.TabIndex = 19;
            this.izmeniPb.Text = "IZMENI PREDMET";
            this.izmeniPb.UseVisualStyleBackColor = false;
            this.izmeniPb.Click += new System.EventHandler(this.izmeniPb_Click);
            // 
            // IzmeniPredmetForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 457);
            this.Controls.Add(this.izmeniPb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KatedBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imeBox);
            this.Controls.Add(this.imePred);
            this.Controls.Add(this.sifrabox);
            this.Controls.Add(this.SemNum);
            this.Controls.Add(this.sifral);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IzmeniPredmetForma";
            this.Text = "IzmeniPredmetForma";
            this.Load += new System.EventHandler(this.IzmeniPredmetForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SemNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox KatedBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.Label imePred;
        private System.Windows.Forms.TextBox sifrabox;
        private System.Windows.Forms.NumericUpDown SemNum;
        private System.Windows.Forms.Label sifral;
        private System.Windows.Forms.Button izmeniPb;
    }
}