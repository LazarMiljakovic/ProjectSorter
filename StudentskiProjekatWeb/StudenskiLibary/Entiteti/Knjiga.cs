using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiLibary.Entiteti
{
    public class Knjiga : Literatura
    {
        public virtual string Naziv { get; set; }
        public virtual string Izdavac { get; set; }
        public virtual int ISBN { get; set; }

        public virtual int GodinaIzdanja { get; set; }

        public Knjiga()
        {
            
        }
    }
}
