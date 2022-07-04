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
    class LiteraturaMapiranje : ClassMap<Literatura>
    {
        public LiteraturaMapiranje()
        {
            Table("LITERATURA");

            Id(x => x.Idl, "IDL").GeneratedBy.SequenceIdentity("ISEQ$$_283197").Not.Nullable();

            Map(x => x.Idm, "IDM");

            HasManyToMany(x => x.ListaPoj)
                .Table("KORISTIPOJ")
                .ParentKeyColumn("LITERATURA")
                .ChildKeyColumn("TEOR")
                .Cascade.All().Inverse();

            HasManyToMany(x => x.ListaGrup)
                .Table("KORISTIGRUP")
                .ParentKeyColumn("LITERATURA")
                .ChildKeyColumn("TEOR")
                .Cascade.All().Inverse();

            HasMany(x => x.Autori).KeyColumn("LITERATURE").LazyLoad().Cascade.All();
            HasMany(x => x.KoristiGrups).KeyColumn("LITERATURA").LazyLoad().Cascade.All();
            HasMany(x => x.KoristiPojs).KeyColumn("LITERATURA").LazyLoad().Cascade.All();
        }

    }
}
