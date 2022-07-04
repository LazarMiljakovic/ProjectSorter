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
    class ClanakMapiranje : SubclassMap<Clanak>
    {
        public ClanakMapiranje()
        {
            Table("CLANCI");

            KeyColumn("ID");

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Broj, "BROJ");
            Map(x => x.Godina, "GODINA");
            Map(x => x.ISSN, "ISSN");
        }
    }
}
