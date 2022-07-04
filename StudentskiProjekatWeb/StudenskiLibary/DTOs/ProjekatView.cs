using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class ProjekatView
    {
        public int identifikator { get; set; }
        public string ImeProjekta { get; set; } 
        public DateTime Pocetak { get; set; }
        public PredmetView Predmet { get; set; } 
        public virtual IList<UzeoProjekatView> StudentiLista { get; set; }

        public ProjekatView()
        {
            StudentiLista = new List<UzeoProjekatView>();
        }
        public ProjekatView(int id, string im, DateTime poc, PredmetView pred)
        {
            this.identifikator = id;
            this.ImeProjekta = im;
            this.Pocetak = poc;
            this.Predmet = new PredmetView(pred.Sifra, pred.ImePredmeta, pred.Semestar, pred.Katedra);

        }
    }
}
