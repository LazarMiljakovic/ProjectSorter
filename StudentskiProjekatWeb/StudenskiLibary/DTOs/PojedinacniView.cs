using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class PojedinacniView : ProjekatView
    {
        public PojedinacniView()
        {

        }
        public PojedinacniView(int id, string im, DateTime poc, PredmetView pred) : base(id, im, poc, pred)
        {

        }
    }
}
