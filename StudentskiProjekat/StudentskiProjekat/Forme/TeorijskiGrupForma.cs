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
    public partial class TeorijskiGrupForma : Form
    {
        List<Combo> ls = new List<Combo>();
        int sifra;

        public TeorijskiGrupForma()
        {
            InitializeComponent();
        }

        

        private void TeorijskiGrupForma_Load(object sender, EventArgs e)
        {
            List<PredmetBasic> Predmeti = DTOManager.vratiSvePredmete();
            foreach (PredmetBasic s in Predmeti)
            {
                Combo c = new Combo(s.Sifra, s.ImePredmeta);
                comboBox1.Items.Add(s.ImePredmeta);
                ls.Add(c);

            }
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


            TeorijskiGrupniBasic tb = new TeorijskiGrupniBasic();
            tb.identifikator = Int32.Parse(idenbox.Text);
            tb.ImeProjekta = imeBox.Text;
            tb.Pocetak = dateTimePicker1.Value;
            tb.Predmet = DTOManager.VratiPredmet(sifra);
            tb.MaxbrojStranica = Int32.Parse(maxbox.Text);

            DTOManager.DodajTeorGrupProjekat(tb);

            this.Close();
        }
    }
}
