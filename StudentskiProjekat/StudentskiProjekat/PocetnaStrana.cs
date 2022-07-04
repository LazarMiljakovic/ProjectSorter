using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentskiProjekat.Forme;

namespace StudentskiProjekat
{
    public partial class PocetnaStrana : Form
    {
        public PocetnaStrana()
        {
            InitializeComponent();
        }

        private void projektiB_Click(object sender, EventArgs e)
        {
            ProjektiForm p = new ProjektiForm();
            p.ShowDialog();
            
        }

        private void studentiB_Click(object sender, EventArgs e)
        {
            SviStudenti p = new SviStudenti();
            p.ShowDialog();
        }

        private void PREDMETI_Click(object sender, EventArgs e)
        {
            SviPredmeti p = new SviPredmeti();
            p.ShowDialog();
        }
    }
}
