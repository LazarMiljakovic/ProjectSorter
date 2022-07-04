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
    class UzeoPGMapiranje : ClassMap<UzeoPG>
    {
        public UzeoPGMapiranje()
        {
            Table("UZEOPG");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("ISEQ$$_283252").Not.Nullable();

            Map(x => x.Izvestaj, "IZVESTAJ");
            Map(x => x.ProgramskiJezik, "PROGRAMSKIJEZIK");
            Map(x => x.Datum, "DATUM");



        }
    }
}
