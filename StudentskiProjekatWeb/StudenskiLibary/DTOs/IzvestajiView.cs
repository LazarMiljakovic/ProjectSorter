using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class IzvestajiView
    {
        public int Id { get; set; }
        public int BrojIzvestaja { get; set; }

        public virtual IList<IzvestajView> izvestaji { get; set; }

        public IzvestajiView()
        {
            izvestaji = new List<IzvestajView>();

        }
        public IzvestajiView(int id, int brojIz)
        {
            this.Id = id;
            this.BrojIzvestaja = brojIz;
            
        }
    }
}
