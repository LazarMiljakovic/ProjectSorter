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
    public partial class GrupPrakForma : Form
    {
        List<Combo> ls = new List<Combo>();
        int sifra;
        public GrupPrakForma()
        {
            InitializeComponent();
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
            PrakticniGrupniBasic tb = new PrakticniGrupniBasic();
            
            tb.identifikator = Int32.Parse(idenbox.Text);
            tb.ImeProjekta = imeBox.Text;
            tb.Pocetak = dateTimePicker1.Value;
            tb.Predmet = DTOManager.VratiPredmet(sifra);
            tb.KratakOpis = kratkiBox.Text;
            tb.PreporuceniJezik = Pjbox.Text;
            DTOManager.DodajIzvestajGrupu(tb.identifikator);
            DTOManager.DodajPrakGrupProjekat(tb);
            
            this.Close();
        }

        private void GrupPrakForma_Load(object sender, EventArgs e)
        {
            List<PredmetBasic> Predmeti = DTOManager.vratiSvePredmete();
            foreach (PredmetBasic s in Predmeti)
            {
                Combo c = new Combo(s.Sifra, s.ImePredmeta);
                comboBox1.Items.Add(s.ImePredmeta);
                ls.Add(c);

            }
        }
    }
}
