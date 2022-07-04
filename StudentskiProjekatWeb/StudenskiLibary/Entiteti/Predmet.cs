using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiLibary.Entiteti
{
    public class Predmet
    {
        public virtual int Sifra { get; set; }
        public virtual string ImePredmeta { get; set; }
        public virtual int Semestar { get; set; }

        public virtual string Katedra { get; set; }

        public virtual IList<PredmetNastavnici> PredmetNastavnicis { get; set; }

        public Predmet()
        {
            PredmetNastavnicis = new List<PredmetNastavnici>();

        }
    }
}
