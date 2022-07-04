using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiProjekat.Entiteti
{
    public class Clanak : Literatura
    {

        public virtual string Naziv { get; set; }
        public virtual int Broj { get; set; }
        public virtual int Godina { get; set; }

        public virtual int ISSN { get; set; }

        public Clanak()
        {
            
        }
    }
}
