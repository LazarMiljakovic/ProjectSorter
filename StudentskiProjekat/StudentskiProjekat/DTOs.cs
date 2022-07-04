using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentskiProjekat.Entiteti;

namespace StudentskiProjekat
{
 
    #region Student

    public class StudentPregled
    {
        public int index;
        public string ime;
        public string imeRoditelja;
        public string prezime;
        public string smer;

        public StudentPregled()
        {

        }
        public StudentPregled(int ind,string im,string imeR,string prez,string sm)
        {
            this.index = ind;
            this.ime = im;
            this.imeRoditelja = imeR;
            this.prezime = prez;
            this.smer = sm;
        }

    }
    
    public class StudentBasic
    {
        public int index;
        public string ime;
        public string imeRoditelja;
        public string prezime;
        public string smer;

        public IList<UzeoProjekat> UzeoProjekatLista { get; set; }

        public StudentBasic()
        {
            UzeoProjekatLista = new List<UzeoProjekat>();
        }
        public StudentBasic(int ind, string im, string imeR, string prez, string sm)
        {
            this.index = ind;
            this.ime = im;
            this.imeRoditelja = imeR;
            this.prezime = prez;
            this.smer = sm;
        }

    }

    #endregion

    #region Autor
    public class AutorPregled
    {
        public int Id;
        public string ime_prezime;
        public int literature;


        public AutorPregled()
        {

        }
        public AutorPregled(int id, string imeP,int l)
        {
            this.Id = id;
            this.ime_prezime = imeP;
            this.literature = l;
        }

    }

    public class AutorBasic
    {
        public int Id;
        public string ime_prezime;
        public int literature;


        public AutorBasic()
        {
            
        }
        public AutorBasic(int id, string imeP, int l)
        {
            this.Id = id;
            this.ime_prezime = imeP;
            this.literature = l;

        }

    }

    #endregion

    #region Clanak
    public class ClanakPregled : LiteraturaPregled
    {
        public string Naziv;
        public int Broj;
        public int Godina;
        public int ISSN;

        
        public ClanakPregled()
        {

        }
        public ClanakPregled(int idl, int idm ,string n,int b,int g,int i) : base(idl,idm)
        {
            this.Naziv = n;
            this.Broj = b;
            this.Godina = g;
            this.ISSN = i;

        }

    }

    public class ClanakBasic : LiteraturaBasic
    {
        public string Naziv;
        public int Broj;
        public int Godina;
        public int ISSN;

        public ClanakBasic(int idl, int idm) : base(idl, idm)
        {

        }
        public ClanakBasic()
        {

        }
        public ClanakBasic(int idl, int idm,string n, int b, int g, int i): base(idl, idm)
        {
            this.Naziv = n;
            this.Broj = b;
            this.Godina = g;
            this.ISSN = i;

        }

    }
    #endregion

    #region Grupni
    public class GrupniPregled : ProjekatPregled
    {

        public GrupniPregled()
        {

        }
        public GrupniPregled(int id, string im, DateTime poc, PredmetPregled pred) : base(id, im, poc,pred)
        {
            

        }

    }

    public class GrupniBasic : ProjekatBasic
    {


        public GrupniBasic()
        {
            
        }
        public GrupniBasic(int id, string im, DateTime poc, PredmetBasic pred) : base(id,im,poc,pred)
        {
            
        }

    }
    #endregion

    #region Izvestaj

    public class IzvestajPregled
    {
        public int Id;
        public int GrupaI;
        public string Sadrzaj;
        public string Odnos;


        public IzvestajPregled()
        {

        }
        public IzvestajPregled(int id,int grupa, string Sad,string odn)
        {
            this.Id = id;
            this.GrupaI = grupa;
            this.Sadrzaj = Sad;
            this.Odnos = odn;

        }

    }

    public class IzvestajBasic
    {
        public int Id;
        public int GrupaI;
        public string Sadrzaj;
        public string Odnos;


