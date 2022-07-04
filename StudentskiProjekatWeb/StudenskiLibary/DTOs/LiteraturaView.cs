using System;
using System.Collections.Generic;
using System.Text;

namespace StudentskiLibary.DTOs
{
    public class LiteraturaView
    {
        public int Idl { get; set; }
        public int Idm { get; set; }

        public virtual IList<TeorijskiPojView> ListaPoj { get; set; }
        public virtual IList<TeorijskiGrupView> ListaGrup { get; set; }

        public virtual IList<AutorView> Autori { get; set; }
        public LiteraturaView()
        {
            ListaPoj = new List<TeorijskiPojView>();
            ListaGrup = new List<TeorijskiGrupView>();
            Autori = new List<AutorView>();
        }
        public LiteraturaView(int idl, int idm)
        {
            this.Idl = idl;
            this.Idm = idm;



        }
    }
}
