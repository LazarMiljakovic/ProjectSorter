namespace StudentskiProjekat.Forme
{
    partial class IzmeniKnjiguForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dodajPb = new System.Windows.Forms.Button();
            this.imePred = new System.Windows.Forms.Label();
            this.sifral = new System.Windows.Forms.Label();
            this.FormatBox = new System.Windows.Forms.TextBox();
            this.AdresaBox = new System.Windows.Forms.TextBox();
            this.KofBox = new System.Windows.Forms.TextBox();
            this.NazivBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 94;
            this.label1.Text = "GodinaIzdanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 92;
            this.label2.Text = "ISBN";
            // 
            // dodajPb
            // 
            this.dodajPb.BackColor = System.Drawing.Color.BlueViolet;
            this.dodajPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajPb.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajPb.Location = new System.Drawing.Point(183, 211);
            this.dodajPb.Name = "dodajPb";
            this.dodajPb.Size = new System.Drawing.Size(170, 52);
            this.dodajPb.TabIndex = 91;
            this.dodajPb.Text = "IZMENI KNJIGU";
            this.dodajPb.UseVisualStyleBackColor = false;
            this.dodajPb.Click += new System.EventHandler(this.dodajPb_Click);
            // 
            // imePred
            // 
            this.imePred.AutoSize = true;
            this.imePred.Location = new System.Drawing.Point(58, 116);
            this.imePred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imePred.Name = "imePred";
            this.imePred.Size = new System.Drawing.Size(60, 19);
            this.imePred.TabIndex = 89;
            this.imePred.Text = "Izdavac";
            // 
            // sifral
            // 
            this.sifral.AutoSize = true;
            this.sifral.Location = new System.Drawing.Point(58, 34);
            this.sifral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifral.Name = "sifral";
            this.sifral.Size = new System.Drawing.Size(48, 19);
            this.sifral.TabIndex = 87;
            this.sifral.Text = "Naziv";
            // 
            // FormatBox
            // 
            this.FormatBox.Location = new System.Drawing.Point(281, 148);
            this.FormatBox.Margin = new System.Windows.Forms.Padding(4);
            this.FormatBox.Name = "FormatBox";
            this.FormatBox.Size = new System.Drawing.Size(170, 29);
            this.FormatBox.TabIndex = 108;
            // 
            // AdresaBox
            // 
            this.AdresaBox.Location = new System.Drawing.Point(281, 67);
            this.AdresaBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdresaBox.Name = "AdresaBox";
            this.AdresaBox.Size = new System.Drawing.Size(170, 29);
            this.AdresaBox.TabIndex = 107;
            // 
            // KofBox
            // 
            this.KofBox.Location = new System.Drawing.Point(62, 148);
            this.KofBox.Margin = new System.Windows.Forms.Padding(4);
            this.KofBox.Name = "KofBox";
            this.KofBox.Size = new System.Drawing.Size(170, 29);
            this.KofBox.TabIndex = 106;
            // 
            // NazivBox
            // 
            this.NazivBox.Location = new System.Drawing.Point(62, 67);
            this.NazivBox.Margin = new System.Windows.Forms.Padding(4);
            this.NazivBox.Name = "NazivBox";
            this.NazivBox.Size = new System.Drawing.Size(170, 29);
            this.NazivBox.TabIndex = 105;
            // 
            // IzmeniKnjiguForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 297);
            this.Controls.Add(this.FormatBox);
            this.Controls.Add(this.AdresaBox);
            this.Controls.Add(this.KofBox);
            this.Controls.Add(this.NazivBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dodajPb);
            this.Controls.Add(this.imePred);
            this.Controls.Add(this.sifral);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IzmeniKnjiguForma";
            this.Text = "IzmeniKnjiguForma";
            this.Load += new System.EventHandler(this.IzmeniKnjiguForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dodajPb;
        private System.Windows.Forms.Label imePred;
        private System.Windows.Forms.Label sifral;
        private System.Windows.Forms.TextBox FormatBox;
        private System.Windows.Forms.TextBox AdresaBox;
        private System.Windows.Forms.TextBox KofBox;
        private System.Windows.Forms.TextBox NazivBox;
    }
}