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
    public partial class OdaberiKakavProjekat : Form
    {
        public OdaberiKakavProjekat()
        {
            InitializeComponent();
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            if(pojR.Checked)
            {
                if (PrakCheck.Checked)
                {
                    PojPrakForma pp = new PojPrakForma();
                    pp.ShowDialog();

                    this.Close();
                }
                else if (TeoCheck.Checked)
                {
                    DodajTeoPojForma tp = new DodajTeoPojForma();
                    tp.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Morate cekirati koji zelite");
                }
            }
            else if(grupCheck.Checked)
            {
                if (PrakCheck.Checked)
                {
                    GrupPrakForma gp = new GrupPrakForma();
                    gp.ShowDialog();

                    this.Close();
                }
                else if (TeoCheck.Checked)
                {
                    TeorijskiGrupForma tg = new TeorijskiGrupForma();
                    tg.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Morate cekirati koji zelite");
                }
            }
            else
            {
                MessageBox.Show("Morate cekirati koji zelite");
            }
        }
    }
}
