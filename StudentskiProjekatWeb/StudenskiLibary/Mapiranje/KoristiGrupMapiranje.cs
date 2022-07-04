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
    class KoristiGrupMapiranje : ClassMap<KoristiGrup>
    {
        public KoristiGrupMapiranje()
        {
            Table("KORISTIGRUP");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("ISEQ$$_283203").Not.Nullable();

            References(x => x.TeorijskiGrup).Column("TEOR").LazyLoad();
            References(x => x.Literatura).Column("LITERATURA").LazyLoad();

        }
    }
}