        public IzvestajBasic()
        {

        }
        public IzvestajBasic(int id, int grupa, string Sad, string odn)
        {
            this.Id = id;
            this.GrupaI = grupa;
            this.Sadrzaj = Sad;
            this.Odnos = odn;

        }

    }

    #endregion

    #region Izvestaji

    public class IzvestajiPregled
    {
        public int Id;
        public int BrojIzvestaja;
       


        public IzvestajiPregled()
        {

        }
        public IzvestajiPregled(int id, int brojIz)
        {
            this.Id = id;
            this.BrojIzvestaja = brojIz;

        }

    }

    public class IzvestajiBasic
    {
        public int Id;
        public int BrojIzvestaja;

        public virtual IList<Izvestaj> izvestaji { get; set; }

        public IzvestajiBasic()
        {
            izvestaji = new List<Izvestaj>();

        }
        public IzvestajiBasic(int id, int brojIz)
        {
            this.Id = id;
            this.BrojIzvestaja = brojIz;

        }
    }

    #endregion

    #region Knjiga

    public class KnjigaPregled : LiteraturaPregled
    {
        public string Naziv;
        public string Izdavac;
        public int ISBN;
        public int GodinaIzdanja;

        
        public KnjigaPregled()
        {

        }
        public KnjigaPregled(int idl, int idm, string n, string i, int isbn, int godina) : base(idl, idm)
        {
            this.Naziv = n;
            this.Izdavac = i;
            this.ISBN = isbn;
            this.GodinaIzdanja = godina;

        }

    }

    public class KnjigaBasic : LiteraturaBasic
    {
        public string Naziv;
        public string Izdavac;
        public int ISBN;
        public int GodinaIzdanja;
        public KnjigaBasic(int idl, int idm) : base(idl, idm)
        {

        }
        public KnjigaBasic()
        {

        }
        public KnjigaBasic(int idl, int idm, string n, string i, int isbn, int godina) : base(idl, idm)
        {
            this.Naziv = n;
            this.Izdavac = i;
            this.ISBN = isbn;
            this.GodinaIzdanja = godina;

        }

    }

    #endregion

    #region Literatura

    public class LiteraturaPregled
    {
        public int Idl;
        public int Idm;

        public LiteraturaPregled()
        {

        }
        public LiteraturaPregled(int idl, int idm)
        {
            this.Idl = idl;
            this.Idm = idm;


        }

    }

    public class LiteraturaBasic
    {
        public int Idl;
        public int Idm;

        public virtual IList<TeorijskiPoj> ListaPoj { get; set; }
        public virtual IList<TeorijskiGrup> ListaGrup { get; set; }

        public virtual IList<Autor> Autori { get; set; }
        public LiteraturaBasic()
        {
            ListaPoj = new List<TeorijskiPoj>();
            ListaGrup = new List<TeorijskiGrup>();
            Autori = new List<Autor>();
        }
        public LiteraturaBasic(int idl, int idm)
        {
            this.Idl = idl;
            this.Idm = idm;



        }
    }

    #endregion

    #region Pojedinacni

    public class PojedinacniPregled : ProjekatPregled
    {
        

        public PojedinacniPregled()
        {

        }
        public PojedinacniPregled(int id, string im, DateTime poc, PredmetPregled pred) : base(id, im, poc,pred)
        {
            

        }

    }

    public class PojedinacniBasic : ProjekatBasic
    {
        

        public PojedinacniBasic()
        {
            
        }
        public PojedinacniBasic(int id, string im, DateTime poc, PredmetBasic pred) : base(id, im, poc,pred)
        {
            
        }

    }

    #endregion

    #region PrakticniGrupni

    public class PrakticniGrupniPregled : GrupniPregled
    {
        public string KratakOpis;
        public string PreporuceniJezik;
        public Izvestaji Izvestaji;

        public PrakticniGrupniPregled()
        {

        }
        public PrakticniGrupniPregled(int id, string im, DateTime poc, string kOpis, string Pjezik,Izvestaji izvj, PredmetPregled pred) : base(id, im, poc,pred)
        {
            this.KratakOpis = kOpis;
            this.PreporuceniJezik = Pjezik;
            this.Izvestaji = izvj;

        }

    }

