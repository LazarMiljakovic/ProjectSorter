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
    class ProjekatMapiranje : ClassMap<StudentskiLibary.Entiteti.Projekat>
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
