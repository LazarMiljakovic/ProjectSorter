namespace StudentskiProjekat.Forme
{
    partial class UzeoPPPGForma
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dodajPb = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pjbox = new System.Windows.Forms.TextBox();
            this.imePred = new System.Windows.Forms.Label();
            this.izvestajboc = new System.Windows.Forms.TextBox();
            this.sifral = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 29);
            this.dateTimePicker1.TabIndex = 79;
            // 
            // dodajPb
            // 
            this.dodajPb.BackColor = System.Drawing.Color.BlueViolet;
            this.dodajPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajPb.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajPb.Location = new System.Drawing.Point(63, 292);
            this.dodajPb.Name = "dodajPb";
            this.dodajPb.Size = new System.Drawing.Size(170, 52);
            this.dodajPb.TabIndex = 78;
            this.dodajPb.Text = "DODAJ";
            this.dodajPb.UseVisualStyleBackColor = false;
            this.dodajPb.Click += new System.EventHandler(this.dodajPb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 77;
            this.label5.Text = "Datum";
            // 
            // pjbox
            // 
            this.pjbox.Location = new System.Drawing.Point(63, 143);
            this.pjbox.Margin = new System.Windows.Forms.Padding(4);
            this.pjbox.Name = "pjbox";
            this.pjbox.Size = new System.Drawing.Size(170, 29);
            this.pjbox.TabIndex = 76;
            // 
            // imePred
            // 
            this.imePred.AutoSize = true;
            this.imePred.Location = new System.Drawing.Point(57, 111);
            this.imePred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imePred.Name = "imePred";
            this.imePred.Size = new System.Drawing.Size(126, 19);
            this.imePred.TabIndex = 75;
            this.imePred.Text = "Programski Jezik";
            // 
            // izvestajboc
            // 
            this.izvestajboc.Location = new System.Drawing.Point(63, 62);
            this.izvestajboc.Margin = new System.Windows.Forms.Padding(4);
            this.izvestajboc.Name = "izvestajboc";
            this.izvestajboc.Size = new System.Drawing.Size(170, 29);
            this.izvestajboc.TabIndex = 74;
            // 
            // sifral
            // 
            this.sifral.AutoSize = true;
            this.sifral.Location = new System.Drawing.Point(57, 29);
            this.sifral.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sifral.Name = "sifral";
            this.sifral.Size = new System.Drawing.Size(60, 19);
            this.sifral.TabIndex = 73;
            this.sifral.Text = "Izvestaj";
            // 
            // UzeoPPPGForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 405);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dodajPb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pjbox);
            this.Controls.Add(this.imePred);
            this.Controls.Add(this.izvestajboc);
            this.Controls.Add(this.sifral);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UzeoPPPGForma";
            this.Text = "UzeoPPPGForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button dodajPb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pjbox;
        private System.Windows.Forms.Label imePred;
        private System.Windows.Forms.TextBox izvestajboc;
        private System.Windows.Forms.Label sifral;
    }
}