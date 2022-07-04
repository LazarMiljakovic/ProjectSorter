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
    class TeorijskiPojMapiranje : SubclassMap<TeorijskiPoj>
    {
        public TeorijskiPojMapiranje()
        {
            Table("TEORIJSKI_POJEDINACNI");

            KeyColumn("IDENTIFIKATOR");

            Map(x => x.Id, "ID");
            Map(x => x.MaxBrojStranica, "MAXBROJSTRANICA");

            HasManyToMany(x => x.Literaturas)
                .Table("KORISTIPOJ")
                .ParentKeyColumn("TEOR")
                .ChildKeyColumn("LITERATURA")
                .Cascade.All();

            HasMany(x => x.KoristiPojs).KeyColumn("TEOR").LazyLoad().Cascade.All().Inverse();

        }
    }
}
