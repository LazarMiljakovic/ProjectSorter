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
    public partial class IzmeniLiteraturuForma : Form
    {
        private TeorijskiPojedinacniBasic tb;
        private TeorijskiGrupniBasic tb1;
        private List<LiteraturaBasic> literature = new List<LiteraturaBasic>();
        int iden;
        char b;
        public IzmeniLiteraturuForma()
        {
            InitializeComponent();
        }

        public IzmeniLiteraturuForma(TeorijskiPojedinacniBasic tb)
        {
            InitializeComponent();

            this.tb = tb;
        }

        public IzmeniLiteraturuForma(TeorijskiGrupniBasic tb1)
        {
            InitializeComponent();

            this.tb1 = tb1;
        }

        private void IzmeniLiteraturuForma_Load(object sender, EventArgs e)
        {
            PopuniPodatke();

        }
        public void PopuniPodatke()
        {
            if(tb == null)
            {
                literature = DTOManager.vratiSveLiteratureProjektaGrup(tb1.identifikator);
                iden = tb1.identifikator;
                b = 'g';
            }
            else
            {
                literature = DTOManager.vratiSveLiteratureProjektaPoj(tb.identifikator);
                iden = tb.identifikator;
                b = 'p';

            }



            this.spisak.Items.Clear();

            foreach (LiteraturaBasic lit in literature)
            {
                KnjigaBasic k = DTOManager.VratiKnigu(lit.Idl);
                RadBasic r = DTOManager.VratiRad(lit.Idl);
                ClanakBasic c = DTOManager.VratiClanak(lit.Idl);

                if(c.Naziv != null)
                {
                    ListViewItem item = new ListViewItem(new string[] {c.Idl.ToString() ,c.Naziv });
                    this.spisak.Items.Add(item);
                }
                else if(k.Naziv != null)
                {
                    ListViewItem item = new ListViewItem(new string[] { k.Idl.ToString(), k.Naziv });
                    this.spisak.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[] { r.Idl.ToString(), r.Naziv });
                    this.spisak.Items.Add(item);
                }

                
            }
            this.spisak.Refresh();


        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            IzaberiLIteraturu iz = new IzaberiLIteraturu(iden,b);
            iz.ShowDialog();

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

            KnjigaBasic k = DTOManager.VratiKnigu(iden);
            RadBasic r = DTOManager.VratiRad(iden);
            ClanakBasic c = DTOManager.VratiClanak(iden);

            if (c.Naziv != null)
            {
                IzmeniClanakForma ir = new IzmeniClanakForma(c);
                ir.ShowDialog();
            }
            else if (k.Naziv != null)
            {
                IzmeniKnjiguForma ir = new IzmeniKnjiguForma(k);
                ir.ShowDialog();
            }
            else
            {
                IzmeniRadForma ir = new IzmeniRadForma(r);
                ir.ShowDialog();
            }

            this.PopuniPodatke();
        }

        private void ObrisiB_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste izbrisali");
                return;
            }

            int idl = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete literaturu sa projekta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiLiteraturu(idl);
                MessageBox.Show("Brisanje literature sa projekta je uspesno obavljeno!");
                this.PopuniPodatke();
            }
            else
            {

            }
        }

        private void Autori_Click(object sender, EventArgs e)
        {
            if (spisak.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite da bi ste otvorili");
                return;
            }
            int iden = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);


            AutoriForma sp = new AutoriForma(iden);
            sp.ShowDialog();

            this.PopuniPodatke();
        }

        private void Zavrsi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
