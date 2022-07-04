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
    public partial class DodajPredmetForma : Form
    {
        PredmetBasic pb = new PredmetBasic();

        public DodajPredmetForma()
        {
            InitializeComponent();
        }

        private void DodajPredmetForma_Load(object sender, EventArgs e)
        {

        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            this.pb.Sifra = Int32.Parse(sifrabox.Text);
            this.pb.ImePredmeta = imeBox.Text;
            this.pb.Semestar = (int)SemNum.Value;
            this.pb.Katedra = KatedBox.Text;

            DTOManager.DodajPredmet(this.pb);
            MessageBox.Show("Uspesno ste dodali novi predmet!");
            this.Close();
        }
    }
}
