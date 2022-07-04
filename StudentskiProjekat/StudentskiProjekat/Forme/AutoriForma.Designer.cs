namespace StudentskiProjekat.Forme
{
    partial class AutoriForma
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dodajPb = new System.Windows.Forms.Button();
            this.izmeniPb = new System.Windows.Forms.Button();
            this.ObrisiB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spisak = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(372, 392);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 57);
            this.button1.TabIndex = 32;
            this.button1.Text = "IZADJI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dodajPb);
            this.groupBox2.Controls.Add(this.izmeniPb);
            this.groupBox2.Controls.Add(this.ObrisiB);
            this.groupBox2.Location = new System.Drawing.Point(353, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(215, 226);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AUTOR";
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
            this.dodajPb.Text = "DODAJ AUTORA";
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
            this.izmeniPb.Text = "IZMENI AUTORA";
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
            this.ObrisiB.Text = "OBRISI AUTORA";
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
            this.groupBox1.Size = new System.Drawing.Size(295, 440);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SPISAK AUTORA LITERATURE";
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
            this.spisak.Size = new System.Drawing.Size(287, 412);
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
            this.columnHeader2.Text = "Ime i Prezime";
            this.columnHeader2.Width = 180;
            // 
            // AutoriForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AutoriForma";
            this.Text = "AutoriForma";
            this.Load += new System.EventHandler(this.AutoriForma_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dodajPb;
        private System.Windows.Forms.Button izmeniPb;
        private System.Windows.Forms.Button ObrisiB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView spisak;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}