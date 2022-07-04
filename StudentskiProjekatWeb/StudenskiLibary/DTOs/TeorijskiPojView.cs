using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class TeorijskiPojView : PojedinacniView
    {
        public int MaxbrojStranica { get; set; }


        public IList<LiteraturaView> Literature { get; set; }

        public TeorijskiPojView()
        {
            Literature = new List<LiteraturaView>();
        }
        public TeorijskiPojView(int id, string im, DateTime poc, int max, PredmetView pred) : base(id, im, poc, pred)
        {
            this.MaxbrojStranica = max;

        }
    }
}
