using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class KnjigaView : LiteraturaView
    {
        public string Naziv { get; set; }
        public string Izdavac { get; set; }
        public int ISBN { get; set; }
        public int GodinaIzdanja { get; set; }
        public KnjigaView(int idl, int idm) : base(idl, idm)
        {

        }
        public KnjigaView()
        {

        }
        public KnjigaView(int idl, int idm, string n, string i, int isbn, int godina) : base(idl, idm)
        {
            this.Naziv = n;
            this.Izdavac = i;
            this.ISBN = isbn;
            this.GodinaIzdanja = godina;

        }
    }
}
