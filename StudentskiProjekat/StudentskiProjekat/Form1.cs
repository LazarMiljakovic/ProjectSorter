using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using StudentskiProjekat.Entiteti;

namespace StudentskiProjekat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StudentskiProjekat.Entiteti.Grupni p = s.Load<StudentskiProjekat.Entiteti.Grupni>(2);

                MessageBox.Show(p.ImeProjekta);
               
                

                 





                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
