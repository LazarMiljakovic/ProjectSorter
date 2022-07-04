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
    class PredmetMapiranje : ClassMap<StudentskiProjekat.Entiteti.Predmet>
    {
        public PredmetMapiranje()
        {
            Table("PREDMET");

            Id(x => x.Sifra, "SIFRA").GeneratedBy.Assigned();
            
            Map(x => x.ImePredmeta, "IMEPREDMETA");
            Map(x => x.Semestar, "SEMESTAR");
            Map(x => x.Katedra, "KATEDRA");



            HasMany(x => x.PredmetNastavnicis).KeyColumn("SIFRAPREDMETA").LazyLoad().Cascade.All();
        }
    }
}
