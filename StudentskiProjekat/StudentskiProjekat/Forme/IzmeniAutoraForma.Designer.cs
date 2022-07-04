namespace StudentskiProjekat.Forme
{
    partial class IzmeniAutoraForma
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
            this.ImeBox = new System.Windows.Forms.TextBox();
            this.ime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodajPb
            // 
            this.dodajPb.BackColor = System.Drawing.Color.BlueViolet;
            this.dodajPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajPb.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajPb.Location = new System.Drawing.Point(63, 123);
            this.dodajPb.Name = "dodajPb";
            this.dodajPb.Size = new System.Drawing.Size(170, 52);
            this.dodajPb.TabIndex = 66;
            this.dodajPb.Text = "IZMENI AUTORA";
            this.dodajPb.UseVisualStyleBackColor = false;
            this.dodajPb.Click += new System.EventHandler(this.dodajPb_Click);
            // 
            // ImeBox
            // 
            this.ImeBox.Location = new System.Drawing.Point(63, 69);
            this.ImeBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImeBox.Name = "ImeBox";
            this.ImeBox.Size = new System.Drawing.Size(170, 29);
            this.ImeBox.TabIndex = 65;
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Location = new System.Drawing.Point(57, 36);
            this.ime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(103, 19);
            this.ime.TabIndex = 64;
            this.ime.Text = "Ime i Prezime";
            // 
            // IzmeniAutoraForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 211);
            this.Controls.Add(this.dodajPb);
            this.Controls.Add(this.ImeBox);
            this.Controls.Add(this.ime);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IzmeniAutoraForma";
            this.Text = "IzmeniAutoraForma";
            this.Load += new System.EventHandler(this.IzmeniAutoraForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajPb;
        private System.Windows.Forms.TextBox ImeBox;
        private System.Windows.Forms.Label ime;
    }
}