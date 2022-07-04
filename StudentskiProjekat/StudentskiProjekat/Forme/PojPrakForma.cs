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
    public partial class PojPrakForma : Form
    {
        List<Combo> ls = new List<Combo>();
        int sifra;

        public PojPrakForma()
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
            PrakticniPojedinacniBasic tb = new PrakticniPojedinacniBasic();
            
            tb.identifikator = Int32.Parse(idenbox.Text);
            tb.ImeProjekta = imeBox.Text;
            tb.Pocetak = dateTimePicker1.Value;
            tb.Predmet = DTOManager.VratiPredmet(sifra);
            tb.KratakOpis = kratkiBox.Text;
            tb.PreporuceniJezik = Pjbox.Text;
            DTOManager.DodajIzvestajGrupu(tb.identifikator);

            DTOManager.DodajPrakPojProjekat(tb);
            
            this.Close();
        }

        private void PojPrakForma_Load(object sender, EventArgs e)
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
