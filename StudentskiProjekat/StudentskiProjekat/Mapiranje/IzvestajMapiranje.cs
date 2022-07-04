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
    class IzvestajMapiranje : ClassMap<StudentskiProjekat.Entiteti.Izvestaj>
    {
        public IzvestajMapiranje()
        {
            Table("IZVESTAJ");

            Id(x => x.ID, "ID").GeneratedBy.SequenceIdentity("ISEQ$$_283163").Not.Nullable();

            Map(x => x.GrupaI, "GRUPAI");
            Map(x => x.Sadrzaj, "SADRZAJ");
            Map(x => x.Odnos, "ODNOS");
        }
    }
}
