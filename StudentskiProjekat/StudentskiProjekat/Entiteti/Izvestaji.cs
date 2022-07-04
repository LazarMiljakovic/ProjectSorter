using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiProjekat.Entiteti
{
    public class Izvestaji
    {
        public virtual int Id { get; set; }
        public virtual int BrojIzvestaja { get; set; }

        public virtual IList<Izvestaj> izvestaji { get; set; }

        
        public Izvestaji()
        {
            izvestaji = new List<Izvestaj>();
        }
    }
}
