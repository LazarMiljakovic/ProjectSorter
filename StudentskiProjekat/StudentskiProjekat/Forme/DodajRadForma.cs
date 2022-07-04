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
    public partial class DodajRadForma : Form
    {
        private int iden;
        char b;

        public DodajRadForma()
        {
            InitializeComponent();
        }

        public DodajRadForma(int iden,char b)
        {
            InitializeComponent();
            this.b = b;
            this.iden = iden;
        }

        private void imePred_Click(object sender, EventArgs e)
        {

        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            RadBasic r = new RadBasic();
            r.Naziv = NazivBox.Text;
            r.Format = FormatBox.Text;
            r.Konferencija = KofBox.Text;
            r.Adresa = AdresaBox.Text;

            DTOManager.DodajRad(r);
            

            if (b == 'g')
            {
                KoristiGrupBasic kg = new KoristiGrupBasic();
                kg.TeorijskiGrup = DTOManager.VratiTeorGrupProjekat(iden);
                kg.Literatura = DTOManager.VratiRadPoImenu(r.Naziv);
                DTOManager.dodajOdnosLIT_TEOGrup(kg);
            }
            else
            {
                KoristiPojBasic kg = new KoristiPojBasic();
                kg.TeorijskiPoj = DTOManager.VratiTeorPojProjekat(iden);
                kg.Literatura = DTOManager.VratiRadPoImenu(r.Naziv);
                DTOManager.dodajOdnosLIT_TEOPoj(kg);
            }


            this.Close();

        }
    }
}
