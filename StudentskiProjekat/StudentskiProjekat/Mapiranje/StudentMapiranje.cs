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
    class StudentMapiranje : ClassMap<Student> 
    {
        public StudentMapiranje()
        {
            Table("STUDENT");

            Id(x => x.Index, "INDEKS").GeneratedBy.Assigned();

            Map(x => x.Ime, "IME");
            Map(x => x.Ime_Roditelja, "IMERODITELJA");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Smer, "SMER");

            HasMany(x => x.UzeoProjekatLista).KeyColumn("INDEKS").LazyLoad().Cascade.All();

            
        }
    }
}
