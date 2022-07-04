using System;
using System.Collections.Generic;
using System.Text;
using StudentskiLibary.Entiteti;

namespace StudentskiLibary.DTOs
{
    public class StudentView
    {
        public int index { get; set; }
        public string ime { get; set; }
        public string imeRoditelja { get; set; }
        public string prezime { get; set; }
        public string smer { get; set; }

        public IList<UzeoProjekatView> UzeoProjekatLista { get; set; }

        public StudentView()
        {
            UzeoProjekatLista = new List<UzeoProjekatView>();
        }
        public StudentView(int ind, string im, string imeR, string prez, string sm)
        {
            this.index = ind;
            this.ime = im;
            this.imeRoditelja = imeR;
            this.prezime = prez;
            this.smer = sm;
        }
    }
}
