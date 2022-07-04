using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class ClanakView : LiteraturaView
    {
        public string Naziv { get; set; }
        public int Broj { get; set; }
        public int Godina { get; set; }
        public int ISSN { get; set; }

        public ClanakView(int idl, int idm) : base(idl, idm)
        {

        }
        public ClanakView()
        {

        }
        public ClanakView(int idl, int idm, string n, int b, int g, int i) : base(idl, idm)
        {
            this.Naziv = n;
            this.Broj = b;
            this.Godina = g;
            this.ISSN = i;

        }
    }
}
