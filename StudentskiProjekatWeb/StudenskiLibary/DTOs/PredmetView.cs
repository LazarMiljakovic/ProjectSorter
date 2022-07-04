using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class PredmetView
    {
        public int Sifra { get; set; }
        public string ImePredmeta { get; set; }
        public int Semestar { get; set; }
        public string Katedra { get; set; }

        public virtual IList<PredmetNastavniciView> PredmetNastavnicis { get; set; }
        public PredmetView()
        {
            PredmetNastavnicis = new List<PredmetNastavniciView>();
        }
        public PredmetView(int sifra, string pred, int sem, string k)
        {
            this.Sifra = sifra;
            this.ImePredmeta = pred;
            this.Semestar = sem;
            this.Katedra = k;
        }
    }
}
