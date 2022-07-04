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
    class SpisakWebGMapiranje : ClassMap<SpisakWebG>
    {
        public SpisakWebGMapiranje()
        {
            Table("PRAKTICNI_GRUPNI_SPISAKWEB");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("ISEQ$$_283177").Not.Nullable();

            Map(x => x.WebStranica, "WEBSTRANICA");
            Map(x => x.iden, "IDENTIFIKATOR");
        }
    }
}
