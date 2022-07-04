using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class GrupniView : ProjekatView
    {
        public GrupniView()
        {

        }
        public GrupniView(int id, string im, DateTime poc, PredmetView pred) : base(id, im, poc, pred)
        {

        }
    }
}
