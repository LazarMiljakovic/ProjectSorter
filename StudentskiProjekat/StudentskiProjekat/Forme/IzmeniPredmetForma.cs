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
    public partial class IzmeniPredmetForma : Form
    {
        PredmetBasic pb = new PredmetBasic();
        public IzmeniPredmetForma()
        {
            InitializeComponent();
        }
        public IzmeniPredmetForma(PredmetBasic pb)
        {
            InitializeComponent();
            this.pb = pb;
        }

        private void izmeniPb_Click(object sender, EventArgs e)
        {
            this.pb.Sifra = Int32.Parse(sifrabox.Text);
            this.pb.ImePredmeta = imeBox.Text;
            this.pb.Semestar = (int)SemNum.Value;
            this.pb.Katedra = KatedBox.Text;

            DTOManager.AzurirajPredmet(pb);
            MessageBox.Show("Uspesno ste izmenili novi predmet!");
            this.Close();
        }

        private void IzmeniPredmetForma_Load(object sender, EventArgs e)
        {
            sifrabox.Text = pb.Sifra.ToString();
            imeBox.Text = pb.ImePredmeta;
            SemNum.Value = pb.Semestar;
            KatedBox.Text = pb.Katedra;
        }
    }
}
