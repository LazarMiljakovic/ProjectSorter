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
    public partial class AutoriForma : Form
    {
        private int iden;

        public AutoriForma()
        {
            InitializeComponent();
        }

        public AutoriForma(int iden)
        {
            InitializeComponent();

            this.iden = iden;
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            DodajAutoraForma sf = new DodajAutoraForma(iden);
            sf.ShowDialog();

            this.PopuniPodatke();
        }

        private void izmeniPb_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste izmenite");
                return;
            }
            int id = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            AutorBasic sb = DTOManager.VratiAutora(id);

            IzmeniAutoraForma sf = new IzmeniAutoraForma(sb);
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

            int id = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog Autora?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiAutora(id);
                MessageBox.Show("Brisanje autora je uspesno obavljeno!");
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

        private void AutoriForma_Load(object sender, EventArgs e)
        {
            PopuniPodatke();
        }

        public void PopuniPodatke()
        {
            List<AutorPregled> listaAutora = DTOManager.vratiAutoraLiterature(iden);

            this.spisak.Items.Clear();

            foreach (AutorPregled pregled in listaAutora)
            {
                ListViewItem item = new ListViewItem(new string[] { pregled.Id.ToString(),pregled.ime_prezime });
                this.spisak.Items.Add(item);
            }
            this.spisak.Refresh();


        }
    }
}
