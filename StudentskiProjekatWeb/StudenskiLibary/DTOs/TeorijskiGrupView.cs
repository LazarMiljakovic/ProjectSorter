using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class TeorijskiGrupView : GrupniView
    {
        public int MaxbrojStranica { get; set; }


        public IList<LiteraturaView> Literature { get; set; }

        public TeorijskiGrupView()
        {
            Literature = new List<LiteraturaView>();
        }
        public TeorijskiGrupView(int id, string im, DateTime poc, int max, PredmetView pred) : base(id, im, poc, pred)
        {
            this.MaxbrojStranica = max;

        }
    }
}
