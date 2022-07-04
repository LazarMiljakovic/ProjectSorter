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
    public partial class ProjektiForm : Form
    {
        public ProjektiForm()
        {
            InitializeComponent();
        }

        private void ProjektiForm_Load(object sender, EventArgs e)
        {
            PopuniPodatke();

        }
        public void PopuniPodatke()
        {

            List<ProjekatBasic> listaprojekta = DTOManager.vratiSveProjekte();

            this.spisak.Items.Clear();

            foreach (ProjekatBasic projekat in listaprojekta)
            {
                ListViewItem item = new ListViewItem(new string[] {projekat.identifikator.ToString(),projekat.ImeProjekta,projekat.Pocetak.ToString(),projekat.Predmet.ImePredmeta });
                this.spisak.Items.Add(item);
            }
            this.spisak.Refresh();


        }

        private void PregledStudenata_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste otvorili");
                return;
            }
            int iden = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);


            StudentiNaProjektuForma sp = new StudentiNaProjektuForma(iden);
            sp.ShowDialog();

            this.PopuniPodatke();
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            OdaberiKakavProjekat ob = new OdaberiKakavProjekat();
            ob.ShowDialog();

            this.PopuniPodatke();
        }

        private void izmeniPb_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste izmenite");
                return;
            }
            int iden = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);

            TeorijskiGrupniBasic tg = DTOManager.VratiTeorGrupProjekat(iden);
            TeorijskiPojedinacniBasic tp = DTOManager.VratiTeorPojProjekat(iden);
            PrakticniGrupniBasic pg = DTOManager.VratiPrakGrupProjekat(iden);
            PrakticniPojedinacniBasic pp = DTOManager.VratiPrakPojProjekat(iden);

            if (tg.ImeProjekta != null)
            {
                IzmeniTeorijskiGrupForma ir = new IzmeniTeorijskiGrupForma(tg);
                ir.ShowDialog();
            }
            else if (tp.ImeProjekta != null)
            {
                IzmeniTeoPojForma ir = new IzmeniTeoPojForma(tp);
                ir.ShowDialog();
            }
            else if (pg.ImeProjekta != null)
            {
                IzmeniGrupPrakForma ir = new IzmeniGrupPrakForma(pg);
                ir.ShowDialog();
            }
            else
            {
                IzmeniPojPrakForma ir = new IzmeniPojPrakForma(pp);
                ir.ShowDialog();
            }

            this.PopuniPodatke();
        }

        private void ObrisiP_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste izbrisali");
                return;
            }

            int iden = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani projekat?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiProjekat(iden);
                MessageBox.Show("Brisanje projekta je uspesno obavljeno!");
                this.PopuniPodatke();
            }
            else
            {

            }
        }
    }
}
