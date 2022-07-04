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
    public partial class DodajProfesoraForma : Form
    {
        private PredmetniNastavnikBasic pb = new PredmetniNastavnikBasic();
        int sifraPred;
        public DodajProfesoraForma()
        {
            InitializeComponent();
        }
        public DodajProfesoraForma(int sifraPred)
        {
            InitializeComponent();
            this.sifraPred = sifraPred;
        }

        private void DodajProfesoraForma_Load(object sender, EventArgs e)
        {

        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            this.pb.SifraPredmeta = sifraPred;
            this.pb.ime_prezime = sifrabox.Text;
            DTOManager.DodajNastavnikaNapredmet(this.pb);
            MessageBox.Show("Uspesno ste dodali novi predmet!");
            this.Close();
        }
    }
}
