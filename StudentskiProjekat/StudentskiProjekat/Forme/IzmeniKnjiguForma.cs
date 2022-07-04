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
    public partial class IzmeniKnjiguForma : Form
    {
        private KnjigaBasic k = new KnjigaBasic();

        public IzmeniKnjiguForma()
        {
            InitializeComponent();
        }

        public IzmeniKnjiguForma(KnjigaBasic k)
        {
            InitializeComponent();

            this.k = k;
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            k.Naziv = NazivBox.Text;
            k.GodinaIzdanja = Int32.Parse(FormatBox.Text);
            k.Izdavac = KofBox.Text;
            k.ISBN = Int32.Parse(AdresaBox.Text);

            DTOManager.AzurirajKnjigu(k);
            this.Close();
        }

        private void IzmeniKnjiguForma_Load(object sender, EventArgs e)
        {
            NazivBox.Text = k.Naziv;
            FormatBox.Text = k.GodinaIzdanja.ToString();
            KofBox.Text = k.Izdavac;
            AdresaBox.Text = k.ISBN.ToString();
        }
    }
}