    public class PrakticniGrupniBasic : GrupniBasic
    {
        public string KratakOpis;
        public string PreporuceniJezik;
        public IzvestajiBasic i;
        public virtual List<IzvestajBasic> izvj { get; set; }


        public virtual IList<SpisakWebP> Spisaks { get; set; }

        public virtual IList<UzeoPP> UzeoPP { get; set; }

        public PrakticniGrupniBasic()
        {
            Spisaks = new List<SpisakWebP>();
            UzeoPP = new List<UzeoPP>();
        }
        public PrakticniGrupniBasic(int id, string im, DateTime poc, string kOpis, string Pjezik, IzvestajiBasic i, PredmetBasic pred) : base(id, im, poc,pred)
        {
            this.KratakOpis = kOpis;
            this.PreporuceniJezik = Pjezik;
            this.i = i;

        }
        public PrakticniGrupniBasic(List<IzvestajBasic> izvj)
        {
            this.izvj = izvj;

        }

    }


    #endregion

    #region PrakticniPojedinacni

    public class PrakticniPojedinacniPregled : PojedinacniPregled
    {
        public string KratakOpis;
        public string PreporuceniJezik;
        public Izvestaji Izvestaji;

        public PrakticniPojedinacniPregled()
        {

        }
        public PrakticniPojedinacniPregled(int id, string im, DateTime poc,string kOpis,string Pjezik, Izvestaji izvj, PredmetPregled pred) : base(id, im, poc,pred)
        {
            this.KratakOpis = kOpis;
            this.PreporuceniJezik = Pjezik;
            this.Izvestaji = izvj;

        }

    }

    public class PrakticniPojedinacniBasic : PojedinacniBasic
    {
        public string KratakOpis;
        public string PreporuceniJezik;
        public IzvestajiBasic i;
        public virtual List<IzvestajBasic> izvj { get; set; }


        public virtual IList<SpisakWebP> Spisaks { get; set; }

        public virtual IList<UzeoPP> UzeoPP { get; set; }

        public PrakticniPojedinacniBasic()
        {
            Spisaks = new List<SpisakWebP>();
            UzeoPP = new List<UzeoPP>();
        }
        public PrakticniPojedinacniBasic(int id, string im, DateTime poc, string kOpis, string Pjezik,IzvestajiBasic i,  PredmetBasic pred) : base(id, im, poc,pred)
        {
            this.KratakOpis = kOpis;
            this.PreporuceniJezik = Pjezik;
            this.i = i;

        }
        public PrakticniPojedinacniBasic(List<IzvestajBasic> izvj )
        {
            this.izvj = izvj;

        }

    }

    #endregion

    #region Predmet

    public class PredmetPregled
    {
        public int Sifra;
        public string ImePredmeta;
        public int Semestar;
        public string Katedra;


        public PredmetPregled()
        {

        }
        public PredmetPregled(int sifra,string pred, int sem, string k)
        {
            this.Sifra = sifra;
            this.ImePredmeta = pred;
            this.Semestar = sem;
            this.Katedra = k;

        }

    }

    public class PredmetBasic
    {
        public int Sifra;
        public string ImePredmeta;
        public int Semestar;
        public string Katedra;

        public virtual IList<PredmetNastavnici> PredmetNastavnicis { get; set; }
        public PredmetBasic()
        {
            PredmetNastavnicis = new List<PredmetNastavnici>(); 
        }
        public PredmetBasic(int sifra, string pred, int sem, string k)
        {
            this.Sifra = sifra;
            this.ImePredmeta = pred;
            this.Semestar = sem;
            this.Katedra = k;
        }

    }

    #endregion

    #region PredmetniNastavnik

    public class PredmetniNastavnikPregled
    {
        public int Id;
        public int SifraPredmeta;
        public string ime_prezime;


