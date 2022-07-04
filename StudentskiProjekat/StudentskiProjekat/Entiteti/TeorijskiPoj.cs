using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiProjekat.Entiteti
{
    public class TeorijskiPoj : Pojedinacni
    {
        public virtual int Id { get; set; }
        public virtual int MaxBrojStranica { get; set; }

        public virtual IList<Literatura> Literaturas { get; set; }

        public virtual IList<KoristiPoj> KoristiPojs { get; set; }


        public TeorijskiPoj()
        {
            KoristiPojs = new List<KoristiPoj>();
            
            Literaturas = new List<Literatura>();
        }
    }
}
