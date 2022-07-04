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
    public partial class IzmeniSpisakWeba : Form
    {
        private int identifikator;
        private List<SpisakWebGrupniBasic> webG = new List<SpisakWebGrupniBasic>();
        private List<SpisakWebPojedinacniBasic> webP = new List<SpisakWebPojedinacniBasic>();
        private int koji=-1;

        int iden;
        public IzmeniSpisakWeba()
        {
            InitializeComponent();
        }

        public IzmeniSpisakWeba(int identifikator)
        {
            InitializeComponent();

            this.identifikator = identifikator;
        }

        private void IzmeniSpisakWeba_Load(object sender, EventArgs e)
        {
            PopuniPodatke();
        }

        public void PopuniPodatke()
        {
            PrakticniGrupniBasic tb = DTOManager.VratiPrakGrupProjekat(identifikator);
            PrakticniPojedinacniBasic tb1 = DTOManager.VratiPrakPojProjekat(identifikator);

            if (tb.ImeProjekta == null)
            {
                webP = DTOManager.vratiSpisakWebP(tb1.identifikator);
                koji = 1;
            }
            else
            {
                webG = DTOManager.vratiSpisakWebG(tb.identifikator);
                koji = 0;
            }

            this.spisak.Items.Clear();

            if (webP.Count != 0)
            {
                foreach (SpisakWebPojedinacniBasic sw in webP)
                {

                    ListViewItem item = new ListViewItem(new string[] { sw.Id.ToString(),sw.WebStranica });
                    this.spisak.Items.Add(item);

                }
            }
            else
            {
                foreach (SpisakWebGrupniBasic sw in webG)
                {

                    ListViewItem item = new ListViewItem(new string[] { sw.Id.ToString(), sw.WebStranica });
                    this.spisak.Items.Add(item);

                }
            }
            
            this.spisak.Refresh();


        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            PrakticniGrupniBasic tb = DTOManager.VratiPrakGrupProjekat(identifikator);
            PrakticniPojedinacniBasic tb1 = DTOManager.VratiPrakPojProjekat(identifikator);

            if (tb.ImeProjekta != null)
            {
                DodajWebForma iz = new DodajWebForma(tb);
                iz.ShowDialog();
            }
            else
            {
                DodajWebForma iz = new DodajWebForma(tb1);
                iz.ShowDialog();
            }

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

            SpisakWebGrupniBasic sg = DTOManager.VratiWebG(iden);
            SpisakWebPojedinacniBasic sp = DTOManager.VratiWebP(iden);



            if (koji == 0)
            {
                IzmeniWebForma iz = new IzmeniWebForma(sg);
                iz.ShowDialog();
            }
            else if (koji == 1)
            {
                IzmeniWebForma iz = new IzmeniWebForma(sp);
                iz.ShowDialog();
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

            int id = Int32.Parse(spisak.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete Websajt sa projekta?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                SpisakWebGrupniBasic sg = DTOManager.VratiWebG(id);
                


                if (sg.WebStranica != null)
                {
                    DTOManager.obrisiWebG(id);
                }
                else
                {
                    DTOManager.obrisiWebP(id);

                }



                MessageBox.Show("Brisanje Websajt sa projekta je uspesno obavljeno!");
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
