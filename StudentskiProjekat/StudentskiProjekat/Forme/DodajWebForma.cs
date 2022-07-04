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
    public partial class DodajWebForma : Form
    {
        private PrakticniGrupniBasic tb;
        private PrakticniPojedinacniBasic tb1;

        public DodajWebForma()
        {
            InitializeComponent();
        }

        public DodajWebForma(PrakticniGrupniBasic tb)
        {
            InitializeComponent();

            this.tb = tb;
        }

        public DodajWebForma(PrakticniPojedinacniBasic tb1)
        {
            InitializeComponent();

            this.tb1 = tb1;
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            if (tb != null)
            {
                SpisakWebGrupniBasic sp = new SpisakWebGrupniBasic();
                sp.WebStranica = sifrabox.Text;
                sp.identifikator = tb.identifikator;


                DTOManager.DodajWebG(sp);
                
            }
            else
            {
                SpisakWebPojedinacniBasic sp = new SpisakWebPojedinacniBasic();
                sp.WebStranica = sifrabox.Text;
                sp.identifikator = tb1.identifikator;


                DTOManager.DodajWebP(sp);
            }
            this.Close();
        }
    }
}
