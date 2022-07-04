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
    public partial class IzmeniWebForma : Form
    {
        private SpisakWebGrupniBasic sg;
        private SpisakWebPojedinacniBasic sp;

        public IzmeniWebForma()
        {
            InitializeComponent();
        }

        
        public IzmeniWebForma(SpisakWebGrupniBasic sg)
        {
            InitializeComponent();

            this.sg = sg;
        }

        public IzmeniWebForma(SpisakWebPojedinacniBasic sp)
        {
            InitializeComponent();

            this.sp = sp;
        }

        private void IzmeniWebForma_Load(object sender, EventArgs e)
        {
            if (sp != null)
            {
                sifrabox.Text = sp.WebStranica;

            }
            else
            {
                sifrabox.Text = sg.WebStranica;

            }
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            if (sp != null)
            {
                sp.WebStranica = sifrabox.Text;


                DTOManager.AzurirajWebP(sp);

            }
            else
            {
                sg.WebStranica = sifrabox.Text;

                DTOManager.AzurirajWebG(sg);
            }
            this.Close();
        }
    }
}
