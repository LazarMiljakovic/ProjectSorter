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
    public class IzvestajiMapiranje : ClassMap<StudentskiLibary.Entiteti.Izvestaji>
    {
        public IzvestajiMapiranje()
        {
            Table("IZVESTAJI");

            Id(x => x.Id, "ID").GeneratedBy.Assigned();

            Map(x => x.BrojIzvestaja, "BROJIZVESTAJA");
            
            

            HasMany(x => x.izvestaji).KeyColumn("GRUPAI").LazyLoad().Cascade.All();

            

        }

    }
}
