namespace StudentskiProjekat.Forme
{
    partial class DodajPredmetForma
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
            this.label5 = new System.Windows.Forms.Label();
            this.KatedBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.imeBox = new System.Windows.Forms.TextBox();
            this.imePred = new System.Windows.Forms.Label();
            this.sifrabox = new System.Windows.Forms.TextBox();
            this.SemNum = new System.Windows.Forms.NumericUpDown();
            this.sifral = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SemNum)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajPb
            // 
            this.dodajPb.BackColor = System.Drawing.Color.BlueViolet;
            this.dodajPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajPb.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajPb.Location = new System.Drawing.Point(39, 352);
            this.dodajPb.Name = "dodajPb";
            this.dodajPb.Size = new System.Drawing.Size(170, 52);
            this.dodajPb.TabIndex = 28;
            this.dodajPb.Text = "DODAJ PREDMET";
            this.dodajPb.UseVisualStyleBackColor = false;
            this.dodajPb.Click += new System.EventHandler(this.dodajPb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Semestar";
            // 
            // KatedBox
            // 
            this.KatedBox.Location = new System.Drawing.Point(39, 298);
            this.KatedBox.Margin = new System.Windows.Forms.Padding(4);
            this.KatedBox.Name = "KatedBox";
            this.KatedBox.Size = new System.Drawing.Size(173, 29);
            this.KatedBox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Katedra";
            // 
            // imeBox
            // 
            this.imeBox.Location = new System.Drawing.Point(39, 130);
            this.imeBox.Margin = new System.Windows.Forms.Padding(4);
            this.imeBox.Name = "imeBox";
            this.imeBox.Size = new System.Drawing.Size(170, 29);
            this.imeBox.TabIndex = 24;
            // 
            // imePred
            // 
            this.imePred.AutoSize = true;
            this.imePred.Location = new System.Drawing.Point(33, 98);
            this.imePred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imePred.Name = "imePred";
            this.imePred.Size = new System.Drawing.Size(35, 19);
            this.imePred.TabIndex = 23;
            this.imePred.Text = "Ime";
            // 
            // sifrabox
            // 
            this.sifrabox.Location = new System.Drawing.Point(39, 49);
            this.sifrabox.Margin = new System.Windows.Forms.Padding(4);
            this.sifrabox.Name = "sifrabox";
            this.sifrabox.Size = new System.Drawing.Size(170, 29);
            this.sifrabox.TabIndex = 22;
            // 
            // SemNum
            // 
            this.SemNum.Location = new System.Drawing.Point(39, 220);
            this.SemNum.Margin = new System.Windows.Forms.Padding(4);
            this.SemNum.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.SemNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SemNum.Name = "SemNum";
            this.SemNum.Size = new System.Drawing.Size(170, 29);
            this.SemNum.TabIndex = 21;
            this.SemNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sifral
            // 
            this.sifral.AutoSize = true;
            this.sifral.Location = new System.Drawing.Point(33, 16);
            this.sifral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifral.Name = "sifral";
            this.sifral.Size = new System.Drawing.Size(41, 19);
            this.sifral.TabIndex = 20;
            this.sifral.Text = "Sifra";
            // 
            // DodajPredmetForma
            // 
            this.ClientSize = new System.Drawing.Size(261, 433);
            this.Controls.Add(this.dodajPb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KatedBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imeBox);
            this.Controls.Add(this.imePred);
            this.Controls.Add(this.sifrabox);
            this.Controls.Add(this.SemNum);
            this.Controls.Add(this.sifral);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DodajPredmetForma";
            this.Load += new System.EventHandler(this.DodajPredmetForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SemNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button dodajPb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox KatedBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imeBox;
        private System.Windows.Forms.Label imePred;
        private System.Windows.Forms.TextBox sifrabox;
        private System.Windows.Forms.NumericUpDown SemNum;
        private System.Windows.Forms.Label sifral;
    }
}