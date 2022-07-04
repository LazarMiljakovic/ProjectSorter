using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class KoristiPojView
    {
        public int id { get; set; }
        public TeorijskiPojView TeorijskiPoj { get; set; }
        public LiteraturaView Literatura { get; set; }

        public KoristiPojView()
        {

        }
        public KoristiPojView(int id, TeorijskiPojView teorijskiPoj, LiteraturaView lit)
        {
            this.id = id;
            this.TeorijskiPoj = teorijskiPoj;
            this.Literatura = lit;

        }
    }
}
