using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class UzeoPPView
    {
        public int Id { get; set; }
        public PrakticniPojedinacniView PrakPoj { get; set; }
        public string ProgramskiJezik { get; set; }
        public string Izvestaj { get; set; }
        public DateTime Datum { get; set; }


        public UzeoPPView()
        {

        }
        public UzeoPPView(int id, PrakticniPojedinacniView prakPoj, string ProgJ, string Izv, DateTime datum)
        {
            this.Id = id;
            this.PrakPoj = prakPoj;
            this.ProgramskiJezik = ProgJ;
            this.Izvestaj = Izv;
            this.Datum = datum;

        }
    }
}
