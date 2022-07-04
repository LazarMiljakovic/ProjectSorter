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
    public partial class IzmeniIzvestajForma : Form
    {
        private IzvestajBasic sb = new IzvestajBasic();

        public IzmeniIzvestajForma()
        {
            InitializeComponent();
        }

        public IzmeniIzvestajForma(IzvestajBasic sb)
        {
            InitializeComponent();
            this.sb = sb;
        }

        private void IzmeniIzvestajForma_Load(object sender, EventArgs e)
        {
            sifrabox.Text = sb.Sadrzaj;
            imeBox.Text = sb.Odnos;
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            sb.Sadrzaj = sifrabox.Text;
            sb.Odnos = imeBox.Text;

            DTOManager.AzurirajIzvestaj(sb);
            this.Close();
        }
    }
}
