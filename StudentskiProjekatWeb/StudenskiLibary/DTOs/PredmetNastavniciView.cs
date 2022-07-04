using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class PredmetNastavniciView
    {
        public int Id { get; set; }

        public int SifraPredmeta { get; set; }
        public string ime_prezime { get; set; }


        public PredmetNastavniciView()
        {

        }
        public PredmetNastavniciView(int id, int sifra, string imeP)
        {
            this.Id = id;
            this.SifraPredmeta = sifra;
            this.ime_prezime = imeP;
        }
    }
}
