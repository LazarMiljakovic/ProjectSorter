using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class RadView : LiteraturaView
    {
        public string Naziv { get; set; }
        public string Konferencija { get; set; }
        public string Adresa { get; set; }
        public string Format { get; set; }


        public RadView()
        {

        }
        public RadView(int idl, int idm) : base(idl, idm)
        {

        }
        public RadView(int idl, int idm, string n, string kon, string adr, string format) : base(idl, idm)
        {
            this.Naziv = n;
            this.Konferencija = kon;
            this.Adresa = adr;
            this.Format = format;

        }
    }
}
