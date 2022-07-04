using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiProjekat.Entiteti
{
    public class KoristiPoj
    {
        public virtual int Id { get; set; }
        public virtual TeorijskiPoj TeorijskiPoj { get; set; }

        public virtual Literatura Literatura { get; set; }

        public KoristiPoj()
        {
            TeorijskiPoj = new TeorijskiPoj();
            Literatura = new Literatura();
        }
    }
}