        public PredmetniNastavnikPregled()
        {

        }
        public PredmetniNastavnikPregled(int id,int sifra, string imeP)
        {
            this.Id = id;
            this.SifraPredmeta = sifra;
            this.ime_prezime = imeP;

        }

    }

    public class PredmetniNastavnikBasic
    {
        public int Id;

        public int SifraPredmeta;
        public string ime_prezime;


        public PredmetniNastavnikBasic()
        {

        }
        public PredmetniNastavnikBasic(int id,int sifra, string imeP)
        {
            this.Id = id;
            this.SifraPredmeta = sifra;
            this.ime_prezime = imeP;
        }

    }

    #endregion

    #region Projekat

    public class ProjekatPregled
    {
        public int identifikator;
        public string ImeProjekta;
        public DateTime Pocetak;
        public PredmetPregled Predmet;


        public ProjekatPregled()
        {

        }
        public ProjekatPregled(int id, string im, DateTime poc, PredmetPregled pred)
        {
            this.identifikator = id;
            this.ImeProjekta = im;
            this.Pocetak = poc;
            this.Predmet = pred;
        }

    }

    public class ProjekatBasic
    {
        public int identifikator;
        public string ImeProjekta;
        public DateTime Pocetak;
        public PredmetBasic Predmet;
        public virtual IList<UzeoProjekat> StudentiLista { get; set; }

        public ProjekatBasic()
        {
            StudentiLista = new List<UzeoProjekat>();
        }
        public ProjekatBasic(int id, string im, DateTime poc, PredmetBasic pred)
        {
            this.identifikator = id;
            this.ImeProjekta = im;
            this.Pocetak = poc;
            this.Predmet = new PredmetBasic(pred.Sifra, pred.ImePredmeta, pred.Semestar, pred.Katedra);

        }

    }

    #endregion

    #region Rad

    public class RadPregled : LiteraturaPregled
    {
        public string Naziv;
        public string Konferencija;
        public string Adresa;
        public string Format;


        public RadPregled()
        {

        }
        public RadPregled(int idl, int idm, string n, string kon, string adr, string format) : base(idl, idm)
        {
            this.Naziv = n;
            this.Konferencija = kon;
            this.Adresa = adr;
            this.Format = format;

        }

    }

    public class RadBasic : LiteraturaBasic
    {
        public string Naziv;
        public string Konferencija;
        public string Adresa;
        public string Format;


        public RadBasic()
        {

        }
        public RadBasic(int idl, int idm) : base(idl, idm)
        {

        }
        public RadBasic(int idl, int idm, string n, string kon, string adr, string format) : base(idl, idm)
        {
            this.Naziv = n;
            this.Konferencija = kon;
            this.Adresa = adr;
            this.Format = format;

        }

    }

    #endregion

    #region SpisakWebGrupni
    public class SpisakWebGrupniPregled
    {
        public int Id;
        public string WebStranica;


        public SpisakWebGrupniPregled()
        {

        }
        public SpisakWebGrupniPregled(int id, string web)
        {
            this.Id = id;
            this.WebStranica = web;

        }

    }

    public class SpisakWebGrupniBasic
    {
        public int Id;
        public string WebStranica;
        public int identifikator;

        public SpisakWebGrupniBasic()
        {

        }
        public SpisakWebGrupniBasic(int id,int iden, string web)
        {
            this.Id = id;
            this.identifikator = iden;
            this.WebStranica = web;

        }

    }

    #endregion

    #region SpisakWebPojedinacni

    public class SpisakWebPojedinacniPregled
    {
        public int Id;
        public string WebStranica;


        public SpisakWebPojedinacniPregled()
        {

        }
        public SpisakWebPojedinacniPregled(int id, string web)
        {
            this.Id = id;
            this.WebStranica = web;

        }

    }

    public class SpisakWebPojedinacniBasic
    {
        public int Id;
        public string WebStranica;
        public int identifikator;


        public SpisakWebPojedinacniBasic()
        {

        }
        public SpisakWebPojedinacniBasic(int id, int iden, string web)
        {
            this.Id = id;
            this.WebStranica = web;
            this.identifikator = iden;
        }

    }

