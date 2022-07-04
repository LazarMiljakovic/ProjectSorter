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
    class ProjekatMapiranje : ClassMap<StudentskiProjekat.Entiteti.Projekat>
    {
        public ProjekatMapiranje()
        {
            Table("PROJEKAT");

            Id(x => x.identifikator, "IDENTIFIKATOR").GeneratedBy.Assigned();

            Map(x => x.ImeProjekta, "IMEPROJEKTA");
            Map(x => x.Pocetak, "POCETAK");

            References(x => x.Predmet).Column("SIFRA").LazyLoad();
            HasMany(x => x.StudentiLista).KeyColumn("IDPROJ").LazyLoad().Cascade.All();

        }
    }
}
