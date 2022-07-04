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
    public class UzeoProjekatMapiranje : ClassMap<UzeoProjekat>
    {
        public UzeoProjekatMapiranje()
        {
            Table("UZEO_PROJEKAT");

            CompositeId(x => x.Id).KeyReference(x => x.StudentUzeo, "INDEKS").KeyReference(x => x.UzeoProjekat, "IDPROJ");

            Map(x => x.Izabir, "DATUMIZABIRA");
            Map(x => x.Rok, "ROK");
            Map(x => x.Zavrsetak, "DATUMZAVRSETKA");
        }
    }
}
