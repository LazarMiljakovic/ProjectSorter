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
    class PojedinacniMapiranje : SubclassMap<Pojedinacni>
    {
        public PojedinacniMapiranje()
        {
            Table("POJEDINACNI");

            KeyColumn("IDENTIFIKATOR");

            
        }
    }
}
