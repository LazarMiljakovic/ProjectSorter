using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiProjekat.Entiteti
{
    public class PredmetNastavnici
    {
        public virtual int Id { get; set; }
        public virtual int SifraPredmeta { get; set; }

        public virtual string Nastavnik { get; set; }
    }
}
