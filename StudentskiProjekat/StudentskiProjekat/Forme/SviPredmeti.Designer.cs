namespace StudentskiProjekat.Forme
{
    partial class SviPredmeti
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
            this.brojpredmetaLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ObrisiB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spisak = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.izmeniPb = new System.Windows.Forms.Button();
            this.dodajPb = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // brojpredmetaLab
            // 
            this.brojpredmetaLab.AutoSize = true;
            this.brojpredmetaLab.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brojpredmetaLab.ForeColor = System.Drawing.Color.BlueViolet;
            this.brojpredmetaLab.Location = new System.Drawing.Point(658, 401);
            this.brojpredmetaLab.Name = "brojpredmetaLab";
            this.brojpredmetaLab.Size = new System.Drawing.Size(21, 21);
            this.brojpredmetaLab.TabIndex = 7;
            this.brojpredmetaLab.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(605, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "BROJ PREDMETA";
            // 
            // ObrisiB
            // 
            this.ObrisiB.BackColor = System.Drawing.Color.BlueViolet;
            this.ObrisiB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObrisiB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObrisiB.ForeColor = System.Drawing.SystemColors.Control;
            this.ObrisiB.Location = new System.Drawing.Point(580, 207);
            this.ObrisiB.Name = "ObrisiB";
            this.ObrisiB.Size = new System.Drawing.Size(172, 52);
            this.ObrisiB.TabIndex = 5;
            this.ObrisiB.Text = "OBRISI PREDMET";
            this.ObrisiB.UseVisualStyleBackColor = false;
            this.ObrisiB.Click += new System.EventHandler(this.ObrisiB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spisak);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 385);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SPISAK PREDMETA";
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
            this.spisak.Location = new System.Drawing.Point(3, 23);
            this.spisak.Name = "spisak";
            this.spisak.Size = new System.Drawing.Size(498, 359);
            this.spisak.TabIndex = 0;
            this.spisak.UseCompatibleStateImageBehavior = false;
            this.spisak.View = System.Windows.Forms.View.Details;
            this.spisak.SelectedIndexChanged += new System.EventHandler(this.spisak_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sifra";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Predmet";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Semestar";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Katedra";
            this.columnHeader4.Width = 130;
            // 
            // izmeniPb
            // 
            this.izmeniPb.BackColor = System.Drawing.Color.BlueViolet;
            this.izmeniPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmeniPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izmeniPb.ForeColor = System.Drawing.SystemColors.Control;
            this.izmeniPb.Location = new System.Drawing.Point(580, 136);
            this.izmeniPb.Name = "izmeniPb";
            this.izmeniPb.Size = new System.Drawing.Size(172, 52);
            this.izmeniPb.TabIndex = 8;
            this.izmeniPb.Text = "IZMENI PREDMET";
            this.izmeniPb.UseVisualStyleBackColor = false;
            this.izmeniPb.Click += new System.EventHandler(this.izmeniPb_Click);
            // 
            // dodajPb
            // 
            this.dodajPb.BackColor = System.Drawing.Color.BlueViolet;
            this.dodajPb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajPb.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajPb.ForeColor = System.Drawing.SystemColors.Control;
            this.dodajPb.Location = new System.Drawing.Point(580, 61);
            this.dodajPb.Name = "dodajPb";
            this.dodajPb.Size = new System.Drawing.Size(172, 52);
            this.dodajPb.TabIndex = 9;
            this.dodajPb.Text = "DODAJ PREDMET";
            this.dodajPb.UseVisualStyleBackColor = false;
            this.dodajPb.Click += new System.EventHandler(this.dodajPb_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(580, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "PROFESORI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SviPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dodajPb);
            this.Controls.Add(this.izmeniPb);
            this.Controls.Add(this.brojpredmetaLab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObrisiB);
            this.Controls.Add(this.groupBox1);
            this.Name = "SviPredmeti";
            this.Text = "SviPredmeti";
            this.Load += new System.EventHandler(this.SviPredmeti_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label brojpredmetaLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ObrisiB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView spisak;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button izmeniPb;
        private System.Windows.Forms.Button dodajPb;
        private System.Windows.Forms.Button button1;
    }
}