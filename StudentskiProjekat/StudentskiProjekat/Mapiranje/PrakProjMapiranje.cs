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
    class PrakProjMapiranje : SubclassMap<PrakPoj>
    {
        public PrakProjMapiranje()
        {
            Table("PRAKTICNI_POJEDINACNI");

            KeyColumn("IDENTIFIKATOR");

            Map(x => x.KratakOpis, "KRATAKOPIS");
            Map(x => x.PreporuceniJezik, "PREPORUCENIJEZIK");
            References(x => x.Izvestaji).Column("GRUPAIZVESTAJA").LazyLoad();

            HasMany(x => x.Spisaks).KeyColumn("IDENTIFIKATOR").LazyLoad().Cascade.All();

            HasMany(x => x.UzeoPP).KeyColumn("IDENTIFIKATOR").LazyLoad().Cascade.All();
        }
    }
}
