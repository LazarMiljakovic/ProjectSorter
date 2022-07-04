namespace StudentskiProjekat.Forme
{
    partial class StudentiNaProjektuForma
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dodajOdnosSP = new System.Windows.Forms.Button();
            this.obrisiSP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spisak = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dodajOdnosSP);
            this.groupBox3.Controls.Add(this.obrisiSP);
            this.groupBox3.Location = new System.Drawing.Point(562, 35);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(215, 161);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STUDENTI";
            // 
            // dodajOdnosSP
            // 
            this.dodajOdnosSP.BackColor = System.Drawing.Color.BlueViolet;
            this.dodajOdnosSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajOdnosSP.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajOdnosSP.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajOdnosSP.Location = new System.Drawing.Point(19, 22);
            this.dodajOdnosSP.Margin = new System.Windows.Forms.Padding(4);
            this.dodajOdnosSP.Name = "dodajOdnosSP";
            this.dodajOdnosSP.Size = new System.Drawing.Size(177, 57);
            this.dodajOdnosSP.TabIndex = 12;
            this.dodajOdnosSP.Text = "DODAJ STUDENTA NA PROJEKAT";
            this.dodajOdnosSP.UseVisualStyleBackColor = false;
            this.dodajOdnosSP.Click += new System.EventHandler(this.dodajSP_Click);
            // 
            // obrisiSP
            // 
            this.obrisiSP.BackColor = System.Drawing.Color.BlueViolet;
            this.obrisiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.obrisiSP.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obrisiSP.ForeColor = System.Drawing.SystemColors.Control;
            this.obrisiSP.Location = new System.Drawing.Point(19, 87);
            this.obrisiSP.Margin = new System.Windows.Forms.Padding(4);
            this.obrisiSP.Name = "obrisiSP";
            this.obrisiSP.Size = new System.Drawing.Size(177, 57);
            this.obrisiSP.TabIndex = 10;
            this.obrisiSP.Text = "OBRISI STUDENTA SA PROJEKAT";
            this.obrisiSP.UseVisualStyleBackColor = false;
            this.obrisiSP.Click += new System.EventHandler(this.obrisiSP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spisak);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 385);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SPISAK STUDENATA";
            // 
            // spisak
            // 
            this.spisak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.spisak.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.spisak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spisak.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spisak.FullRowSelect = true;
            this.spisak.GridLines = true;
            this.spisak.HideSelection = false;
            this.spisak.Location = new System.Drawing.Point(3, 23);
            this.spisak.Name = "spisak";
            this.spisak.Size = new System.Drawing.Size(525, 359);
            this.spisak.TabIndex = 0;
            this.spisak.UseCompatibleStateImageBehavior = false;
            this.spisak.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Indeks";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ime roditelja";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezime";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Smer";
            // 
            // StudentiNaProjektuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentiNaProjektuForma";
            this.Text = "StudentiNaProjektuForma";
            this.Load += new System.EventHandler(this.StudentiNaProjektuForma_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button dodajOdnosSP;
        private System.Windows.Forms.Button obrisiSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView spisak;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}