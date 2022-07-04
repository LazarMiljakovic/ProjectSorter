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
    public partial class UzeoPPPGForma : Form
    {
        private PrakticniGrupniBasic pg;
        private PrakticniPojedinacniBasic pp;

        public UzeoPPPGForma()
        {
            InitializeComponent();
        }

        public UzeoPPPGForma(PrakticniGrupniBasic pg)
        {
            InitializeComponent();

            this.pg = pg;
        }

        public UzeoPPPGForma(PrakticniPojedinacniBasic pp)
        {
            InitializeComponent();

            this.pp = pp;
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {
            if(pg==null)
            {
                UzeoPPBasic u = new UzeoPPBasic();
                u.ProgramskiJezik = pjbox.Text;
                u.Datum = dateTimePicker1.Value;
                u.Izvestaj = izvestajboc.Text;
                u.PrakPoj = pp;
                DTOManager.dodajUzeoPP(u);
            }
            else if (pp==null)
            {
                UzeoPGBasic u = new UzeoPGBasic();
                u.ProgramskiJezik = pjbox.Text;
                u.Datum = dateTimePicker1.Value;
                u.Izvestaj = izvestajboc.Text;
                u.PrakGrup = pg;
                DTOManager.dodajOdnosUzeoPG(u);
            }
            this.Close();
        }
    }
}
