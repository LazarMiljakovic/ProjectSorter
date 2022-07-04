using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiLibary.Entiteti
{
    public class Rad : Literatura
    {
        public virtual string Naziv { get; set; }
        public virtual string Konferencija { get; set; }
        public virtual string Adresa { get; set; }

        public virtual string Format { get; set; }

        public Rad()
        {

        }
    }
}
