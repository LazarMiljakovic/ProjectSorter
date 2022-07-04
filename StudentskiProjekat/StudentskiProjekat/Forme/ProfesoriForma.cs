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
    public partial class ProfesoriForma : Form
    {
        int idpredmeta;
        public ProfesoriForma()
        {
            InitializeComponent();
        }
        public ProfesoriForma(int idpred)
        {
            idpredmeta = idpred;
            InitializeComponent();


        }

        private void ProfesoriForma_Load(object sender, EventArgs e)
        {
            PopuniPodatke();

        }
        public void PopuniPodatke()
        {
            

            List<PredmetniNastavnikBasic> listaProfesora = DTOManager.vratiSvePredmetneProfesore(idpredmeta);

            this.spisak.Items.Clear();

            foreach (PredmetniNastavnikBasic nastavnik in listaProfesora)
            {
                ListViewItem item = new ListViewItem(new string[] { nastavnik.Id.ToString(),nastavnik.ime_prezime.ToString() ,});
                this.spisak.Items.Add(item);
            }
            this.spisak.Refresh();


        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            DodajProfesoraForma dp = new DodajProfesoraForma(idpredmeta);
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
            PredmetniNastavnikBasic pb = DTOManager.VratiProfesora(idPred);

            IzmeniProfesoraForma ip = new IzmeniProfesoraForma(pb);
            ip.ShowDialog();

            this.PopuniPodatke();
        }

        private void ObrisiB_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste izbrisali");
                return;
            }

            int iden = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog profesora?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiProfesora(iden);
                MessageBox.Show("Brisanje profesora je uspesno obavljeno!");
                this.PopuniPodatke();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
