using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentskiProjekat.Entiteti;
using NHibernate.Linq;
using NHibernate;

namespace StudentskiProjekat
{
    public class DTOManager
    {
        #region Studenti
        public static List<StudentBasic> vratiSveStudente()
        {
            List<StudentBasic> studenti = new List<StudentBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StudentskiProjekat.Entiteti.Student> sviStudenti = from o in s.Query<StudentskiProjekat.Entiteti.Student>() select o;

                foreach(Student a in sviStudenti)
                {
                    studenti.Add(new StudentBasic(a.Index, a.Ime, a.Ime_Roditelja, a.Prezime, a.Smer));
                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);   
            }
            return studenti;
        }

        public static void obrisiStudenta(int indeks)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StudentskiProjekat.Entiteti.Student a = s.Load<StudentskiProjekat.Entiteti.Student>(indeks);
                a.UzeoProjekatLista.Clear();
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static void dodajOdnosS_P(UzeoProjekatBasic uzeo)
        {
            
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoProjekat u = new UzeoProjekat();
                u.Id = new UzeoProjekatId();
                u.Id.StudentUzeo = s.Load<StudentskiProjekat.Entiteti.Student>(uzeo.Id.Studentuzeo.index);
                u.Id.UzeoProjekat = s.Load<Projekat>(uzeo.Id.uzeoProjekat.identifikator);
                u.Izabir = uzeo.Pocetak;
                u.Rok = uzeo.Rok;
                u.Zavrsetak = uzeo.Zavrsetak;

                s.SaveOrUpdate(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static List<StudentPregled> vratiStudenteProjekta(int iden)
        {
            List<StudentPregled> studenti = new List<StudentPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<UzeoProjekat> sviStudenti = from o in s.Query<UzeoProjekat>() where o.Id.UzeoProjekat.identifikator == iden select o;

                foreach(UzeoProjekat u in sviStudenti)
                {
                    studenti.Add(new StudentPregled(u.Id.StudentUzeo.Index, u.Id.StudentUzeo.Ime, u.Id.StudentUzeo.Ime_Roditelja, u.Id.StudentUzeo.Prezime, u.Id.StudentUzeo.Smer));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return studenti;
        }

        public static void DodajStudenta(StudentBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Student student = new Student();

                student.Index = a.index;
                student.Ime = a.ime;
                student.Ime_Roditelja = a.imeRoditelja;
                student.Prezime = a.prezime;
                student.Smer = a.smer;

                s.SaveOrUpdate(student);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static StudentBasic AzurirajStudenta(StudentBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Student o = s.Load<StudentskiProjekat.Entiteti.Student>(a.index);

                o.Index = a.index;
                o.Ime = a.ime;
                o.Ime_Roditelja = a.imeRoditelja;
                o.Prezime = a.prezime;
                o.Smer = a.smer;

                s.Update(o);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static StudentBasic VratiStudenta(int ind)
        {
            StudentBasic o = new StudentBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Student a = s.Load<StudentskiProjekat.Entiteti.Student>(ind);

                o = new StudentBasic(a.Index, a.Ime, a.Ime_Roditelja, a.Prezime, a.Smer);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }




        #endregion

        #region Projekat
        public static List<ProjekatBasic> vratiSveProjekte()
        {
            List<ProjekatBasic> projekti = new List<ProjekatBasic>();
            try
            {
                ISession s = DataLayer.GetSession();


                IEnumerable<StudentskiProjekat.Entiteti.Projekat> sviProjekti = from o in s.Query<StudentskiProjekat.Entiteti.Projekat>() select o;

                foreach (Projekat a in sviProjekti)
                {
                    PredmetBasic p = VratiPredmet(a.Predmet.Sifra);
                    projekti.Add(new ProjekatBasic(a.identifikator,a.ImeProjekta,a.Pocetak,p));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return projekti;

        }

        public static void obrisiProjekat(int identifikator)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StudentskiProjekat.Entiteti.Projekat a = s.Load<StudentskiProjekat.Entiteti.Projekat>(identifikator);
                a.StudentiLista.Clear();
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static void dodajOdnosP_S(UzeoProjekatBasic uzeo)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                UzeoProjekat u = new UzeoProjekat();
                u.Id = new UzeoProjekatId();
                u.Id.StudentUzeo = s.Load<StudentskiProjekat.Entiteti.Student>(uzeo.Id.Studentuzeo.index);
                u.Id.UzeoProjekat = s.Load<Projekat>(uzeo.Id.uzeoProjekat.identifikator);
                u.Izabir = uzeo.Pocetak;
                u.Rok = uzeo.Rok;
                u.Zavrsetak = uzeo.Zavrsetak;

                s.SaveOrUpdate(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static void DodajProjekat(ProjekatBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Projekat p = new Projekat();

                p.identifikator = a.identifikator;
                p.ImeProjekta = a.ImeProjekta;
                p.Pocetak = a.Pocetak;
                p.Predmet = s.Load<Predmet>(a.Predmet.Sifra);

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static ProjekatBasic AzurirajProjekat(ProjekatBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Projekat p = s.Load<StudentskiProjekat.Entiteti.Projekat>(a.identifikator);

                p.identifikator = a.identifikator;
                p.ImeProjekta = a.ImeProjekta;
                p.Pocetak = a.Pocetak;
                p.Predmet = s.Load<Predmet>(a.Predmet.Sifra);

                s.Update(p);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static ProjekatBasic VratiProjekat(int iden)
        {
            ProjekatBasic o = new ProjekatBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Projekat a = s.Load<StudentskiProjekat.Entiteti.Projekat>(iden);

                o = new ProjekatBasic(a.identifikator,a.ImeProjekta,a.Pocetak, VratiPredmet(a.Predmet.Sifra));

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }





        #region TeorPoj
        public static void DodajTeorPojProjekat(TeorijskiPojedinacniBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                TeorijskiPoj p = new TeorijskiPoj();

                p.identifikator = a.identifikator;
                p.ImeProjekta = a.ImeProjekta;
                p.Pocetak = a.Pocetak;
                p.Predmet = s.Load<Predmet>(a.Predmet.Sifra);
                p.MaxBrojStranica = a.MaxbrojStranica;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static TeorijskiPojedinacniBasic AzurirajTeorPojProjekat(TeorijskiPojedinacniBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                TeorijskiPoj p = s.Load<StudentskiProjekat.Entiteti.TeorijskiPoj>(a.identifikator);

                p.identifikator = a.identifikator;
                p.ImeProjekta = a.ImeProjekta;
                p.Pocetak = a.Pocetak;
                p.Predmet = s.Load<Predmet>(a.Predmet.Sifra);
                p.MaxBrojStranica = a.MaxbrojStranica;
                s.Update(p);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static TeorijskiPojedinacniBasic VratiTeorPojProjekat(int iden)
        {
            TeorijskiPojedinacniBasic o = new TeorijskiPojedinacniBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                TeorijskiPoj a = s.Load<StudentskiProjekat.Entiteti.TeorijskiPoj>(iden);

                o = new TeorijskiPojedinacniBasic(a.identifikator, a.ImeProjekta, a.Pocetak,a.MaxBrojStranica, VratiPredmet(a.Predmet.Sifra));

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }



        #endregion

        #region TeorGrup

        public static void DodajTeorGrupProjekat(TeorijskiGrupniBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                TeorijskiGrup p = new TeorijskiGrup();

                p.identifikator = a.identifikator;
                p.ImeProjekta = a.ImeProjekta;
                p.Pocetak = a.Pocetak;
                p.Predmet = s.Load<Predmet>(a.Predmet.Sifra);
                p.MaxBrojStranica = a.MaxbrojStranica;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static TeorijskiGrupniBasic AzurirajTeorGrupProjekat(TeorijskiGrupniBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                TeorijskiGrup p = s.Load<StudentskiProjekat.Entiteti.TeorijskiGrup>(a.identifikator);

                p.identifikator = a.identifikator;
                p.ImeProjekta = a.ImeProjekta;
                p.Pocetak = a.Pocetak;
                p.Predmet = s.Load<Predmet>(a.Predmet.Sifra);
                p.MaxBrojStranica = a.MaxbrojStranica;
                s.Update(p);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static TeorijskiGrupniBasic VratiTeorGrupProjekat(int iden)
        {
            TeorijskiGrupniBasic o = new TeorijskiGrupniBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                TeorijskiGrup a = s.Load<StudentskiProjekat.Entiteti.TeorijskiGrup>(iden);

                o = new TeorijskiGrupniBasic(a.identifikator, a.ImeProjekta, a.Pocetak, a.MaxBrojStranica, VratiPredmet(a.Predmet.Sifra));

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }

        #endregion

        #region PrakPoj

        public static void DodajPrakPojProjekat(PrakticniPojedinacniBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrakPoj p = new PrakPoj();
                p.identifikator = a.identifikator;
                p.ImeProjekta = a.ImeProjekta;
                p.Pocetak = a.Pocetak;
                p.Predmet = s.Load<Predmet>(a.Predmet.Sifra);
                p.KratakOpis = a.KratakOpis;
                p.PreporuceniJezik = a.PreporuceniJezik;
                p.Izvestaji = s.Load<Izvestaji>(a.identifikator);

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static PrakticniPojedinacniBasic AzurirajPrakPojProjekat(PrakticniPojedinacniBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrakPoj p = s.Load<StudentskiProjekat.Entiteti.PrakPoj>(a.identifikator);

                p.identifikator = a.identifikator;
                p.ImeProjekta = a.ImeProjekta;
                p.Pocetak = a.Pocetak;
                p.Predmet = s.Load<Predmet>(a.Predmet.Sifra);
                p.KratakOpis = a.KratakOpis;
                p.PreporuceniJezik = a.PreporuceniJezik;
                p.Izvestaji = s.Load<Izvestaji>(a.i.Id);

                s.Update(p);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static PrakticniPojedinacniBasic VratiPrakPojProjekat(int iden)
        {
            PrakticniPojedinacniBasic o = new PrakticniPojedinacniBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                PrakPoj a = s.Load<StudentskiProjekat.Entiteti.PrakPoj>(iden);

                o = new PrakticniPojedinacniBasic(a.identifikator, a.ImeProjekta, a.Pocetak,a.KratakOpis,a.PreporuceniJezik, VratiIzvestaje(a.Izvestaji.Id), VratiPredmet(a.Predmet.Sifra));

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }

        public static void dodajUzeoPP(UzeoPPBasic uzeo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoPP u = new UzeoPP();
                u.Id = uzeo.Id;
                u.PrakPoj = s.Load<StudentskiProjekat.Entiteti.PrakPoj>(uzeo.PrakPoj.identifikator);
                u.ProgramskiJezik = uzeo.ProgramskiJezik;
                u.Izvestaj = uzeo.Izvestaj;
                u.Datum = uzeo.Datum;

                s.SaveOrUpdate(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static UzeoPPBasic izmeniUzeoPP(UzeoPPBasic uzeo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoPP u = s.Load<StudentskiProjekat.Entiteti.UzeoPP>(uzeo.Id);
                u.Id = uzeo.Id;
                u.PrakPoj = s.Load<StudentskiProjekat.Entiteti.PrakPoj>(uzeo.PrakPoj.identifikator);
                u.ProgramskiJezik = uzeo.ProgramskiJezik;
                u.Izvestaj = uzeo.Izvestaj;
                u.Datum = uzeo.Datum;

                s.SaveOrUpdate(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return uzeo;
        }



        #endregion

        
        

        #region PrakGrup

        public static void DodajPrakGrupProjekat(PrakticniGrupniBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrakGrup p = new PrakGrup();

                p.identifikator = a.identifikator;
                p.ImeProjekta = a.ImeProjekta;
                p.Pocetak = a.Pocetak;
                p.Predmet = s.Load<Predmet>(a.Predmet.Sifra);
                p.KratakOpis = a.KratakOpis;
                p.PreporuceniJezik = a.PreporuceniJezik;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static PrakticniGrupniBasic AzurirajPrakGrupProjekat(PrakticniGrupniBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrakGrup p = s.Load<StudentskiProjekat.Entiteti.PrakGrup>(a.identifikator);

                p.identifikator = a.identifikator;
                p.ImeProjekta = a.ImeProjekta;
                p.Pocetak = a.Pocetak;
                p.Predmet = s.Load<Predmet>(a.Predmet.Sifra);
                p.KratakOpis = a.KratakOpis;
                p.PreporuceniJezik = a.PreporuceniJezik;
                p.Izvestaji = s.Load<Izvestaji>(a.i.Id);

                s.Update(p);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static PrakticniGrupniBasic VratiPrakGrupProjekat(int iden)
        {
            PrakticniGrupniBasic o = new PrakticniGrupniBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                PrakGrup a = s.Load<StudentskiProjekat.Entiteti.PrakGrup>(iden);

                o = new PrakticniGrupniBasic(a.identifikator, a.ImeProjekta, a.Pocetak, a.KratakOpis, a.PreporuceniJezik,VratiIzvestaje(a.Izvestaji.Id), VratiPredmet(a.Predmet.Sifra));

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }

        public static void dodajOdnosUzeoPG(UzeoPGBasic uzeo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoPG u = new UzeoPG();
                u.Id = uzeo.Id;
                u.PrakGrup = s.Load<StudentskiProjekat.Entiteti.PrakGrup>(uzeo.PrakGrup.identifikator);
                u.ProgramskiJezik = uzeo.ProgramskiJezik;
                u.Izvestaj = uzeo.Izvestaj;
                u.Datum = uzeo.Datum;

                s.SaveOrUpdate(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        public static UzeoPGBasic izmeniUzeoPG(UzeoPGBasic uzeo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoPG u = s.Load<StudentskiProjekat.Entiteti.UzeoPG>(uzeo.PrakGrup.identifikator);
                u.Id = uzeo.Id;
                u.PrakGrup = s.Load<StudentskiProjekat.Entiteti.PrakGrup>(uzeo.PrakGrup.identifikator);
                u.ProgramskiJezik = uzeo.ProgramskiJezik;
                u.Izvestaj = uzeo.Izvestaj;
                u.Datum = uzeo.Datum;

                s.SaveOrUpdate(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return uzeo;
        }

        #endregion
        
        


        #endregion

        #region Autor
        public static List<AutorPregled> vratiAutoraLiterature(int idl)
        {
            List<AutorPregled> autori = new List<AutorPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Literatura> sviAutori = from o in s.Query<Literatura>() where o.Idl == idl select o;

                foreach (Literatura u in sviAutori)
                {
                    foreach(Autor a in u.Autori)
                    {
                        autori.Add(new AutorPregled(a.Id,a.Ime_Prezime,a.literatura));
                    }
                }

                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return autori;
        }



        public static void DodajAutora(AutorBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Autor Aut = new Autor();

                Aut.Ime_Prezime = a.ime_prezime;
                Aut.literatura = a.literature;

                s.SaveOrUpdate(Aut);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static AutorBasic AzurirajAutora(AutorBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Autor Aut = s.Load<StudentskiProjekat.Entiteti.Autor>(a.Id);

                Aut.Id = a.Id;
                Aut.Ime_Prezime = a.ime_prezime;
                s.Update(Aut);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static AutorBasic VratiAutora(int id)
        {
            AutorBasic o = new AutorBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Autor Aut = s.Load<StudentskiProjekat.Entiteti.Autor>(id);

                o = new AutorBasic(Aut.Id, Aut.Ime_Prezime,Aut.literatura);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }

        public static void obrisiAutora(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StudentskiProjekat.Entiteti.Autor a = s.Load<StudentskiProjekat.Entiteti.Autor>(id);
                // FALI BRISANJE AUTORA IZ LITERATURE
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }


        #endregion

        #region Literatura
        public static List<LiteraturaBasic> vratiSveLiteratureProjektaPoj(int iden)
        {
            List<LiteraturaBasic> literature = new List<LiteraturaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StudentskiProjekat.Entiteti.KoristiPoj> sveLit = from o in s.Query<StudentskiProjekat.Entiteti.KoristiPoj>()
                                                                             where o.TeorijskiPoj.identifikator == iden
                                                                             select o;


                foreach (KoristiPoj a in sveLit)
                {

                    literature.Add(new LiteraturaBasic(a.Literatura.Idl,a.Literatura.Idm));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return literature;
        }
        public static List<LiteraturaBasic> vratiSveLiteratureProjektaGrup(int iden)
        {
            List<LiteraturaBasic> literature = new List<LiteraturaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StudentskiProjekat.Entiteti.KoristiGrup> sveLit = from o in s.Query<StudentskiProjekat.Entiteti.KoristiGrup>()
                                                                             where o.TeorijskiGrup.identifikator == iden
                                                                             select o;


                foreach (KoristiGrup a in sveLit)
                {

                    literature.Add(new LiteraturaBasic(a.Literatura.Idl, a.Literatura.Idm));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return literature;
        }


        public static void DodajLiteraturu(LiteraturaBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Literatura lit = new Literatura();

                lit.Idm = a.Idm;

                s.SaveOrUpdate(lit);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        

        public static LiteraturaBasic VratiRadPoImenu(string ime)
        {
            LiteraturaBasic a = new LiteraturaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<StudentskiProjekat.Entiteti.Rad> sveLit = from o in s.Query<StudentskiProjekat.Entiteti.Rad>()
                                                                             where o.Naziv == ime
                                                                             select o; 
                foreach(Rad r in sveLit)
                {
                    a = new LiteraturaBasic(r.Idl,r.Idm);
                }
       

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static LiteraturaBasic VratiKnjigaPoImenu(string ime)
        {
            LiteraturaBasic a = new LiteraturaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<StudentskiProjekat.Entiteti.Knjiga> sveLit = from o in s.Query<StudentskiProjekat.Entiteti.Knjiga>()
                                                                      where o.Naziv == ime
                                                                      select o;
                foreach (Knjiga r in sveLit)
                {
                    a = new LiteraturaBasic(r.Idl, r.Idm);
                }


                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static LiteraturaBasic VratiClanakPoImenu(string ime)
        {
            LiteraturaBasic a = new LiteraturaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<StudentskiProjekat.Entiteti.Clanak> sveLit = from o in s.Query<StudentskiProjekat.Entiteti.Clanak>()
                                                                         where o.Naziv == ime
                                                                         select o;
                foreach (Clanak r in sveLit)
                {
                    a = new LiteraturaBasic(r.Idl, r.Idm);
                }


                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }
        public static LiteraturaBasic VratiLiteraturu(int id)
        {
            LiteraturaBasic o = new LiteraturaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Literatura lit = s.Load<StudentskiProjekat.Entiteti.Literatura>(id);

                o = new LiteraturaBasic(lit.Idl, lit.Idm);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }

        public static void obrisiLiteraturu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                

                StudentskiProjekat.Entiteti.Literatura a = s.Load<StudentskiProjekat.Entiteti.Literatura>(id);

                IEnumerable<StudentskiProjekat.Entiteti.KoristiGrup> sveLit = from o in s.Query<StudentskiProjekat.Entiteti.KoristiGrup>()
                                                                              where o.Literatura.Idl == id
                                                                              select o;
                foreach (KoristiGrup r in sveLit)
                {
                    s.Delete(r); s.Flush();

                }
                IEnumerable<StudentskiProjekat.Entiteti.KoristiPoj> sveLitP = from o in s.Query<StudentskiProjekat.Entiteti.KoristiPoj>()
                                                                              where o.Literatura.Idl == id
                                                                              select o;
                foreach (KoristiPoj r in sveLitP)
                {
                    s.Delete(r); s.Flush();

                }
                IEnumerable<StudentskiProjekat.Entiteti.Autor> sviAut = from o in s.Query<StudentskiProjekat.Entiteti.Autor>()
                                                                              where o.literatura == id
                                                                              select o;
                foreach (Autor r in sviAut)
                {
                    s.Delete(r); s.Flush();

                }


                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
                
                
            }
        }

        public static void dodajOdnosLIT_TEOPoj(KoristiPojBasic koristi)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                KoristiPoj u = new KoristiPoj();
                u.Id = koristi.id;
                u.TeorijskiPoj = s.Load<StudentskiProjekat.Entiteti.TeorijskiPoj>(koristi.TeorijskiPoj.identifikator);
                u.Literatura = s.Load<Literatura>(koristi.Literatura.Idl);
                

                s.SaveOrUpdate(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void dodajOdnosLIT_TEOGrup(KoristiGrupBasic koristi)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                KoristiGrup u = new KoristiGrup();
                u.Id = koristi.id;
                u.TeorijskiGrup = s.Load<StudentskiProjekat.Entiteti.TeorijskiGrup>(koristi.TeorijskiGrup.identifikator);
                u.Literatura = s.Load<Literatura>(koristi.Literatura.Idl);


                s.SaveOrUpdate(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }




        #region Rad
        public static void DodajRad(RadBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Rad r = new Rad();

                r.Naziv = a.Naziv;
                r.Konferencija = a.Konferencija;
                r.Adresa = a.Adresa;
                r.Format = a.Format;

                s.SaveOrUpdate(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }


        public static RadBasic VratiRad(int id)
        {
            RadBasic o = new RadBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Rad lit = s.Load<StudentskiProjekat.Entiteti.Rad>(id);

                o = new RadBasic(lit.Idl,lit.Idm,lit.Naziv,lit.Konferencija,lit.Adresa,lit.Format) ;

                s.Close();
                

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }
        public static RadBasic AzurirajRad(RadBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Rad o = s.Load<StudentskiProjekat.Entiteti.Rad>(a.Idl);

                o.Naziv = a.Naziv;
                o.Konferencija = a.Konferencija;
                o.Adresa = a.Adresa;
                o.Format = a.Format;

                s.Update(o);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }



        #endregion

        #region Knjiga
        public static void DodajKnjigu(KnjigaBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Knjiga r = new Knjiga();

                r.Naziv = a.Naziv;
                r.GodinaIzdanja = a.GodinaIzdanja;
                r.ISBN = a.ISBN;
                r.Izdavac = a.Izdavac;
               

                s.SaveOrUpdate(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }


        public static KnjigaBasic VratiKnigu(int id)
        {
            KnjigaBasic o = new KnjigaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Knjiga lit = s.Load<StudentskiProjekat.Entiteti.Knjiga>(id);

                o = new KnjigaBasic(lit.Idl, lit.Idm, lit.Naziv, lit.Izdavac, lit.ISBN,lit.GodinaIzdanja);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }
        public static KnjigaBasic AzurirajKnjigu(KnjigaBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Knjiga o = s.Load<StudentskiProjekat.Entiteti.Knjiga>(a.Idl);

                o.Naziv = a.Naziv;
                o.Izdavac = a.Izdavac;
                o.ISBN = a.ISBN;
                o.GodinaIzdanja = a.GodinaIzdanja;

                s.Update(o);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }


        #endregion

        #region Clanak

        public static void DodajClanak(ClanakBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Clanak r = new Clanak();

                r.Naziv = a.Naziv;
                r.Broj = a.Broj;
                r.ISSN = a.ISSN;
                r.Godina = a.Godina;


                s.SaveOrUpdate(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }


        public static ClanakBasic VratiClanak(int id)
        {
            ClanakBasic o = new ClanakBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Clanak lit = s.Load<StudentskiProjekat.Entiteti.Clanak>(id);

                o = new ClanakBasic(lit.Idl, lit.Idm, lit.Naziv, lit.Broj, lit.Godina, lit.ISSN);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }
        public static ClanakBasic AzurirajClanak(ClanakBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Clanak o = s.Load<StudentskiProjekat.Entiteti.Clanak>(a.Idl);

                o.Naziv = a.Naziv;
                o.Broj = a.Broj;
                o.Godina = a.Godina;
                o.ISSN = a.ISSN;

                s.Update(o);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }


        #endregion

        #endregion

        #region Predmet

        public static List<PredmetBasic> vratiSvePredmete()
        {
            List<PredmetBasic> predmeti = new List<PredmetBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StudentskiProjekat.Entiteti.Predmet> sviPredmeti = from o in s.Query<StudentskiProjekat.Entiteti.Predmet>() select o;

                foreach (Predmet a in sviPredmeti)
                {
                    
                    predmeti.Add(new PredmetBasic(a.Sifra,a.ImePredmeta,a.Semestar,a.Katedra));
                    
                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return predmeti;
        }


        public static void DodajPredmet(PredmetBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predmet pred = new Predmet();

                pred.Sifra = a.Sifra;
                pred.ImePredmeta = a.ImePredmeta;
                pred.Semestar = a.Semestar;
                pred.Katedra = a.Katedra;

                s.SaveOrUpdate(pred);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static PredmetBasic AzurirajPredmet(PredmetBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predmet pred = s.Load<StudentskiProjekat.Entiteti.Predmet>(a.Sifra);

                pred.Sifra = a.Sifra;
                pred.ImePredmeta = a.ImePredmeta;
                pred.Semestar = a.Semestar;
                pred.Katedra = a.Katedra;
                s.Update(pred);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static PredmetBasic VratiPredmet(int sifra)
        {
            PredmetBasic o = new PredmetBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Predmet pred = s.Load<StudentskiProjekat.Entiteti.Predmet>(sifra);

                o = new PredmetBasic(pred.Sifra, pred.ImePredmeta, pred.Semestar, pred.Katedra);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }

        public static void obrisiPredmet(int sifra)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StudentskiProjekat.Entiteti.Predmet a = s.Load<StudentskiProjekat.Entiteti.Predmet>(sifra);
                a.PredmetNastavnicis.Clear();

                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }


        #region Profesor
        public static List<PredmetniNastavnikBasic> vratiSvePredmetneProfesore(int sifraPredmeta)
        {
            List<PredmetniNastavnikBasic> Nastavnici = new List<PredmetniNastavnikBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StudentskiProjekat.Entiteti.PredmetNastavnici> predmetniNastavnici = from o in s.Query<StudentskiProjekat.Entiteti.PredmetNastavnici>()
                                                                                         where o.SifraPredmeta == sifraPredmeta
                                                                                         select o;

                foreach (PredmetNastavnici a in predmetniNastavnici)
                {

                    Nastavnici.Add(new PredmetniNastavnikBasic(a.Id,a.SifraPredmeta,a.Nastavnik));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return Nastavnici;
        }


        public static void DodajNastavnikaNapredmet(PredmetniNastavnikBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PredmetNastavnici pred = new PredmetNastavnici();

                pred.SifraPredmeta = p.SifraPredmeta;
                pred.Nastavnik = p.ime_prezime;

                s.SaveOrUpdate(pred);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static PredmetniNastavnikBasic AzurirajProfesora(PredmetniNastavnikBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PredmetNastavnici pred = s.Load<StudentskiProjekat.Entiteti.PredmetNastavnici>(p.Id);

                pred.SifraPredmeta = p.SifraPredmeta;
                pred.Nastavnik = p.ime_prezime;

                s.Update(pred);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return p;
        }

        public static PredmetniNastavnikBasic VratiProfesora(int id)
        {
            PredmetniNastavnikBasic o = new PredmetniNastavnikBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                PredmetNastavnici pred = s.Load<StudentskiProjekat.Entiteti.PredmetNastavnici>(id);

                o = new PredmetniNastavnikBasic(pred.Id, pred.SifraPredmeta, pred.Nastavnik);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }

        public static void obrisiProfesora(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StudentskiProjekat.Entiteti.PredmetNastavnici a = s.Load<StudentskiProjekat.Entiteti.PredmetNastavnici>(id);

                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }


        #endregion

        #endregion

        #region UzeoProjekat
        public static UzeoProjekatBasic vratiOdnos(int idStudenta, int idProjekta)
        {
            UzeoProjekatBasic uzeo = new UzeoProjekatBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<UzeoProjekat> uzeoP = from o in s.Query<UzeoProjekat>()
                                         where o.Id.StudentUzeo.Index == idStudenta
                                         where o.Id.UzeoProjekat.identifikator == idProjekta
                                         select o;

                foreach (UzeoProjekat r in uzeoP)
                {
                    UzeoProjekaIDtBasic id = new UzeoProjekaIDtBasic();
                    id.Studentuzeo = DTOManager.VratiStudenta(r.Id.StudentUzeo.Index);
                    id.uzeoProjekat = DTOManager.VratiProjekat(r.Id.UzeoProjekat.identifikator);
                    uzeo = new UzeoProjekatBasic(id,r.Izabir,r.Rok,r.Zavrsetak);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return uzeo;


        }

        public static void izmeniOdnos(UzeoProjekatBasic uzeo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoProjekatId id = new UzeoProjekatId();
                id.StudentUzeo = s.Load<Student>(uzeo.Id.Studentuzeo.index);
                id.UzeoProjekat = s.Load<StudentskiProjekat.Entiteti.Projekat>(uzeo.Id.uzeoProjekat.identifikator);

                UzeoProjekat p = s.Load<UzeoProjekat>(id);
                p.Izabir = uzeo.Pocetak;
                p.Rok = uzeo.Rok;
                p.Zavrsetak = uzeo.Zavrsetak;



                s.SaveOrUpdate(p);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void ObrisiOdnos(UzeoProjekatBasic uzeo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoProjekatId id = new UzeoProjekatId();
                id.StudentUzeo = s.Load<Student>(uzeo.Id.Studentuzeo.index);
                id.UzeoProjekat = s.Load<StudentskiProjekat.Entiteti.Projekat>(uzeo.Id.uzeoProjekat.identifikator);

                UzeoProjekat p = s.Load<UzeoProjekat>(id);
                



                s.Delete(p);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }



        #endregion

        #region Izvestaji
        public static IzvestajiBasic VratiIzvestaje(int id)
        {
            IzvestajiBasic o = new IzvestajiBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Izvestaji a = s.Load<StudentskiProjekat.Entiteti.Izvestaji>(id);

                o = new IzvestajiBasic(a.Id, a.BrojIzvestaja);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }
        public static List<IzvestajBasic> vratiIzvestajeIzProj(int iden)
        {
            List<IzvestajBasic> spisak = new List<IzvestajBasic>();
            
            try
            {
                ISession s = DataLayer.GetSession();
                PrakPoj sviProj = s.Load<PrakPoj>(iden);
                
                
                if (sviProj.ImeProjekta!=null)
                {
                    foreach (Izvestaj u in sviProj.Izvestaji.izvestaji)
                    {
                        int idz = sviProj.Izvestaji.Id;

                        spisak.Add(new IzvestajBasic(u.ID, idz, u.Sadrzaj, u.Odnos));
                    }
                }
                
                
                


                s.Close();

            }
            catch (Exception ec)
            {
                System.Console.WriteLine(ec.Message);
                ISession s = DataLayer.GetSession();
                PrakGrup sviProjG = s.Load<PrakGrup>(iden);
                if (sviProjG != null)
                {
                    foreach (Izvestaj u in sviProjG.Izvestaji.izvestaji)
                    {
                        int idzG = sviProjG.Izvestaji.Id;
                        spisak.Add(new IzvestajBasic(u.ID, idzG, u.Sadrzaj, u.Odnos));
                    }
                }
            }
            return spisak;
        }
        public static int VratiGrupuI(int iden)
        {
            int z = -1;
            try
            {
                ISession s = DataLayer.GetSession();
                PrakPoj sviProj = s.Load<PrakPoj>(iden);
                
                Izvestaji i = new Izvestaji();
                if (sviProj.ImeProjekta !=null)
                {
                     i = s.Load<Izvestaji>(sviProj.Izvestaji.Id);
                }
                
                z = i.Id;

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
                ISession s = DataLayer.GetSession();
                Izvestaji i = new Izvestaji();

                PrakGrup sviProjG = s.Load<PrakGrup>(iden);

                i = s.Load<Izvestaji>(sviProjG.Izvestaji.Id);
                z = i.Id;
            }
            return z;
        }
        public static void DodajIzvestajGrupu(int iden)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Izvestaji i = new Izvestaji();
                i.Id = iden;
                i.BrojIzvestaja = 0;


                s.SaveOrUpdate(i);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static void DodajIzvestajGrupuNaProj(int iden)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrakticniPojedinacniBasic pp = DTOManager.VratiPrakPojProjekat(iden);
                PrakticniGrupniBasic pg = DTOManager.VratiPrakGrupProjekat(iden);
                IEnumerable<StudentskiProjekat.Entiteti.Izvestaji> izv = from o in s.Query<StudentskiProjekat.Entiteti.Izvestaji>() where o.BrojIzvestaja == -1 select o;
                if (pp != null)
                {
                    foreach (Izvestaji i in izv)
                    {
                        pp.i.Id = i.Id;
                        pp.i.BrojIzvestaja = 0;
                        DTOManager.AzurirajPrakPojProjekat(pp);
                    }
                }
                else
                {
                    foreach (Izvestaji i in izv)
                    {
                        pg.i.Id = i.Id;
                        pg.i.BrojIzvestaja = 0;
                        DTOManager.AzurirajPrakGrupProjekat(pg);
                    }
                }
                


               
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }



        public static void DodajIzvestaj(IzvestajBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Izvestaj i = new Izvestaj();

                i.GrupaI = a.GrupaI;
                i.Sadrzaj = a.Sadrzaj;
                i.Odnos = a.Odnos;

                s.SaveOrUpdate(i);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static IzvestajBasic AzurirajIzvestaj(IzvestajBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Izvestaj i = s.Load<StudentskiProjekat.Entiteti.Izvestaj>(a.Id);

               
                i.Sadrzaj = a.Sadrzaj;
                i.Odnos = a.Odnos;

                s.Update(i);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static IzvestajBasic VratiIzvestaj(int id)
        {
            IzvestajBasic o = new IzvestajBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Izvestaj a = s.Load<StudentskiProjekat.Entiteti.Izvestaj>(id);

                o = new IzvestajBasic(a.ID,a.GrupaI,a.Sadrzaj,a.Odnos);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }

        public static void obrisiIzvestaj(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StudentskiProjekat.Entiteti.Izvestaj a = s.Load<StudentskiProjekat.Entiteti.Izvestaj>(id);
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        #endregion

        #region SpisakWebP
        public static List<SpisakWebPojedinacniBasic> vratiSpisakWebP(int iden)
        {
            List<SpisakWebPojedinacniBasic> spisak = new List<SpisakWebPojedinacniBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                PrakPoj sviProj = s.Load<PrakPoj>(iden);

                foreach (SpisakWebP u in sviProj.Spisaks)
                {
                    spisak.Add(new SpisakWebPojedinacniBasic(u.Id,u.iden,u.WebStranica));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return spisak;
        }

        public static void DodajWebP(SpisakWebPojedinacniBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakWebP spisak = new SpisakWebP();

                spisak.Id = a.Id;
                spisak.iden = a.identifikator;
                spisak.WebStranica = a.WebStranica;

                s.SaveOrUpdate(spisak);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static SpisakWebPojedinacniBasic AzurirajWebP(SpisakWebPojedinacniBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakWebP spisak = s.Load<StudentskiProjekat.Entiteti.SpisakWebP>(a.Id);

                spisak.Id = a.Id;
                spisak.iden = a.identifikator;
                spisak.WebStranica = a.WebStranica;

                s.Update(spisak);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static SpisakWebPojedinacniBasic VratiWebP(int id)
        {
            SpisakWebPojedinacniBasic o = new SpisakWebPojedinacniBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakWebP a = s.Load<StudentskiProjekat.Entiteti.SpisakWebP>(id);

                o = new SpisakWebPojedinacniBasic(a.Id,a.iden,a.WebStranica);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }

        public static void obrisiWebP(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StudentskiProjekat.Entiteti.SpisakWebP a = s.Load<StudentskiProjekat.Entiteti.SpisakWebP>(id);
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }

        #endregion

        #region SpisakWebG
        public static List<SpisakWebGrupniBasic> vratiSpisakWebG(int iden)
        {
            List<SpisakWebGrupniBasic> spisak = new List<SpisakWebGrupniBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                PrakGrup sviProj = s.Load<PrakGrup>(iden);

                foreach (SpisakWebG u in sviProj.Spisaks)
                {
                    spisak.Add(new SpisakWebGrupniBasic(u.Id, u.iden, u.WebStranica));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return spisak;
        }

        public static void DodajWebG(SpisakWebGrupniBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakWebG spisak = new SpisakWebG();

                spisak.Id = a.Id;
                spisak.iden = a.identifikator;
                spisak.WebStranica = a.WebStranica;

                s.SaveOrUpdate(spisak);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        public static SpisakWebGrupniBasic AzurirajWebG(SpisakWebGrupniBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakWebG spisak = s.Load<StudentskiProjekat.Entiteti.SpisakWebG>(a.Id);

                spisak.Id = a.Id;
                spisak.iden = a.identifikator;
                spisak.WebStranica = a.WebStranica;

                s.Update(spisak);
                s.Flush();
                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static SpisakWebGrupniBasic VratiWebG(int id)
        {
            SpisakWebGrupniBasic o = new SpisakWebGrupniBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakWebG a = s.Load<StudentskiProjekat.Entiteti.SpisakWebG>(id);

                o = new SpisakWebGrupniBasic(a.Id, a.iden, a.WebStranica);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }

        public static void obrisiWebG(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                StudentskiProjekat.Entiteti.SpisakWebG a = s.Load<StudentskiProjekat.Entiteti.SpisakWebG>(id);
                s.Delete(a);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }
        #endregion
    }
}
