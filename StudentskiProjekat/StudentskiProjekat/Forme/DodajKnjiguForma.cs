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
    public partial class DodajKnjiguForma : Form
    {
        private int iden;
        private char b;
        public DodajKnjiguForma()
        {
            InitializeComponent();
        }

        public DodajKnjiguForma(int iden,char b)
        {
            InitializeComponent();

            this.iden = iden;
            this.b = b;
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            KnjigaBasic k = new KnjigaBasic();
            k.Naziv = NazivBox.Text;
            k.GodinaIzdanja = Int32.Parse(FormatBox.Text);
            k.Izdavac = KofBox.Text;
            k.ISBN = Int32.Parse(AdresaBox.Text);
            DTOManager.DodajKnjigu(k);
            if (b == 'g')
            {
                KoristiGrupBasic kg = new KoristiGrupBasic();
                kg.TeorijskiGrup = DTOManager.VratiTeorGrupProjekat(iden);
                kg.Literatura = DTOManager.VratiKnjigaPoImenu(k.Naziv);
                DTOManager.dodajOdnosLIT_TEOGrup(kg);
            }
            else
            {
                KoristiPojBasic kg = new KoristiPojBasic();
                kg.TeorijskiPoj = DTOManager.VratiTeorPojProjekat(iden);
                kg.Literatura = DTOManager.VratiKnjigaPoImenu(k.Naziv);
                DTOManager.dodajOdnosLIT_TEOPoj(kg);
            }


           
            this.Close();
        }
    }
}
