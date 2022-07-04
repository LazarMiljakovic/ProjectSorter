using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskiLibary.Entiteti
{
    public class Literatura
    {
        public virtual int Idl { get; set; }
        public virtual int Idm { get; set; }

        public virtual IList<TeorijskiPoj> ListaPoj { get; set; }
        public virtual IList<TeorijskiGrup> ListaGrup { get; set; }

        public virtual IList<Autor> Autori { get; set; }

        public virtual IList<KoristiPoj> KoristiPojs { get; set; }
        public virtual IList<KoristiGrup> KoristiGrups { get; set; }
        public Literatura()
        {
            ListaPoj = new List<TeorijskiPoj>();
            ListaGrup = new List<TeorijskiGrup>();
            Autori = new List<Autor>();
            KoristiPojs = new List<KoristiPoj>();
            KoristiGrups = new List<KoristiGrup>();

        }
    }
}
