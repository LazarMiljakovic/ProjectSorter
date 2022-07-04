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
    public partial class StudentiNaProjektuForma : Form
    {
        private int iden;

        public StudentiNaProjektuForma()
        {
            InitializeComponent();
        }

        public StudentiNaProjektuForma(int iden)
        {
            InitializeComponent();
            this.iden = iden;
        }

        private void StudentiNaProjektuForma_Load(object sender, EventArgs e)
        {
            PopuniPodatke();

        }
        public void PopuniPodatke()
        {
            List<StudentPregled> listaStudenta = DTOManager.vratiStudenteProjekta(iden);

            this.spisak.Items.Clear();

            foreach (StudentPregled student in listaStudenta)
            {
                ListViewItem item = new ListViewItem(new string[] {student.index.ToString(),student.ime,student.imeRoditelja,student.prezime,student.smer  });
                this.spisak.Items.Add(item);
            }
            this.spisak.Refresh();


        }

        private void dodajSP_Click(object sender, EventArgs e)
        {
            DodajStudentaNaProjForma sf = new DodajStudentaNaProjForma(iden);
            sf.ShowDialog();

            this.PopuniPodatke();
        }

        private void obrisiSP_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste izbrisali");
                return;
            }

            int index = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete studenta sa projekta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                UzeoProjekatBasic up = DTOManager.vratiOdnos(index, iden);
                DTOManager.ObrisiOdnos(up);
                MessageBox.Show("Brisanje studenta sa projekta je uspesno obavljeno!");
                this.PopuniPodatke();
            }
            else
            {

            }
        }
    }
}
