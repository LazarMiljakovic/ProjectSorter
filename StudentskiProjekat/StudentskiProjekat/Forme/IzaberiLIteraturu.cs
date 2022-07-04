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
    public partial class IzaberiLIteraturu : Form
    {
        int iden;
        char b;
        public IzaberiLIteraturu()
        {
            InitializeComponent();
        }
        public IzaberiLIteraturu(int iden,char b)
        {
            this.iden = iden;
            this.b = b;
            InitializeComponent();
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            if(rad.Checked)
            {
                DodajRadForma ir = new DodajRadForma(iden,b);
                ir.ShowDialog();
                this.Close();
            }
            else if(knjiga.Checked)
            {
                DodajKnjiguForma ir = new DodajKnjiguForma(iden,b);
                ir.ShowDialog(); this.Close();

            }
            else if(clanak.Checked)
            {
                DodajClanakForma ir = new DodajClanakForma(iden,b);
                ir.ShowDialog(); this.Close();

            }
            else
            {
                MessageBox.Show("Izaberite da bi ste izbrisali");
                return;
            }
        }
    }
}
