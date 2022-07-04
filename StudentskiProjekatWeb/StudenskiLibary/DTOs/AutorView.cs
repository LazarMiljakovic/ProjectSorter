using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class AutorView
    {
        public int Id { get; set; }
        public string ime_prezime { get; set; }
        public int literature { get; set; }


        public AutorView()
        {

        }
        public AutorView(int id, string imeP, int l)
        {
            this.Id = id;
            this.ime_prezime = imeP;
            this.literature = l;
        }
        public AutorView(AutorView a)
        {
            this.Id = a.Id;
            this.ime_prezime = a.ime_prezime;
            this.literature = a.literature;
        }
    }
}
