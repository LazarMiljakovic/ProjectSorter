namespace StudentskiProjekat.Forme
{
    partial class ProjektiForm
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
            this.spisak = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dodajPb = new System.Windows.Forms.Button();
            this.izmeniPb = new System.Windows.Forms.Button();
            this.ObrisiP = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PregledStudenata = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spisak);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(513, 465);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SPISAK PROJEKTA";
            // 
            // spisak
            // 
            this.spisak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.spisak.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.spisak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spisak.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spisak.FullRowSelect = true;
            this.spisak.GridLines = true;
            this.spisak.HideSelection = false;
            this.spisak.Location = new System.Drawing.Point(4, 24);
            this.spisak.Margin = new System.Windows.Forms.Padding(4);
            this.spisak.Name = "spisak";
            this.spisak.Size = new System.Drawing.Size(505, 437);
            this.spisak.TabIndex = 0;
            this.spisak.UseCompatibleStateImageBehavior = false;
            this.spisak.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pocetak";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Predmet";
            this.columnHeader4.Width = 130;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dodajPb);
            this.groupBox2.Controls.Add(this.izmeniPb);
            this.groupBox2.Controls.Add(this.ObrisiP);
            this.groupBox2.Location = new System.Drawing.Point(563, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(215, 226);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PROJEKAT";
            // 
            // dodajPb
            // 
            this.dodajPb.BackColor = System.Drawing.Color.BlueViolet;
            this.dodajPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajPb.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajPb.Location = new System.Drawing.Point(19, 22);
            this.dodajPb.Margin = new System.Windows.Forms.Padding(4);
            this.dodajPb.Name = "dodajPb";
            this.dodajPb.Size = new System.Drawing.Size(177, 57);
            this.dodajPb.TabIndex = 12;
            this.dodajPb.Text = "DODAJ PROJEKAT";
            this.dodajPb.UseVisualStyleBackColor = false;
            this.dodajPb.Click += new System.EventHandler(this.dodajPb_Click);
            // 
            // izmeniPb
            // 
            this.izmeniPb.BackColor = System.Drawing.Color.BlueViolet;
            this.izmeniPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmeniPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izmeniPb.ForeColor = System.Drawing.SystemColors.Control;
            this.izmeniPb.Location = new System.Drawing.Point(19, 87);
            this.izmeniPb.Margin = new System.Windows.Forms.Padding(4);
            this.izmeniPb.Name = "izmeniPb";
            this.izmeniPb.Size = new System.Drawing.Size(177, 57);
            this.izmeniPb.TabIndex = 11;
            this.izmeniPb.Text = "IZMENI PROJEKAT";
            this.izmeniPb.UseVisualStyleBackColor = false;
            this.izmeniPb.Click += new System.EventHandler(this.izmeniPb_Click);
            // 
            // ObrisiP
            // 
            this.ObrisiP.BackColor = System.Drawing.Color.BlueViolet;
            this.ObrisiP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObrisiP.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObrisiP.ForeColor = System.Drawing.SystemColors.Control;
            this.ObrisiP.Location = new System.Drawing.Point(19, 152);
            this.ObrisiP.Margin = new System.Windows.Forms.Padding(4);
            this.ObrisiP.Name = "ObrisiP";
            this.ObrisiP.Size = new System.Drawing.Size(177, 57);
            this.ObrisiP.TabIndex = 10;
            this.ObrisiP.Text = "OBRISI PROJEKAT";
            this.ObrisiP.UseVisualStyleBackColor = false;
            this.ObrisiP.Click += new System.EventHandler(this.ObrisiP_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PregledStudenata);
            this.groupBox3.Location = new System.Drawing.Point(563, 400);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(215, 99);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STUDENTI";
            // 
            // PregledStudenata
            // 
            this.PregledStudenata.BackColor = System.Drawing.Color.BlueViolet;
            this.PregledStudenata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PregledStudenata.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PregledStudenata.ForeColor = System.Drawing.SystemColors.Control;
            this.PregledStudenata.Location = new System.Drawing.Point(19, 28);
            this.PregledStudenata.Margin = new System.Windows.Forms.Padding(4);
            this.PregledStudenata.Name = "PregledStudenata";
            this.PregledStudenata.Size = new System.Drawing.Size(177, 57);
            this.PregledStudenata.TabIndex = 12;
            this.PregledStudenata.Text = "PREGLED";
            this.PregledStudenata.UseVisualStyleBackColor = false;
            this.PregledStudenata.Click += new System.EventHandler(this.PregledStudenata_Click);
            // 
            // ProjektiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 543);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProjektiForm";
            this.Text = "ProjektiForm";
            this.Load += new System.EventHandler(this.ProjektiForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView spisak;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dodajPb;
        private System.Windows.Forms.Button izmeniPb;
        private System.Windows.Forms.Button ObrisiP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PregledStudenata;
    }
}