using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiProjekat.Entiteti
{
    public class UzeoPP
    {
        public virtual int Id { get; set; }
        public virtual PrakPoj PrakPoj { get; set; }
        public virtual string ProgramskiJezik { get; set; }

        public virtual string Izvestaj { get; set; }
        public virtual DateTime Datum { get; set; }
        

        public UzeoPP()
        {
            PrakPoj = new PrakPoj();
            
        }
    }
}
