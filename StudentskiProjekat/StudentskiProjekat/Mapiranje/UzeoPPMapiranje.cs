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
    class UzeoPPMapiranje : ClassMap<UzeoPP>
    {
        public UzeoPPMapiranje()
        {
            Table("UZEOPP");

            Id(x=>x.Id,"ID").GeneratedBy.SequenceIdentity("ISEQ$$_283249").Not.Nullable();
            Map(x => x.Izvestaj, "IZVESTAJ");
            Map(x => x.ProgramskiJezik, "PROGRAMSKIJEZIK");
            Map(x => x.Datum, "DATUM");

            
            
        }
    }
}
