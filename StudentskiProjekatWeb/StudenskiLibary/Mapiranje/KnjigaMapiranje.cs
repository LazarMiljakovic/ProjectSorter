using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentNHibernate;
using StudentskiLibary.Entiteti;

namespace StudentskiLibary.Mapiranje
{
    class KnjigaMapiranje : SubclassMap<Knjiga>
    {
        public KnjigaMapiranje()
        {
            Table("KNJIGA");

            KeyColumn("ID");

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Izdavac, "IZDAVAC");
            Map(x => x.ISBN, "ISBN");
            Map(x => x.GodinaIzdanja, "GODINAIZDANJA");
        }
    }
}