    #endregion

    #region TeorijskiGrupni

    public class TeorijskiGrupniPregled : GrupniPregled
    {
        public int MaxbrojStranica;
        

        public TeorijskiGrupniPregled()
        {

        }
        public TeorijskiGrupniPregled(int id, string im, DateTime poc,int max, PredmetPregled pred) : base(id, im, poc,pred)
        {
            this.MaxbrojStranica = max;
            
        }

    }

    public class TeorijskiGrupniBasic : GrupniBasic
    {
        public int MaxbrojStranica;


        public IList<Literatura> Literature { get; set; }

        public TeorijskiGrupniBasic()
        {
            Literature = new List<Literatura>();
        }
        public TeorijskiGrupniBasic(int id, string im, DateTime poc, int max, PredmetBasic pred) : base(id, im, poc,pred)
        {
            this.MaxbrojStranica = max;

        }

    }

    #endregion

    #region TeorijskiPojedinacni
    public class TeorijskiPojedinacniPregled : PojedinacniPregled
    {
        public int MaxbrojStranica;


        public TeorijskiPojedinacniPregled()
        {

        }
        public TeorijskiPojedinacniPregled(int id, string im, DateTime poc, int max, PredmetPregled pred) : base(id, im, poc,pred)
        {
            this.MaxbrojStranica = max;

        }

    }

    public class TeorijskiPojedinacniBasic : PojedinacniBasic
    {
        public int MaxbrojStranica;


        public IList<Literatura> Literature { get; set; }

        public TeorijskiPojedinacniBasic()
        {
            Literature = new List<Literatura>();
        }
        public TeorijskiPojedinacniBasic(int id, string im, DateTime poc, int max, PredmetBasic pred) : base(id, im, poc,pred)
        {
            this.MaxbrojStranica = max;

        }

    }

    #endregion

    #region UzeoPP

    public class UzeoPPPregled
    {
        public int Id;
        public PrakticniPojedinacniPregled PrakPoj;
        public string ProgramskiJezik;
        public string Izvestaj;
        public DateTime Datum;


        public UzeoPPPregled()
        {

        }
        public UzeoPPPregled(int id, PrakticniPojedinacniPregled prakPoj, string ProgJ, string Izv, DateTime datum)
        {
            this.Id = id;
            this.PrakPoj = prakPoj;
            this.ProgramskiJezik = ProgJ;
            this.Izvestaj = Izv;
            this.Datum = datum;

        }

    }

    public class UzeoPPBasic
    {
        public int Id;
        public PrakticniPojedinacniBasic PrakPoj;
        public string ProgramskiJezik;
        public string Izvestaj;
        public DateTime Datum;


        public UzeoPPBasic()
        {

        }
        public UzeoPPBasic(int id, PrakticniPojedinacniBasic prakPoj, string ProgJ, string Izv, DateTime datum)
        {
            this.Id = id;
            this.PrakPoj = prakPoj;
            this.ProgramskiJezik = ProgJ;
            this.Izvestaj = Izv;
            this.Datum = datum;

        }

    }


    #endregion

    #region UzeoPG

    public class UzeoPGPregled
    {
        public int Id;
        public PrakticniGrupniPregled PrakGrup;
        public string ProgramskiJezik;
        public string Izvestaj;
        public DateTime Datum;


        public UzeoPGPregled()
        {

        }
        public UzeoPGPregled(int id, PrakticniGrupniPregled prakGr, string ProgJ, string Izv,DateTime datum)
        {
            this.Id = id;
            this.PrakGrup = prakGr;
            this.ProgramskiJezik = ProgJ;
            this.Izvestaj = Izv;
            this.Datum = datum;

        }

    }

    public class UzeoPGBasic
    {
        public int Id;
        public PrakticniGrupniBasic PrakGrup;
        public string ProgramskiJezik;
        public string Izvestaj;
        public DateTime Datum;


