using StudentskiLibary.Entiteti;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class PrakticniPojedinacniView : PojedinacniView
    {
        public string KratakOpis { get; set; }
        public string PreporuceniJezik { get; set; }
        public IzvestajiView i { get; set; }
        public virtual List<IzvestajView> izvj { get; set; }


        public virtual IList<SpisakWebG> Spisaks { get; set; }

        public virtual IList<UzeoPP> UzeoPP { get; set; }

        public PrakticniPojedinacniView()
        {
            Spisaks = new List<SpisakWebG>();
            UzeoPP = new List<UzeoPP>();
        }
        public PrakticniPojedinacniView(int id, string im, DateTime poc, string kOpis, string Pjezik, IzvestajiView i, PredmetView pred) : base(id, im, poc, pred)
        {
            this.KratakOpis = kOpis;
            this.PreporuceniJezik = Pjezik;
            this.i = i;

        }
        public PrakticniPojedinacniView(List<IzvestajView> izvj)
        {
            this.izvj = izvj;

        }
    }
}
