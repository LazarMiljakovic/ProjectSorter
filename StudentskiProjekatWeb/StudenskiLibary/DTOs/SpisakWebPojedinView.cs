using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class SpisakWebPojedinView
    {
        public int Id { get; set; }
        public string WebStranica { get; set; }
        public int identifikator { get; set; }

        public SpisakWebPojedinView()
        {

        }
        public SpisakWebPojedinView(int id, int iden, string web)
        {
            this.Id = id;
            this.identifikator = iden;
            this.WebStranica = web;

        }
    }
}
