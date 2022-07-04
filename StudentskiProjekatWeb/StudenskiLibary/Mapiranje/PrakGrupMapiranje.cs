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
    class PrakGrupMapiranje : SubclassMap<PrakGrup>
    {
        public PrakGrupMapiranje()
        {
            Table("PRAKTICNI_GRUPNI");

            KeyColumn("IDENTIFIKATOR");

            Map(x => x.KratakOpis, "KRATAKOPIS");
            Map(x => x.PreporuceniJezik, "PREPORUCENIJEZIK");
            References(x => x.Izvestaji).Column("GRUPAIZVESTAJA").LazyLoad();

            HasMany(x => x.Spisaks).KeyColumn("IDENTIFIKATOR").LazyLoad().Cascade.All();

            HasMany(x => x.UzeoPG).KeyColumn("IDENTIFIKATOR").LazyLoad().Cascade.All();

        }
    }
}
