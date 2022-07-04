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
    public partial class IzmeniTeoPojForma : Form
    {
        List<Combo> ls = new List<Combo>();
        int sifra;
        TeorijskiPojedinacniBasic tb = new TeorijskiPojedinacniBasic();
        

        public IzmeniTeoPojForma()
        {
            InitializeComponent();
        }
        public IzmeniTeoPojForma(int iden)
        {
            InitializeComponent();
            tb = DTOManager.VratiTeorPojProjekat(iden);
        }

        public IzmeniTeoPojForma(TeorijskiPojedinacniBasic tp)
        {
            InitializeComponent();

            this.tb = tp;
        }

        private void IzmeniTeoPojForma_Load(object sender, EventArgs e)
        {
            List<PredmetBasic> Predmeti = DTOManager.vratiSvePredmete();
            foreach (PredmetBasic s in Predmeti)
            {
                Combo c = new Combo(s.Sifra, s.ImePredmeta);
                comboBox1.Items.Add(s.ImePredmeta);
                ls.Add(c);

            }
            idenbox.Text = tb.identifikator.ToString();
            imeBox.Text = tb.ImeProjekta;
            dateTimePicker1.Value = tb.Pocetak;
            comboBox1.Text = tb.Predmet.ImePredmeta;
            maxbox.Text = tb.MaxbrojStranica.ToString();




        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            foreach (Combo combo in ls)
            {
                if (combo.name == comboBox1.SelectedItem.ToString())
                {
                    sifra = combo.id;
                }
            }


            tb.identifikator = Int32.Parse(idenbox.Text);
            tb.ImeProjekta = imeBox.Text;
            tb.Pocetak = dateTimePicker1.Value;
            tb.Predmet = DTOManager.VratiPredmet(sifra);
            tb.MaxbrojStranica = Int32.Parse(maxbox.Text);

            DTOManager.AzurirajTeorPojProjekat(tb);

            this.Close();
        }

        private void literatura_Click(object sender, EventArgs e)
        {
            IzmeniLiteraturuForma l = new IzmeniLiteraturuForma(tb);
            l.ShowDialog();

        }
    }
}
