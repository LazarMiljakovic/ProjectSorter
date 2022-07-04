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
    class RadMapiranje : SubclassMap<Rad>
    {
        public RadMapiranje()
        {
            Table("RADOVI");

            KeyColumn("ID");

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Konferencija, "KONFERENCIJA");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Format, "FORMATT");
        }
    }
}
