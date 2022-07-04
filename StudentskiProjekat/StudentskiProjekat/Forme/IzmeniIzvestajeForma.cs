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
    public partial class IzmeniIzvestajeForma : Form
    {
        private int identifikator;
        private int brojIzvestaja;

        public IzmeniIzvestajeForma()
        {
            InitializeComponent();
        }

        public IzmeniIzvestajeForma(int identifikator)
        {
            InitializeComponent();

            this.identifikator = identifikator;
        }

        

        private void IzmeniIzvestajeForma_Load(object sender, EventArgs e)
        {
            PopuniPodatke();
        }

        public void PopuniPodatke()
        {
            this.brojIzvestaja = 0;

            List<IzvestajBasic> listaIzvestaja = DTOManager.vratiIzvestajeIzProj(identifikator);

            this.spisak.Items.Clear();
            if (listaIzvestaja.Count == 0)
            {
                
            }


            foreach (IzvestajBasic izvestaj in listaIzvestaja)
            {
                ListViewItem item = new ListViewItem(new string[] { izvestaj.Id.ToString(),izvestaj.Sadrzaj,izvestaj.Odnos });
                this.spisak.Items.Add(item);
                this.brojIzvestaja++;
            }
            brojstudenataLab.Text = this.brojIzvestaja.ToString();
            this.spisak.Refresh();


        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            DodajIzvestajForma df = new DodajIzvestajForma(identifikator);
            df.ShowDialog();

            this.PopuniPodatke();
        }

        private void izmeniPb_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste izmenite");
                return;
            }
            int index = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            IzvestajBasic sb = DTOManager.VratiIzvestaj(index);

            IzmeniIzvestajForma sf = new IzmeniIzvestajForma(sb);
            sf.ShowDialog();

            this.PopuniPodatke();
        }

        private void ObrisiB_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste izbrisali");
                return;
            }

            int indeksB = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani izvestaj?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiIzvestaj(indeksB);
                MessageBox.Show("Brisanje izvestaja je uspesno obavljeno!");
                
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
