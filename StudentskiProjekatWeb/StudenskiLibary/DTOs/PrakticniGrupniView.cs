using System;
using System.Collections.Generic;
using System.Text;
using StudentskiLibary.Entiteti;

namespace StudentskiLibary.DTOs
{
    public class PrakticniGrupniView : GrupniView
    {
        public string KratakOpis { get; set; }
        public string PreporuceniJezik { get; set; }
        public IzvestajiView i { get; set; }
        public virtual List<IzvestajView> izvj { get; set; }


        public virtual IList<SpisakWebP> Spisaks { get; set; }

        public virtual IList<UzeoPG> UzeoPG { get; set; }

        public PrakticniGrupniView()
        {
            Spisaks = new List<SpisakWebP>();
            UzeoPG = new List<UzeoPG>();
        }
        public PrakticniGrupniView(int id, string im, DateTime poc, string kOpis, string Pjezik, IzvestajiView i, PredmetView pred) : base(id, im, poc, pred)
        {
            this.KratakOpis = kOpis;
            this.PreporuceniJezik = Pjezik;
            this.i = i;

        }
        public PrakticniGrupniView(List<IzvestajView> izvj)
        {
            this.izvj = izvj;

        }
    }
}
