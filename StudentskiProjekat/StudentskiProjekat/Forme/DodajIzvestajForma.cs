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
    public partial class DodajIzvestajForma : Form
    {
        private int identifikator;

        public DodajIzvestajForma()
        {
            InitializeComponent();
        }

        public DodajIzvestajForma(int identifikator)
        {
            InitializeComponent();

            this.identifikator = identifikator;
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {

            int G = DTOManager.VratiGrupuI(identifikator);
            
            IzvestajBasic sb = new IzvestajBasic();
            
            sb.Sadrzaj = sifrabox.Text;
            sb.Odnos = imeBox.Text;
            sb.GrupaI = G;
            DTOManager.DodajIzvestaj(sb);
            this.Close();

        }
    }
}
