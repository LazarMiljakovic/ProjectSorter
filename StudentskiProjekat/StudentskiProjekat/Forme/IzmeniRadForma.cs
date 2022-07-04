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
    public partial class IzmeniRadForma : Form
    {
        private RadBasic r= new RadBasic();

        public IzmeniRadForma()
        {
            InitializeComponent();
        }

        public IzmeniRadForma(RadBasic r)
        {
            InitializeComponent();

            this.r = r;
        }

        private void IzmeniRadForma_Load(object sender, EventArgs e)
        {
            NazivBox.Text = r.Naziv;
            FormatBox.Text = r.Format;
            KofBox.Text = r.Konferencija;
            AdresaBox.Text = r.Adresa;

        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            r.Naziv = NazivBox.Text;
            r.Format = FormatBox.Text;
            r.Konferencija = KofBox.Text;
            r.Adresa = AdresaBox.Text;

            DTOManager.AzurirajRad(r);
            this.Close();

        }
    }
}
