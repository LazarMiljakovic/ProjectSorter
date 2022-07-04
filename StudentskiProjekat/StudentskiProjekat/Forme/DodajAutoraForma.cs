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
    public partial class DodajAutoraForma : Form
    {
        private int iden;

        public DodajAutoraForma()
        {
            InitializeComponent();
        }

        public DodajAutoraForma(int iden)
        {
            InitializeComponent();

            this.iden = iden;
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            AutorBasic sb = new AutorBasic();
            sb.literature = iden;
            sb.ime_prezime = imeBox.Text;
            DTOManager.DodajAutora(sb);
            this.Close();
        }
    }
}
