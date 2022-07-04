using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiProjekat.Forme
{
    public partial class DodajStudentaForma : Form
    {
        private StudentBasic sb = new StudentBasic();

        public DodajStudentaForma()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            sb.index = Int32.Parse(indeksbox.Text);
            sb.ime = imeBox.Text;
            sb.imeRoditelja = imeRbox.Text;
            sb.prezime = prezimeBox.Text;
            sb.smer = smerBox.Text;

            DTOManager.DodajStudenta(sb);
            MessageBox.Show("Uspesno ste izmenili novog studenta!");
            this.Close();
        }
    }
}
