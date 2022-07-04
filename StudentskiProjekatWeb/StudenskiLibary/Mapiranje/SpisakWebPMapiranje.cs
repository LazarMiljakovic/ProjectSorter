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
    class SpisakWebPMapiranje : ClassMap<SpisakWebP>
    {
        public SpisakWebPMapiranje()
        {
            Table("PRAKTICNI_POJEDIN_SPISAKWEB");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("ISEQ$$_283174").Not.Nullable();

            Map(x => x.WebStranica, "WEBSTRANICA");
            Map(x => x.iden, "IDENTIFIKATOR");


        }
    }
}
