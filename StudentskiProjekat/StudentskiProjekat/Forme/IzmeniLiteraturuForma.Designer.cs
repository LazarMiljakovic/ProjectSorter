namespace StudentskiProjekat.Forme
{
    partial class IzmeniLiteraturuForma
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
            this.Zavrsi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dodajPb = new System.Windows.Forms.Button();
            this.izmeniPb = new System.Windows.Forms.Button();
            this.ObrisiB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spisak = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autori = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zavrsi
            // 
            this.Zavrsi.BackColor = System.Drawing.Color.BlueViolet;
            this.Zavrsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zavrsi.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zavrsi.ForeColor = System.Drawing.SystemColors.Control;
            this.Zavrsi.Location = new System.Drawing.Point(324, 392);
            this.Zavrsi.Margin = new System.Windows.Forms.Padding(4);
            this.Zavrsi.Name = "Zavrsi";
            this.Zavrsi.Size = new System.Drawing.Size(177, 57);
            this.Zavrsi.TabIndex = 28;
            this.Zavrsi.Text = "IZMENI SPISAK";
            this.Zavrsi.UseVisualStyleBackColor = false;
            this.Zavrsi.Click += new System.EventHandler(this.Zavrsi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dodajPb);
            this.groupBox2.Controls.Add(this.izmeniPb);
            this.groupBox2.Controls.Add(this.ObrisiB);
            this.groupBox2.Location = new System.Drawing.Point(305, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(215, 226);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LITERATURA";
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
            this.dodajPb.Text = "DODAJ LITERATURU";
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
            this.izmeniPb.Text = "IZMENI LITERATURU";
            this.izmeniPb.UseVisualStyleBackColor = false;
            this.izmeniPb.Click += new System.EventHandler(this.izmeniPb_Click);
            // 
            // ObrisiB
            // 
            this.ObrisiB.BackColor = System.Drawing.Color.BlueViolet;
            this.ObrisiB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ObrisiB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObrisiB.ForeColor = System.Drawing.SystemColors.Control;
            this.ObrisiB.Location = new System.Drawing.Point(19, 152);
            this.ObrisiB.Margin = new System.Windows.Forms.Padding(4);
            this.ObrisiB.Name = "ObrisiB";
            this.ObrisiB.Size = new System.Drawing.Size(177, 57);
            this.ObrisiB.TabIndex = 10;
            this.ObrisiB.Text = "OBRISI LITERATURU";
            this.ObrisiB.UseVisualStyleBackColor = false;
            this.ObrisiB.Click += new System.EventHandler(this.ObrisiB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.spisak);
            this.groupBox1.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(273, 440);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SPISAK LITERATURE";
            // 
            // spisak
            // 
            this.spisak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(254)))));
            this.spisak.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.spisak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spisak.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spisak.FullRowSelect = true;
            this.spisak.GridLines = true;
            this.spisak.HideSelection = false;
            this.spisak.Location = new System.Drawing.Point(4, 24);
            this.spisak.Margin = new System.Windows.Forms.Padding(4);
            this.spisak.Name = "spisak";
            this.spisak.Size = new System.Drawing.Size(265, 412);
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
            this.columnHeader2.Text = "Naziv Literature";
            this.columnHeader2.Width = 160;
            // 
            // Autori
            // 
            this.Autori.BackColor = System.Drawing.Color.BlueViolet;
            this.Autori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Autori.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autori.ForeColor = System.Drawing.SystemColors.Control;
            this.Autori.Location = new System.Drawing.Point(324, 282);
            this.Autori.Margin = new System.Windows.Forms.Padding(4);
            this.Autori.Name = "Autori";
            this.Autori.Size = new System.Drawing.Size(177, 57);
            this.Autori.TabIndex = 29;
            this.Autori.Text = "IZMENI AUTORE";
            this.Autori.UseVisualStyleBackColor = false;
            this.Autori.Click += new System.EventHandler(this.Autori_Click);
            // 
            // IzmeniLiteraturuForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 468);
            this.Controls.Add(this.Autori);
            this.Controls.Add(this.Zavrsi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "IzmeniLiteraturuForma";
            this.Text = "IzmeniLiteraturuForma";
            this.Load += new System.EventHandler(this.IzmeniLiteraturuForma_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Zavrsi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dodajPb;
        private System.Windows.Forms.Button izmeniPb;
        private System.Windows.Forms.Button ObrisiB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView spisak;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Autori;
    }
}