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
    public partial class SviPredmeti : Form
    {
        public SviPredmeti()
        {
            InitializeComponent();
        }

        public int brojPredmeta = 0;

        private void SviPredmeti_Load(object sender, EventArgs e)
        {
            PopuniPodatke();

        }
        public void PopuniPodatke()
        {
            this.brojPredmeta = 0;

            List<PredmetBasic> listaPredmeta = DTOManager.vratiSvePredmete();

            this.spisak.Items.Clear();

            foreach (PredmetBasic predmet in listaPredmeta)
            {
                ListViewItem item = new ListViewItem(new string[] {predmet.Sifra.ToString(),predmet.ImePredmeta.ToString(),predmet.Semestar.ToString(),predmet.Katedra.ToString() });
                this.spisak.Items.Add(item);
                this.brojPredmeta++;
            }
            brojpredmetaLab.Text = this.brojPredmeta.ToString();
            this.spisak.Refresh();


        }

        private void spisak_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ObrisiB_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste izbrisali");
                return;
            }

            int iden = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani predmet?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiPredmet(iden);
                MessageBox.Show("Brisanje predmeta je uspesno obavljeno!");
                this.PopuniPodatke();
            }
            else
            {

            }
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            DodajPredmetForma dp = new DodajPredmetForma();
            dp.ShowDialog();

            this.PopuniPodatke();
        }

        private void izmeniPb_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste izmenite");
                return;
            }
            int idPred = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            PredmetBasic pb = DTOManager.VratiPredmet(idPred);

            IzmeniPredmetForma ip = new IzmeniPredmetForma(pb);
            ip.ShowDialog();

            this.PopuniPodatke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste otvorili");
                return;
            }
            int idPred = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            

            ProfesoriForma pf = new ProfesoriForma(idPred);
            pf.ShowDialog();

            this.PopuniPodatke();
        }
    }
}
