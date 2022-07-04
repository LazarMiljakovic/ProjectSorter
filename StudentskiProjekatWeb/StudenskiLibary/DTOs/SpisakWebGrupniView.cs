using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class SpisakWebGrupniView
    {
        public int Id { get; set; }
        public string WebStranica { get; set; }
        public int identifikator { get; set; }

        public SpisakWebGrupniView()
        {

        }
        public SpisakWebGrupniView(int id, int iden, string web)
        {
            this.Id = id;
            this.identifikator = iden;
            this.WebStranica = web;

        }
    }
}
