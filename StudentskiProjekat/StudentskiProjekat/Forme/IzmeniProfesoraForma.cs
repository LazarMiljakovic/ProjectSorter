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
    public partial class IzmeniProfesoraForma : Form
    {
        private PredmetniNastavnikBasic pb = new PredmetniNastavnikBasic();

        public IzmeniProfesoraForma()
        {
            InitializeComponent();
        }

        public IzmeniProfesoraForma(PredmetniNastavnikBasic pb)
        {
            this.pb = pb;
            InitializeComponent();

        }

        private void IzmeniProfesoraForma_Load(object sender, EventArgs e)
        {
            sifrabox.Text = pb.ime_prezime;
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            this.pb.ime_prezime = sifrabox.Text;
            DTOManager.AzurirajProfesora(this.pb);
            MessageBox.Show("Uspesno ste dodali novi predmet!");
            this.Close();
        }
    }
}
