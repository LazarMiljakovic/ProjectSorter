using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiProjekat.Entiteti
{
    public class Izvestaj
    {
        public virtual int ID { get; set; } 
        public virtual int GrupaI { get; set; }
        public virtual string Sadrzaj { get; set; }
        public virtual string Odnos { get; set; }
    }
}
