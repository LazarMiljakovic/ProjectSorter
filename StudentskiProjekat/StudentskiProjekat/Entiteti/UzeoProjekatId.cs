using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiProjekat.Entiteti
{
    public class UzeoProjekatId
    {
        public virtual Student StudentUzeo { get; set; }
        public virtual Projekat UzeoProjekat { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(UzeoProjekatId))
                return false;

        
            UzeoProjekatId recivedObject = (UzeoProjekatId)obj;

            if((StudentUzeo.Index== recivedObject.StudentUzeo.Index)&& (UzeoProjekat.identifikator == recivedObject.UzeoProjekat.identifikator))
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
