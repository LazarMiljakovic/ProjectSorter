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
    public partial class IzmeniPojPrakForma : Form
    {
        private PrakticniPojedinacniBasic tb = new PrakticniPojedinacniBasic();
        List<Combo> ls = new List<Combo>();
        int sifra;

        public IzmeniPojPrakForma()
        {
            InitializeComponent();
        }

        public IzmeniPojPrakForma(PrakticniPojedinacniBasic pp)
        {
            InitializeComponent();

            this.tb = pp;
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
            tb.KratakOpis = kratkiBox.Text;
            tb.PreporuceniJezik = Pjbox.Text;

            DTOManager.AzurirajPrakPojProjekat(tb);

            this.Close();
        }

       
      
        private void IzmeniPojPrakForma_Load(object sender, EventArgs e)
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
            Pjbox.Text = tb.PreporuceniJezik.ToString();
            kratkiBox.Text = tb.KratakOpis;


        }

        private void webbutt_Click(object sender, EventArgs e)
        {
            IzmeniSpisakWeba sw = new IzmeniSpisakWeba(tb.identifikator);
            sw.ShowDialog();

        }

        private void izvestajiB_Click(object sender, EventArgs e)
        {
            IzmeniIzvestajeForma sw = new IzmeniIzvestajeForma(tb.identifikator);
            sw.ShowDialog();
        }
    }
}
