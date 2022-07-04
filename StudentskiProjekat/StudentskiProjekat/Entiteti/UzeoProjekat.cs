using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiProjekat.Entiteti
{
    public class UzeoProjekat
    {
        public virtual UzeoProjekatId Id { get; set; }
        public virtual DateTime Izabir { get; set; }
        public virtual DateTime Rok { get; set; }

        public virtual DateTime? Zavrsetak { get; set; }

        public UzeoProjekat()
        {
            Id = new UzeoProjekatId();
        }
        
    }
}
