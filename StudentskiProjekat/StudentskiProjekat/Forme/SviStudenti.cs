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
    public partial class SviStudenti : Form
    {
        public SviStudenti()
        {
            InitializeComponent();
        }

        public int brojStudenata = 0;

        private void SviStudenti_Load(object sender, EventArgs e)
        {
            PopuniPodatke();
        }

        public void PopuniPodatke()
        {
            this.brojStudenata = 0;

            List<StudentBasic> listaStudenata = DTOManager.vratiSveStudente();
            
            this.spisak.Items.Clear();

            foreach(StudentBasic student in listaStudenata)
            {
                ListViewItem item = new ListViewItem(new string[] { student.index.ToString(), student.ime, student.imeRoditelja, student.prezime, student.smer });
                this.spisak.Items.Add(item);
                this.brojStudenata++;
            }
            brojstudenataLab.Text = this.brojStudenata.ToString();
            this.spisak.Refresh();


        }

        private void ObrisiB_Click(object sender, EventArgs e)
        {
            if(spisak.SelectedItems.Count ==0)
            {
                MessageBox.Show("Izaberite da bi ste izbrisali");
                return;
            }

            int indeksB = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog studenta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiStudenta(indeksB);
                MessageBox.Show("Brisanje studenta je uspesno obavljeno!");
                this.PopuniPodatke();
            }
            else
            {

            }

        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            DodajStudentaForma sf = new DodajStudentaForma();
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
            int index = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            StudentBasic sb = DTOManager.VratiStudenta(index);

            IzmeniStudentaForma sf = new IzmeniStudentaForma(sb);
            sf.ShowDialog();

            this.PopuniPodatke();
        }
    }
}
