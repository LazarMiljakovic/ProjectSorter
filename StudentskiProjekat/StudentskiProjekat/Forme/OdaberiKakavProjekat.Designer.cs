namespace StudentskiProjekat.Forme
{
    partial class OdaberiKakavProjekat
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
            this.pojR = new System.Windows.Forms.RadioButton();
            this.grupCheck = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TeoCheck = new System.Windows.Forms.RadioButton();
            this.PrakCheck = new System.Windows.Forms.RadioButton();
            this.dodajPb = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pojR
            // 
            this.pojR.AutoSize = true;
            this.pojR.Location = new System.Drawing.Point(6, 42);
            this.pojR.Name = "pojR";
            this.pojR.Size = new System.Drawing.Size(107, 23);
            this.pojR.TabIndex = 0;
            this.pojR.TabStop = true;
            this.pojR.Text = "Pojedinacni";
            this.pojR.UseVisualStyleBackColor = true;
            // 
            // grupCheck
            // 
            this.grupCheck.AutoSize = true;
            this.grupCheck.Location = new System.Drawing.Point(227, 42);
            this.grupCheck.Name = "grupCheck";
            this.grupCheck.Size = new System.Drawing.Size(75, 23);
            this.grupCheck.TabIndex = 1;
            this.grupCheck.TabStop = true;
            this.grupCheck.Text = "Grupni";
            this.grupCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grupCheck);
            this.groupBox1.Controls.Add(this.pojR);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izaberi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TeoCheck);
            this.groupBox2.Controls.Add(this.PrakCheck);
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 110);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izaberi";
            // 
            // TeoCheck
            // 
            this.TeoCheck.AutoSize = true;
            this.TeoCheck.Location = new System.Drawing.Point(227, 42);
            this.TeoCheck.Name = "TeoCheck";
            this.TeoCheck.Size = new System.Drawing.Size(85, 23);
            this.TeoCheck.TabIndex = 1;
            this.TeoCheck.TabStop = true;
            this.TeoCheck.Text = "Teorijski";
            this.TeoCheck.UseVisualStyleBackColor = true;
            // 
            // PrakCheck
            // 
            this.PrakCheck.AutoSize = true;
            this.PrakCheck.Location = new System.Drawing.Point(6, 42);
            this.PrakCheck.Name = "PrakCheck";
            this.PrakCheck.Size = new System.Drawing.Size(87, 23);
            this.PrakCheck.TabIndex = 0;
            this.PrakCheck.TabStop = true;
            this.PrakCheck.Text = "Prakticni";
            this.PrakCheck.UseVisualStyleBackColor = true;
            // 
            // dodajPb
            // 
            this.dodajPb.BackColor = System.Drawing.Color.BlueViolet;
            this.dodajPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajPb.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajPb.Location = new System.Drawing.Point(99, 270);
            this.dodajPb.Margin = new System.Windows.Forms.Padding(4);
            this.dodajPb.Name = "dodajPb";
            this.dodajPb.Size = new System.Drawing.Size(177, 57);
            this.dodajPb.TabIndex = 13;
            this.dodajPb.Text = "DODAJ PROJEKAT";
            this.dodajPb.UseVisualStyleBackColor = false;
            this.dodajPb.Click += new System.EventHandler(this.dodajPb_Click);
            // 
            // OdaberiKakavProjekat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 340);
            this.Controls.Add(this.dodajPb);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OdaberiKakavProjekat";
            this.Text = "OdaberiKakavProjekat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton pojR;
        private System.Windows.Forms.RadioButton grupCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton TeoCheck;
        private System.Windows.Forms.RadioButton PrakCheck;
        private System.Windows.Forms.Button dodajPb;
    }
}