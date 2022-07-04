using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class UzeoPGView
    {
        public int Id { get; set; }
        public PrakticniGrupniView PrakGrup { get; set; }
        public string ProgramskiJezik { get; set; }
        public string Izvestaj { get; set; }
        public DateTime Datum { get; set; }


        public UzeoPGView()
        {

        }
        public UzeoPGView(int id, PrakticniGrupniView PrakGrup, string ProgJ, string Izv, DateTime datum)
        {
            this.Id = id;
            this.PrakGrup = PrakGrup;
            this.ProgramskiJezik = ProgJ;
            this.Izvestaj = Izv;
            this.Datum = datum;

        }
    }
}
