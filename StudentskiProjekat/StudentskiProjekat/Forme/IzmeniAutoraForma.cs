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
    public partial class IzmeniAutoraForma : Form
    {
        private AutorBasic sb= new AutorBasic();

        public IzmeniAutoraForma()
        {
            InitializeComponent();
        }

        public IzmeniAutoraForma(AutorBasic sb)
        {
            InitializeComponent();

            this.sb = sb;
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            sb.ime_prezime = ImeBox.Text;
            DTOManager.AzurirajAutora(sb);
            this.Close();
        }

        private void IzmeniAutoraForma_Load(object sender, EventArgs e)
        {
            ImeBox.Text = sb.ime_prezime;
        }
    }
}
