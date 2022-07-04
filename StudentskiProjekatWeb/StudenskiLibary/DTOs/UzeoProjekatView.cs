using StudentskiLibary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class UzeoProjekatView
    {
        public UzeoProjekatIdView Id { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Rok { get; set; }
        public DateTime? Zavrsetak { get; set; }


        public UzeoProjekatView()
        {

        }
        public UzeoProjekatView(UzeoProjekatIdView id, DateTime poc, DateTime rok, DateTime? zav)
        {
            this.Id = id;
            this.Pocetak = poc;
            this.Rok = rok;
            this.Zavrsetak = zav;

        }
    }
}
