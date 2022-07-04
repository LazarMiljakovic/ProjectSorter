using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class IzvestajView
    {
        public int Id { get; set; }
        public int GrupaI { get; set; }
        public string Sadrzaj { get; set; }
        public string Odnos { get; set; } 


        public IzvestajView()
        {

        }
        public IzvestajView(int id, int grupa, string Sad, string odn)
        {
            this.Id = id;
            this.GrupaI = grupa;
            this.Sadrzaj = Sad;
            this.Odnos = odn;

        }
    }
}
