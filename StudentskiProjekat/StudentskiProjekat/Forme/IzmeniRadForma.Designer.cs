namespace StudentskiProjekat.Forme
{
    partial class IzmeniRadForma
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
            this.FormatBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AdresaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dodajPb = new System.Windows.Forms.Button();
            this.KofBox = new System.Windows.Forms.TextBox();
            this.imePred = new System.Windows.Forms.Label();
            this.NazivBox = new System.Windows.Forms.TextBox();
            this.sifral = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormatBox
            // 
            this.FormatBox.Location = new System.Drawing.Point(278, 159);
            this.FormatBox.Margin = new System.Windows.Forms.Padding(4);
            this.FormatBox.Name = "FormatBox";
            this.FormatBox.Size = new System.Drawing.Size(170, 29);
            this.FormatBox.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 103;
            this.label1.Text = "Format";
            // 
            // AdresaBox
            // 
            this.AdresaBox.Location = new System.Drawing.Point(278, 78);
            this.AdresaBox.Margin = new System.Windows.Forms.Padding(4);
            this.AdresaBox.Name = "AdresaBox";
            this.AdresaBox.Size = new System.Drawing.Size(170, 29);
            this.AdresaBox.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 101;
            this.label2.Text = "Adresa";
            // 
            // dodajPb
            // 
            this.dodajPb.BackColor = System.Drawing.Color.BlueViolet;
            this.dodajPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajPb.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajPb.Location = new System.Drawing.Point(178, 222);
            this.dodajPb.Name = "dodajPb";
            this.dodajPb.Size = new System.Drawing.Size(170, 52);
            this.dodajPb.TabIndex = 100;
            this.dodajPb.Text = "IZMENI RAD";
            this.dodajPb.UseVisualStyleBackColor = false;
            this.dodajPb.Click += new System.EventHandler(this.dodajPb_Click);
            // 
            // KofBox
            // 
            this.KofBox.Location = new System.Drawing.Point(59, 159);
            this.KofBox.Margin = new System.Windows.Forms.Padding(4);
            this.KofBox.Name = "KofBox";
            this.KofBox.Size = new System.Drawing.Size(170, 29);
            this.KofBox.TabIndex = 99;
            // 
            // imePred
            // 
            this.imePred.AutoSize = true;
            this.imePred.Location = new System.Drawing.Point(53, 127);
            this.imePred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imePred.Name = "imePred";
            this.imePred.Size = new System.Drawing.Size(95, 19);
            this.imePred.TabIndex = 98;
            this.imePred.Text = "Konferencija";
            // 
            // NazivBox
            // 
            this.NazivBox.Location = new System.Drawing.Point(59, 78);
            this.NazivBox.Margin = new System.Windows.Forms.Padding(4);
            this.NazivBox.Name = "NazivBox";
            this.NazivBox.Size = new System.Drawing.Size(170, 29);
            this.NazivBox.TabIndex = 97;
            // 
            // sifral
            // 
            this.sifral.AutoSize = true;
            this.sifral.Location = new System.Drawing.Point(53, 45);
            this.sifral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifral.Name = "sifral";
            this.sifral.Size = new System.Drawing.Size(48, 19);
            this.sifral.TabIndex = 96;
            this.sifral.Text = "Naziv";
            // 
            // IzmeniRadForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 312);
            this.Controls.Add(this.FormatBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdresaBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dodajPb);
            this.Controls.Add(this.KofBox);
            this.Controls.Add(this.imePred);
            this.Controls.Add(this.NazivBox);
            this.Controls.Add(this.sifral);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IzmeniRadForma";
            this.Text = "God";
            this.Load += new System.EventHandler(this.IzmeniRadForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FormatBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdresaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dodajPb;
        private System.Windows.Forms.TextBox KofBox;
        private System.Windows.Forms.Label imePred;
        private System.Windows.Forms.TextBox NazivBox;
        private System.Windows.Forms.Label sifral;
    }
}