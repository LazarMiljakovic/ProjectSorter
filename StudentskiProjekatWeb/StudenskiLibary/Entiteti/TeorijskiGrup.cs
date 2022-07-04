using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiLibary.Entiteti
{
    public class TeorijskiGrup : Grupni
    {
        public virtual int Id { get; set; }
        public virtual int MaxBrojStranica { get; set; }

        public virtual IList<Literatura> Literaturas { get; set; }
        public virtual IList<KoristiGrup> KoristiGrups { get; set; }


        public TeorijskiGrup()
        {
            KoristiGrups = new List<KoristiGrup>();
            Literaturas = new List<Literatura>();

        }
    }
}
