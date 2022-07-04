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
    public partial class IzmeniClanakForma : Form
    {
        private ClanakBasic c = new ClanakBasic();

        public IzmeniClanakForma()
        {
            InitializeComponent();
        }

        public IzmeniClanakForma(ClanakBasic c)
        {
            InitializeComponent();

            this.c = c;
        }

        private void IzmeniClanakForma_Load(object sender, EventArgs e)
        {
            NazivBox.Text = c.Naziv;
            FormatBox.Text =c.Godina.ToString();
            KofBox.Text = c.ISSN.ToString();
            AdresaBox.Text = c.Broj.ToString();
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            c.Naziv = NazivBox.Text;
            c.Godina = Int32.Parse(FormatBox.Text);
            c.ISSN = Int32.Parse(KofBox.Text);
            c.Broj = Int32.Parse(AdresaBox.Text);

            DTOManager.AzurirajClanak(c);
            this.Close();
        }
    }
}
