using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiLibary.Entiteti
{
    public class Autor
    {
        public virtual int Id { get; set; }
        public virtual string Ime_Prezime { get; set; }

        public virtual int literatura { get; set; }

    }
}
