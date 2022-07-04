namespace StudentskiProjekat.Forme
{
    partial class IzaberiLIteraturu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.knjiga = new System.Windows.Forms.RadioButton();
            this.clanak = new System.Windows.Forms.RadioButton();
            this.rad = new System.Windows.Forms.RadioButton();
            this.dodajPb = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad);
            this.groupBox1.Controls.Add(this.knjiga);
            this.groupBox1.Controls.Add(this.clanak);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izaberi";
            // 
            // knjiga
            // 
            this.knjiga.AutoSize = true;
            this.knjiga.Location = new System.Drawing.Point(209, 42);
            this.knjiga.Name = "knjiga";
            this.knjiga.Size = new System.Drawing.Size(54, 17);
            this.knjiga.TabIndex = 1;
            this.knjiga.TabStop = true;
            this.knjiga.Text = "Knjiga";
            this.knjiga.UseVisualStyleBackColor = true;
            // 
            // clanak
            // 
            this.clanak.AutoSize = true;
            this.clanak.Location = new System.Drawing.Point(6, 42);
            this.clanak.Name = "clanak";
            this.clanak.Size = new System.Drawing.Size(58, 17);
            this.clanak.TabIndex = 0;
            this.clanak.TabStop = true;
            this.clanak.Text = "Clanak";
            this.clanak.UseVisualStyleBackColor = true;
            // 
            // rad
            // 
            this.rad.AutoSize = true;
            this.rad.Location = new System.Drawing.Point(408, 42);
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(45, 17);
            this.rad.TabIndex = 2;
            this.rad.TabStop = true;
            this.rad.Text = "Rad";
            this.rad.UseVisualStyleBackColor = true;
            // 
            // dodajPb
            // 
            this.dodajPb.BackColor = System.Drawing.Color.BlueViolet;
            this.dodajPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajPb.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajPb.Location = new System.Drawing.Point(162, 129);
            this.dodajPb.Margin = new System.Windows.Forms.Padding(4);
            this.dodajPb.Name = "dodajPb";
            this.dodajPb.Size = new System.Drawing.Size(177, 57);
            this.dodajPb.TabIndex = 13;
            this.dodajPb.Text = "DODAJ LITERATURU";
            this.dodajPb.UseVisualStyleBackColor = false;
            this.dodajPb.Click += new System.EventHandler(this.dodajPb_Click);
            // 
            // IzaberiLIteraturu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 198);
            this.Controls.Add(this.dodajPb);
            this.Controls.Add(this.groupBox1);
            this.Name = "IzaberiLIteraturu";
            this.Text = "IzaberiLIteraturu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad;
        private System.Windows.Forms.RadioButton knjiga;
        private System.Windows.Forms.RadioButton clanak;
        private System.Windows.Forms.Button dodajPb;
    }
}