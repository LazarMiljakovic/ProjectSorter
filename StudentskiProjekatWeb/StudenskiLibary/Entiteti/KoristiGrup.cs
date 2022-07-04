using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiLibary.Entiteti
{
    public class KoristiGrup
    {
        public virtual int Id { get; set; }
        public virtual TeorijskiGrup TeorijskiGrup { get; set; }

        public virtual Literatura Literatura { get; set; }

        public KoristiGrup()
        {
            TeorijskiGrup = new TeorijskiGrup();
            Literatura = new Literatura();
        }
    }
}
