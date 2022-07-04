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
    class AutorMapiranje : ClassMap<Autor>
    {
        public AutorMapiranje()
        {
            Table("AUTOR");

            Id(x => x.Id, "ID").GeneratedBy.SequenceIdentity("ISEQ$$_283206").Not.Nullable();

            Map(x => x.Ime_Prezime, "IME_PREZIME");
            Map(x => x.literatura, "LITERATURE");        }
    }
}
