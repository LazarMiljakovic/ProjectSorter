using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiLibary.Entiteti
{
    public class PrakGrup : Grupni
    {

        public virtual string KratakOpis { get; set; }
        public virtual string PreporuceniJezik { get; set; }

        public virtual Izvestaji Izvestaji { get; set; }

        public virtual IList<SpisakWebG> Spisaks { get; set; }

        public virtual IList<UzeoPG> UzeoPG { get; set; }


        public PrakGrup()
        {
            Izvestaji = new Izvestaji();
            Spisaks = new List<SpisakWebG>();
            UzeoPG = new List<UzeoPG>();
        }

    }
}
