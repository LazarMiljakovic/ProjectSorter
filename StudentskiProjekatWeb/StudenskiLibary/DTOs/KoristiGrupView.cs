using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class KoristiGrupView
    {
        public int id { get; set; }
        public TeorijskiGrupView TeorijskiGrup { get; set; }
        public LiteraturaView Literatura { get; set; }

        public KoristiGrupView()
        {

        }
        public KoristiGrupView(int id, TeorijskiGrupView TeorijskiGrup, LiteraturaView lit)
        {
            this.id = id;
            this.TeorijskiGrup = TeorijskiGrup;
            this.Literatura = lit;

        }
    }
}
