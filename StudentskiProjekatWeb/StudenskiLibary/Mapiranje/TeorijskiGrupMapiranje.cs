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
    class TeorijskiGrupMapiranje : SubclassMap<TeorijskiGrup>
    {
        public TeorijskiGrupMapiranje()
        {
            Table("TEORIJSKI_GRUPNI");

            KeyColumn("IDENTIFIKATOR");

            Map(x => x.Id, "ID");
            Map(x => x.MaxBrojStranica, "MAXBROJSTRANICA");

            HasManyToMany(x => x.Literaturas)
                .Table("KORISTIGRUP")
                .ParentKeyColumn("TEOR")
                .ChildKeyColumn("LITERATURA")
                .Cascade.All();

            HasMany(x => x.KoristiGrups).KeyColumn("TEOR").LazyLoad().Cascade.All().Inverse();
        }
    }
}
