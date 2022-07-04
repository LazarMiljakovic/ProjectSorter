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
    public partial class IzmeniTeorijskiGrupForma : Form
    {
        List<Combo> ls = new List<Combo>();
        int sifra;
        TeorijskiGrupniBasic tb = new TeorijskiGrupniBasic();

        public IzmeniTeorijskiGrupForma()
        {
            InitializeComponent();
        }
        public IzmeniTeorijskiGrupForma(int iden)
        {
            InitializeComponent();
            tb = DTOManager.VratiTeorGrupProjekat(iden);
        }

        public IzmeniTeorijskiGrupForma(TeorijskiGrupniBasic tg)
        {
            InitializeComponent();

            this.tb = tg;
        }

        private void IzmeniTeorijskiGrupForma_Load(object sender, EventArgs e)
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

            DTOManager.AzurirajTeorGrupProjekat(tb);

            this.Close();
        }

        private void literatura_Click(object sender, EventArgs e)
        {
            IzmeniLiteraturuForma l = new IzmeniLiteraturuForma(tb);
            l.ShowDialog();

        }
    }
}
