namespace StudentskiProjekat
{
    partial class PocetnaStrana
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
            this.projektiB = new System.Windows.Forms.Button();
            this.studentiB = new System.Windows.Forms.Button();
            this.predmetB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // projektiB
            // 
            this.projektiB.AutoSize = true;
            this.projektiB.BackColor = System.Drawing.Color.BlueViolet;
            this.projektiB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projektiB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projektiB.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projektiB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.projektiB.Location = new System.Drawing.Point(199, 244);
            this.projektiB.Name = "projektiB";
            this.projektiB.Size = new System.Drawing.Size(147, 49);
            this.projektiB.TabIndex = 0;
            this.projektiB.Text = "PROJEKTI";
            this.projektiB.UseVisualStyleBackColor = false;
            this.projektiB.Click += new System.EventHandler(this.projektiB_Click);
            // 
            // studentiB
            // 
            this.studentiB.AutoSize = true;
            this.studentiB.BackColor = System.Drawing.Color.BlueViolet;
            this.studentiB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studentiB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentiB.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentiB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentiB.Location = new System.Drawing.Point(199, 299);
            this.studentiB.Name = "studentiB";
            this.studentiB.Size = new System.Drawing.Size(147, 49);
            this.studentiB.TabIndex = 1;
            this.studentiB.Text = "STUDENTI";
            this.studentiB.UseVisualStyleBackColor = false;
            this.studentiB.Click += new System.EventHandler(this.studentiB_Click);
            // 
            // predmetB
            // 
            this.predmetB.AutoSize = true;
            this.predmetB.BackColor = System.Drawing.Color.BlueViolet;
            this.predmetB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.predmetB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.predmetB.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predmetB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.predmetB.Location = new System.Drawing.Point(199, 354);
            this.predmetB.Name = "predmetB";
            this.predmetB.Size = new System.Drawing.Size(147, 49);
            this.predmetB.TabIndex = 2;
            this.predmetB.Text = "PREDMETI";
            this.predmetB.UseVisualStyleBackColor = false;
            this.predmetB.Click += new System.EventHandler(this.PREDMETI_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "E:\\Baze Projekat\\Projekat\\App\\StudentskiProjekat\\StudentskiProjekat\\Resources\\sli" +
    "ka.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(159, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "STUDENTSKI PROJEKTI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PocetnaStrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(532, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.predmetB);
            this.Controls.Add(this.studentiB);
            this.Controls.Add(this.projektiB);
            this.Name = "PocetnaStrana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PocetnaStrana";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button projektiB;
        private System.Windows.Forms.Button studentiB;
        private System.Windows.Forms.Button predmetB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}