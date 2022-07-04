using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiLibary.Entiteti
{
    public class Student
    {
        public virtual int Index { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Ime_Roditelja { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Smer { get; set; }

        public virtual IList<UzeoProjekat> UzeoProjekatLista { get; set; }

        

        public Student()
        {
            UzeoProjekatLista = new List<UzeoProjekat>();
        }

    }
}
