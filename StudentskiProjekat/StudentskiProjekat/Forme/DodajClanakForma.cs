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
    public partial class DodajClanakForma : Form
    {
        private int iden;
        private char b;
        public DodajClanakForma()
        {
            InitializeComponent();
        }

        public DodajClanakForma(int iden,char b)
        {
            InitializeComponent();

            this.iden = iden;
            this.b = b;
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            ClanakBasic c = new ClanakBasic();
            c.Naziv = NazivBox.Text;
            c.Godina = Int32.Parse(FormatBox.Text);
            c.ISSN = Int32.Parse(KofBox.Text);
            c.Broj = Int32.Parse(AdresaBox.Text);

            DTOManager.DodajClanak(c);
            if (b == 'g')
            {
                KoristiGrupBasic kg = new KoristiGrupBasic();
                kg.TeorijskiGrup = DTOManager.VratiTeorGrupProjekat(iden);
                kg.Literatura = DTOManager.VratiClanakPoImenu(c.Naziv);
                DTOManager.dodajOdnosLIT_TEOGrup(kg);
            }
            else
            {
                KoristiPojBasic kg = new KoristiPojBasic();
                kg.TeorijskiPoj = DTOManager.VratiTeorPojProjekat(iden);
                kg.Literatura = DTOManager.VratiClanakPoImenu(c.Naziv);
                DTOManager.dodajOdnosLIT_TEOPoj(kg);
            }

            this.Close();
        }
    }
}
