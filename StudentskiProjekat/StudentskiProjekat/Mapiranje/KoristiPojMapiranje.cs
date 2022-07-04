using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using FluentNHibernate;
using StudentskiProjekat.Entiteti;

namespace StudentskiProjekat.Mapiranje
{
    class KoristiPojMapiranje : ClassMap<KoristiPoj>
    {
        public KoristiPojMapiranje()
        {
            Table("KORISTIPOJ");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("ISEQ$$_283200").Not.Nullable();

            References(x => x.TeorijskiPoj).Column("TEOR").LazyLoad();
            References(x => x.Literatura).Column("LITERATURA").LazyLoad();

        }
    }
}
