using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiLibary.Entiteti
{
    public class PrakPoj : Pojedinacni
    {
        public virtual string KratakOpis { get; set; }
        public virtual string PreporuceniJezik { get; set; }
        
        public virtual Izvestaji Izvestaji { get; set; }

        public virtual IList<SpisakWebP> Spisaks { get; set; }

        public virtual IList<UzeoPP> UzeoPP { get; set; }
        
        public PrakPoj()
        {
            Izvestaji = new Izvestaji();
            Spisaks = new List<SpisakWebP>();
            UzeoPP = new List<UzeoPP>();
        }

    }
}
