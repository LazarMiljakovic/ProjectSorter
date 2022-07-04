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
    public partial class DodajStudentaNaProjForma : Form
    {
        private int iden;
        private int index;
        List<Combo> ls = new List<Combo>();
        public DodajStudentaNaProjForma()
        {
            InitializeComponent();
        }

        public DodajStudentaNaProjForma(int iden)
        {
            InitializeComponent();

            this.iden = iden;
        }

        private void dodajPb_Click(object sender, EventArgs e)
        {

            PrakticniGrupniBasic pg = DTOManager.VratiPrakGrupProjekat(iden);
            PrakticniPojedinacniBasic pp = DTOManager.VratiPrakPojProjekat(iden);
            if(pg.ImeProjekta==null&&pp.ImeProjekta!=null)
            {
                UzeoPPPGForma uz = new UzeoPPPGForma(pp);
                uz.ShowDialog();

            }
            else if(pg.ImeProjekta != null && pp.ImeProjekta == null)
            {
                UzeoPPPGForma uz = new UzeoPPPGForma(pg);
                uz.ShowDialog();
            }
            
            foreach(Combo combo in ls)
            {
                if(combo.name == studenCombo.SelectedItem.ToString())
                {
                    index = combo.id;
                }
            }
            StudentBasic s = DTOManager.VratiStudenta(index);
            ProjekatBasic p = DTOManager.VratiProjekat(iden);
            UzeoProjekaIDtBasic id = new UzeoProjekaIDtBasic(s, p);
            UzeoProjekatBasic u = new UzeoProjekatBasic(id, dateTimePicker1.Value, dateTimePicker2.Value, dateTimePicker3.Value);



            DTOManager.dodajOdnosS_P(u);
            MessageBox.Show("Uspesno dodatno");
            

        }

        private void DodajStudentaNaProjForma_Load(object sender, EventArgs e)
        {
            
            List<StudentBasic> studenti = DTOManager.vratiSveStudente();
            foreach(StudentBasic s in studenti)
            {
                Combo c = new Combo(s.index,s.ime+" "+s.prezime);
                studenCombo.Items.Add(s.ime + " " + s.prezime);
                ls.Add(c);

            }
        }
    }
}
