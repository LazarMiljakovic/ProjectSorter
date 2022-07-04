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
    public partial class IzmeniStudentaForma : Form
    {
        private StudentBasic sb = new StudentBasic();

        public IzmeniStudentaForma()
        {
            InitializeComponent();
        }

        public IzmeniStudentaForma(StudentBasic sb)
        {
            this.sb = sb;
            InitializeComponent();

        }

        private void IzmeniStudentaForma_Load(object sender, EventArgs e)
        {
            indeksbox.Text = sb.index.ToString();
            imeBox.Text = sb.ime;
            imeRbox.Text = sb.imeRoditelja;
            prezimeBox.Text = sb.prezime;
            smerBox.Text = sb.smer;
        }

        private void IzmeniSb_Click(object sender, EventArgs e)
        {
            sb.index = Int32.Parse(indeksbox.Text);
            sb.ime = imeBox.Text;
            sb.imeRoditelja = imeRbox.Text;
            sb.prezime = prezimeBox.Text;
            sb.smer = smerBox.Text;

            DTOManager.AzurirajStudenta(sb);
            MessageBox.Show("Uspesno ste izmenili novog studenta!");
            this.Close();
        }
    }
}
