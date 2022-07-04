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
    class PredmetNastavniciMapiranja : ClassMap<StudentskiProjekat.Entiteti.PredmetNastavnici>
    {
        public PredmetNastavniciMapiranja()
        {
            Table("PREDMET_NASTAVNICI");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("ISEQ$$_278213").Not.Nullable();

            Map(x => x.SifraPredmeta, "SIFRAPREDMETA");
            Map(x => x.Nastavnik, "NASTAVNIK");

            
        }
    }
}