        public UzeoPGBasic()
        {

        }
        public UzeoPGBasic(int id, PrakticniGrupniBasic prakGr, string ProgJ, string Izv, DateTime datum)
        {
            this.Id = id;
            this.PrakGrup = prakGr;
            this.ProgramskiJezik = ProgJ;
            this.Izvestaj = Izv;
            this.Datum = datum;

        }

    }

    #endregion

    #region UzeoProjekat

    public class UzeoProjekatPregled
    {
        public UzeoProjekatId Id;
        public DateTime Pocetak;
        public DateTime Rok;
        public DateTime? Zavrsetak;


        public UzeoProjekatPregled()
        {

        }
        public UzeoProjekatPregled(UzeoProjekatId id, DateTime poc, DateTime rok, DateTime? zav)
        {
            this.Id = id;
            this.Pocetak = poc;
            this.Rok = rok;
            this.Zavrsetak = zav;

        }

    }

    public class UzeoProjekatBasic
    {
        public UzeoProjekaIDtBasic Id;
        public DateTime Pocetak;
        public DateTime Rok;
        public DateTime? Zavrsetak;


        public UzeoProjekatBasic()
        {
            
        }
        public UzeoProjekatBasic(UzeoProjekaIDtBasic id, DateTime poc, DateTime rok, DateTime? zav)
        {
            this.Id = id;
            this.Pocetak = poc;
            this.Rok = rok;
            this.Zavrsetak = zav;

        }

    }

    public class UzeoProjekaIDtBasic
    {
        public StudentBasic Studentuzeo { get; set; }
        public ProjekatBasic uzeoProjekat { get; set; }

        public UzeoProjekaIDtBasic(StudentBasic s,ProjekatBasic p)
        {
            Studentuzeo = s;
            uzeoProjekat = p;
        }

        public UzeoProjekaIDtBasic()
        {
        }
    }

    #endregion

    #region KoristiPoj
    public class KoristiPojPregled
    {
        public int id;
        public TeorijskiPojedinacniBasic TeorijskiPoj;
        public LiteraturaBasic Literatura;
        public KoristiPojPregled()
        {

        }
        public KoristiPojPregled(int id, TeorijskiPojedinacniBasic teorijskiPoj, LiteraturaBasic lit)
        {
            this.id = id;
            this.TeorijskiPoj = teorijskiPoj;
            this.Literatura = lit;

        }

    }

    public class KoristiPojBasic
    {
        public int id;
        public TeorijskiPojedinacniBasic TeorijskiPoj;
        public LiteraturaBasic Literatura;

        public KoristiPojBasic()
        {
            
        }
        public KoristiPojBasic(int id, TeorijskiPojedinacniBasic teorijskiPoj, LiteraturaBasic lit) 
        {
            this.id = id;
            this.TeorijskiPoj = teorijskiPoj;
            this.Literatura = lit;

        }

    }
    #endregion

    #region KoristiGrup
    public class KoristiGrupPregled
    {
        public int id;
        public TeorijskiGrup TeorijskiGrup;
        public Literatura Literatura;
        public KoristiGrupPregled()
        {

        }
        public KoristiGrupPregled(int id, TeorijskiGrup teorijskiGrup, Literatura lit)
        {
            this.id = id;
            this.TeorijskiGrup = teorijskiGrup;
            this.Literatura = lit;

        }

    }

    public class KoristiGrupBasic
    {
        public int id;
        public TeorijskiGrupniBasic TeorijskiGrup;
        public LiteraturaBasic Literatura;

        public KoristiGrupBasic()
        {

        }
        public KoristiGrupBasic(int id, TeorijskiGrupniBasic teorijskiGrup, LiteraturaBasic lit)
        {
            this.id = id;
            this.TeorijskiGrup = teorijskiGrup;
            this.Literatura = lit;

        }

    }

    #endregion

    #region Combo
    public class Combo
    {
        public int id;
        public string name;

        public Combo(int i,string n)
        {
            id = i;
            name = n;
        }

        public Combo()
        {

        }
    }



    #endregion

}
