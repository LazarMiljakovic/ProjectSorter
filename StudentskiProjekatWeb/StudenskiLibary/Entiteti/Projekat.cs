using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiLibary.Entiteti
{
    public class Projekat
    {
        public virtual int identifikator { get; set; }
        public virtual string ImeProjekta { get; set; }
        public virtual DateTime Pocetak { get; set; }   

        public virtual Predmet Predmet { get; set; }

        public virtual IList<UzeoProjekat> StudentiLista { get; set; }

        public Projekat()
        {
            Predmet = new Predmet();
            StudentiLista = new List<UzeoProjekat>();
            
        }
    }
}
