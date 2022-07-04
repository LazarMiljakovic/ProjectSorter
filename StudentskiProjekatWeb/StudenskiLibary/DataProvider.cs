using NHibernate;
using StudentskiLibary.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate;
using NHibernate.Linq;
using System.Linq;
using StudentskiLibary;
using StudentskiLibary.Entiteti;

namespace StudentskiLibary
{
    public class DataProvider
    {
        #region Autor
        public static List<AutorView> vratiAutoraLiterature(int idl)
        {
            List<AutorView> autori = new List<AutorView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Literatura> sviAutori = from o in s.Query<Literatura>() where o.Idl == idl select o;

                foreach (Literatura u in sviAutori)
                {
                    foreach (Autor a in u.Autori)
                    {
                        autori.Add(new AutorView(a.Id, a.Ime_Prezime, a.literatura));
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



        public static void DodajAutora(AutorView a)
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
        public static AutorView AzurirajAutora(AutorView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Autor Aut = s.Load<StudentskiLibary.Entiteti.Autor>(a.Id);

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

        public static AutorView VratiAutora(int id)
        {
            AutorView o = new AutorView();
            try
            {
                ISession s = DataLayer.GetSession();
                Autor Aut = s.Load<StudentskiLibary.Entiteti.Autor>(id);

                o = new AutorView(Aut.Id, Aut.Ime_Prezime, Aut.literatura);

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
                StudentskiLibary.Entiteti.Autor a = s.Load<StudentskiLibary.Entiteti.Autor>(id);
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

        #region Studenti
        public static List<StudentView> vratiSveStudente()
        {
            List<StudentView> studenti = new List<StudentView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StudentskiLibary.Entiteti.Student> sviStudenti = from o in s.Query<StudentskiLibary.Entiteti.Student>() select o;

                foreach (Student a in sviStudenti)
                {
                    studenti.Add(new StudentView(a.Index, a.Ime, a.Ime_Roditelja, a.Prezime, a.Smer));
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
                StudentskiLibary.Entiteti.Student a = s.Load<StudentskiLibary.Entiteti.Student>(indeks);
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

        public static void dodajOdnosS_P(UzeoProjekatView uzeo)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                UzeoProjekat u = new UzeoProjekat();
                u.Id = new UzeoProjekatId();
                u.Id.StudentUzeo = s.Load<StudentskiLibary.Entiteti.Student>(uzeo.Id.Studentuzeo.index);
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

        public static List<StudentView> vratiStudenteProjekta(int iden)
        {
            List<StudentView> studenti = new List<StudentView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<UzeoProjekat> sviStudenti = from o in s.Query<UzeoProjekat>() where o.Id.UzeoProjekat.identifikator == iden select o;

                foreach (UzeoProjekat u in sviStudenti)
                {
                    studenti.Add(new StudentView(u.Id.StudentUzeo.Index, u.Id.StudentUzeo.Ime, u.Id.StudentUzeo.Ime_Roditelja, u.Id.StudentUzeo.Prezime, u.Id.StudentUzeo.Smer));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return studenti;
        }

        public static void DodajStudenta(StudentView a)
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
        public static StudentView AzurirajStudenta(StudentView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Student o = s.Load<StudentskiLibary.Entiteti.Student>(a.index);

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

        public static StudentView VratiStudenta(int ind)
        {
            StudentView o = new StudentView();
            try
            {
                ISession s = DataLayer.GetSession();
                Student a = s.Load<StudentskiLibary.Entiteti.Student>(ind);

                o = new StudentView(a.Index, a.Ime, a.Ime_Roditelja, a.Prezime, a.Smer);

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
        public static List<ProjekatView> vratiSveProjekte()
        {
            List<ProjekatView> projekti = new List<ProjekatView>();
            try
            {
                ISession s = DataLayer.GetSession();


                IEnumerable<StudentskiLibary.Entiteti.Projekat> sviProjekti = from o in s.Query<StudentskiLibary.Entiteti.Projekat>() select o;

                foreach (Projekat a in sviProjekti)
                {
                    PredmetView p = VratiPredmet(a.Predmet.Sifra);
                    projekti.Add(new ProjekatView(a.identifikator, a.ImeProjekta, a.Pocetak, p));
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
                StudentskiLibary.Entiteti.Projekat a = s.Load<StudentskiLibary.Entiteti.Projekat>(identifikator);
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

        public static void dodajOdnosP_S(UzeoProjekatView uzeo)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                UzeoProjekat u = new UzeoProjekat();
                u.Id = new UzeoProjekatId();
                u.Id.StudentUzeo = s.Load<StudentskiLibary.Entiteti.Student>(uzeo.Id.Studentuzeo.index);
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

        public static void DodajProjekat(ProjekatView a)
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
        public static ProjekatView AzurirajProjekat(ProjekatView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Projekat p = s.Load<StudentskiLibary.Entiteti.Projekat>(a.identifikator);

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

        public static ProjekatView VratiProjekat(int iden)
        {
            ProjekatView o = new ProjekatView();
            try
            {
                ISession s = DataLayer.GetSession();
                Projekat a = s.Load<StudentskiLibary.Entiteti.Projekat>(iden);

                o = new ProjekatView(a.identifikator, a.ImeProjekta, a.Pocetak, VratiPredmet(a.Predmet.Sifra));

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }





        #region TeorPoj
        public static void DodajTeorPojProjekat(TeorijskiPojView a)
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
        public static TeorijskiPojView AzurirajTeorPojProjekat(TeorijskiPojView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                TeorijskiPoj p = s.Load<StudentskiLibary.Entiteti.TeorijskiPoj>(a.identifikator);

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

        public static TeorijskiPojView VratiTeorPojProjekat(int iden)
        {
            TeorijskiPojView o = new TeorijskiPojView();
            try
            {
                ISession s = DataLayer.GetSession();
                TeorijskiPoj a = s.Load<StudentskiLibary.Entiteti.TeorijskiPoj>(iden);

                o = new TeorijskiPojView(a.identifikator, a.ImeProjekta, a.Pocetak, a.MaxBrojStranica, VratiPredmet(a.Predmet.Sifra));

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

        public static void DodajTeorGrupProjekat(TeorijskiGrupView a)
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
        public static TeorijskiGrupView AzurirajTeorGrupProjekat(TeorijskiGrupView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                TeorijskiGrup p = s.Load<StudentskiLibary.Entiteti.TeorijskiGrup>(a.identifikator);

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

        public static TeorijskiGrupView VratiTeorGrupProjekat(int iden)
        {
            TeorijskiGrupView o = new TeorijskiGrupView();
            try
            {
                ISession s = DataLayer.GetSession();
                TeorijskiGrup a = s.Load<StudentskiLibary.Entiteti.TeorijskiGrup>(iden);

                o = new TeorijskiGrupView(a.identifikator, a.ImeProjekta, a.Pocetak, a.MaxBrojStranica, VratiPredmet(a.Predmet.Sifra));

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

        public static void DodajPrakPojProjekat(PrakticniPojedinacniView a)
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
        public static PrakticniPojedinacniView AzurirajPrakPojProjekat(PrakticniPojedinacniView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrakPoj p = s.Load<StudentskiLibary.Entiteti.PrakPoj>(a.identifikator);

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

        public static PrakticniPojedinacniView VratiPrakPojProjekat(int iden)
        {
            PrakticniPojedinacniView o = new PrakticniPojedinacniView();
            try
            {
                ISession s = DataLayer.GetSession();
                PrakPoj a = s.Load<StudentskiLibary.Entiteti.PrakPoj>(iden);

                o = new PrakticniPojedinacniView(a.identifikator, a.ImeProjekta, a.Pocetak, a.KratakOpis, a.PreporuceniJezik, VratiIzvestaje(a.Izvestaji.Id), VratiPredmet(a.Predmet.Sifra));

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }

        public static void dodajUzeoPP(UzeoPPView uzeo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoPP u = new UzeoPP();
                u.Id = uzeo.Id;
                u.PrakPoj = s.Load<StudentskiLibary.Entiteti.PrakPoj>(uzeo.PrakPoj.identifikator);
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

        public static UzeoPPView izmeniUzeoPP(UzeoPPView uzeo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoPP u = s.Load<StudentskiLibary.Entiteti.UzeoPP>(uzeo.Id);
                u.Id = uzeo.Id;
                u.PrakPoj = s.Load<StudentskiLibary.Entiteti.PrakPoj>(uzeo.PrakPoj.identifikator);
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

        public static void DodajPrakGrupProjekat(PrakticniGrupniView a)
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
        public static PrakticniGrupniView AzurirajPrakGrupProjekat(PrakticniGrupniView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PrakGrup p = s.Load<StudentskiLibary.Entiteti.PrakGrup>(a.identifikator);

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

        public static PrakticniGrupniView VratiPrakGrupProjekat(int iden)
        {
            PrakticniGrupniView o = new PrakticniGrupniView();
            try
            {
                ISession s = DataLayer.GetSession();
                PrakGrup a = s.Load<StudentskiLibary.Entiteti.PrakGrup>(iden);

                o = new PrakticniGrupniView(a.identifikator, a.ImeProjekta, a.Pocetak, a.KratakOpis, a.PreporuceniJezik, VratiIzvestaje(a.Izvestaji.Id), VratiPredmet(a.Predmet.Sifra));

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }

        public static void dodajOdnosUzeoPG(UzeoPGView uzeo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoPG u = new UzeoPG();
                u.Id = uzeo.Id;
                u.PrakGrup = s.Load<StudentskiLibary.Entiteti.PrakGrup>(uzeo.PrakGrup.identifikator);
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

        public static UzeoPGView izmeniUzeoPG(UzeoPGView uzeo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoPG u = s.Load<StudentskiLibary.Entiteti.UzeoPG>(uzeo.PrakGrup.identifikator);
                u.Id = uzeo.Id;
                u.PrakGrup = s.Load<StudentskiLibary.Entiteti.PrakGrup>(uzeo.PrakGrup.identifikator);
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

        #region Predmet

        public static List<PredmetView> vratiSvePredmete()
        {
            List<PredmetView> predmeti = new List<PredmetView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StudentskiLibary.Entiteti.Predmet> sviPredmeti = from o in s.Query<StudentskiLibary.Entiteti.Predmet>() select o;

                foreach (Predmet a in sviPredmeti)
                {

                    predmeti.Add(new PredmetView(a.Sifra, a.ImePredmeta, a.Semestar, a.Katedra));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return predmeti;
        }


        public static void DodajPredmet(PredmetView a)
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
        public static PredmetView AzurirajPredmet(PredmetView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Predmet pred = s.Load<StudentskiLibary.Entiteti.Predmet>(a.Sifra);

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

        public static PredmetView VratiPredmet(int sifra)
        {
            PredmetView o = new PredmetView();
            try
            {
                ISession s = DataLayer.GetSession();
                Predmet pred = s.Load<StudentskiLibary.Entiteti.Predmet>(sifra);

                o = new PredmetView(pred.Sifra, pred.ImePredmeta, pred.Semestar, pred.Katedra);

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
                StudentskiLibary.Entiteti.Predmet a = s.Load<StudentskiLibary.Entiteti.Predmet>(sifra);
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
        public static List<PredmetNastavniciView> vratiSvePredmetneProfesore(int sifraPredmeta)
        {
            List<PredmetNastavniciView> Nastavnici = new List<PredmetNastavniciView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StudentskiLibary.Entiteti.PredmetNastavnici> predmetniNastavnici = from o in s.Query<StudentskiLibary.Entiteti.PredmetNastavnici>()
                                                                                               where o.SifraPredmeta == sifraPredmeta
                                                                                               select o;

                foreach (PredmetNastavnici a in predmetniNastavnici)
                {

                    Nastavnici.Add(new PredmetNastavniciView(a.Id, a.SifraPredmeta, a.Nastavnik));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return Nastavnici;
        }


        public static void DodajNastavnikaNapredmet(PredmetNastavniciView p)
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
        public static PredmetNastavniciView AzurirajProfesora(PredmetNastavniciView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PredmetNastavnici pred = s.Load<StudentskiLibary.Entiteti.PredmetNastavnici>(p.Id);

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

        public static PredmetNastavniciView VratiProfesora(int id)
        {
            PredmetNastavniciView o = new PredmetNastavniciView();
            try
            {
                ISession s = DataLayer.GetSession();
                PredmetNastavnici pred = s.Load<StudentskiLibary.Entiteti.PredmetNastavnici>(id);

                o = new PredmetNastavniciView(pred.Id, pred.SifraPredmeta, pred.Nastavnik);

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
                StudentskiLibary.Entiteti.PredmetNastavnici a = s.Load<StudentskiLibary.Entiteti.PredmetNastavnici>(id);

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

        #region Izvestaji
        public static IzvestajiView VratiIzvestaje(int id)
        {
            IzvestajiView o = new IzvestajiView();
            try
            {
                ISession s = DataLayer.GetSession();
                Izvestaji a = s.Load<StudentskiLibary.Entiteti.Izvestaji>(id);

                o = new IzvestajiView(a.Id, a.BrojIzvestaja);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }
        public static List<IzvestajView> vratiIzvestajeIzProj(int iden)
        {
            List<IzvestajView> spisak = new List<IzvestajView>();

            try
            {
                ISession s = DataLayer.GetSession();
                PrakPoj sviProj = s.Load<PrakPoj>(iden);


                if (sviProj.ImeProjekta != null)
                {
                    foreach (Izvestaj u in sviProj.Izvestaji.izvestaji)
                    {
                        int idz = sviProj.Izvestaji.Id;

                        spisak.Add(new IzvestajView(u.ID, idz, u.Sadrzaj, u.Odnos));
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
                        spisak.Add(new IzvestajView(u.ID, idzG, u.Sadrzaj, u.Odnos));
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
                if (sviProj.ImeProjekta != null)
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
                PrakticniPojedinacniView pp = VratiPrakPojProjekat(iden);
                PrakticniGrupniView pg = VratiPrakGrupProjekat(iden);
                IEnumerable<StudentskiLibary.Entiteti.Izvestaji> izv = from o in s.Query<StudentskiLibary.Entiteti.Izvestaji>() where o.BrojIzvestaja == -1 select o;
                if (pp != null)
                {
                    foreach (Izvestaji i in izv)
                    {
                        pp.i.Id = i.Id;
                        pp.i.BrojIzvestaja = 0;
                        AzurirajPrakPojProjekat(pp);
                    }
                }
                else
                {
                    foreach (Izvestaji i in izv)
                    {
                        pg.i.Id = i.Id;
                        pg.i.BrojIzvestaja = 0;
                        AzurirajPrakGrupProjekat(pg);
                    }
                }




            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
        }



        public static void DodajIzvestaj(IzvestajView a)
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
        public static IzvestajView AzurirajIzvestaj(IzvestajView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Izvestaj i = s.Load<StudentskiLibary.Entiteti.Izvestaj>(a.Id);


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

        public static IzvestajView VratiIzvestaj(int id)
        {
            IzvestajView o = new IzvestajView();
            try
            {
                ISession s = DataLayer.GetSession();
                Izvestaj a = s.Load<StudentskiLibary.Entiteti.Izvestaj>(id);

                o = new IzvestajView(a.ID, a.GrupaI, a.Sadrzaj, a.Odnos);

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
                StudentskiLibary.Entiteti.Izvestaj a = s.Load<StudentskiLibary.Entiteti.Izvestaj>(id);
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
        public static List<LiteraturaView> vratiSveLiteratureProjektaPoj(int iden)
        {
            List<LiteraturaView> literature = new List<LiteraturaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StudentskiLibary.Entiteti.KoristiPoj> sveLit = from o in s.Query<StudentskiLibary.Entiteti.KoristiPoj>()
                                                                           where o.TeorijskiPoj.identifikator == iden
                                                                           select o;


                foreach (KoristiPoj a in sveLit)
                {

                    literature.Add(new LiteraturaView(a.Literatura.Idl, a.Literatura.Idm));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return literature;
        }
        public static List<LiteraturaView> vratiSveLiteratureProjektaGrup(int iden)
        {
            List<LiteraturaView> literature = new List<LiteraturaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StudentskiLibary.Entiteti.KoristiGrup> sveLit = from o in s.Query<StudentskiLibary.Entiteti.KoristiGrup>()
                                                                            where o.TeorijskiGrup.identifikator == iden
                                                                            select o;


                foreach (KoristiGrup a in sveLit)
                {

                    literature.Add(new LiteraturaView(a.Literatura.Idl, a.Literatura.Idm));

                }
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return literature;
        }


        public static void DodajLiteraturu(LiteraturaView a)
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


        public static LiteraturaView VratiRadPoImenu(string ime)
        {
            LiteraturaView a = new LiteraturaView();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<StudentskiLibary.Entiteti.Rad> sveLit = from o in s.Query<StudentskiLibary.Entiteti.Rad>()
                                                                    where o.Naziv == ime
                                                                    select o;
                foreach (Rad r in sveLit)
                {
                    a = new LiteraturaView(r.Idl, r.Idm);
                }


                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static LiteraturaView VratiKnjigaPoImenu(string ime)
        {
            LiteraturaView a = new LiteraturaView();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<StudentskiLibary.Entiteti.Knjiga> sveLit = from o in s.Query<StudentskiLibary.Entiteti.Knjiga>()
                                                                       where o.Naziv == ime
                                                                       select o;
                foreach (Knjiga r in sveLit)
                {
                    a = new LiteraturaView(r.Idl, r.Idm);
                }


                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }

        public static LiteraturaView VratiClanakPoImenu(string ime)
        {
            LiteraturaView a = new LiteraturaView();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<StudentskiLibary.Entiteti.Clanak> sveLit = from o in s.Query<StudentskiLibary.Entiteti.Clanak>()
                                                                       where o.Naziv == ime
                                                                       select o;
                foreach (Clanak r in sveLit)
                {
                    a = new LiteraturaView(r.Idl, r.Idm);
                }


                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return a;
        }
        public static LiteraturaView VratiLiteraturu(int id)
        {
            LiteraturaView o = new LiteraturaView();
            try
            {
                ISession s = DataLayer.GetSession();
                Literatura lit = s.Load<StudentskiLibary.Entiteti.Literatura>(id);

                o = new LiteraturaView(lit.Idl, lit.Idm);

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


                StudentskiLibary.Entiteti.Literatura a = s.Load<StudentskiLibary.Entiteti.Literatura>(id);

                IEnumerable<StudentskiLibary.Entiteti.KoristiGrup> sveLit = from o in s.Query<StudentskiLibary.Entiteti.KoristiGrup>()
                                                                            where o.Literatura.Idl == id
                                                                            select o;
                foreach (KoristiGrup r in sveLit)
                {
                    s.Delete(r); s.Flush();

                }
                IEnumerable<StudentskiLibary.Entiteti.KoristiPoj> sveLitP = from o in s.Query<StudentskiLibary.Entiteti.KoristiPoj>()
                                                                            where o.Literatura.Idl == id
                                                                            select o;
                foreach (KoristiPoj r in sveLitP)
                {
                    s.Delete(r); s.Flush();

                }
                IEnumerable<StudentskiLibary.Entiteti.Autor> sviAut = from o in s.Query<StudentskiLibary.Entiteti.Autor>()
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

        public static void dodajOdnosLIT_TEOPoj(KoristiPojView koristi)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                KoristiPoj u = new KoristiPoj();
                u.Id = koristi.id;
                u.TeorijskiPoj = s.Load<StudentskiLibary.Entiteti.TeorijskiPoj>(koristi.TeorijskiPoj.identifikator);
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
        public static void dodajOdnosLIT_TEOGrup(KoristiGrupView koristi)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                KoristiGrup u = new KoristiGrup();
                u.Id = koristi.id;
                u.TeorijskiGrup = s.Load<StudentskiLibary.Entiteti.TeorijskiGrup>(koristi.TeorijskiGrup.identifikator);
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
        public static void DodajRad(RadView a)
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


        public static RadView VratiRad(int id)
        {
            RadView o = new RadView();
            try
            {
                ISession s = DataLayer.GetSession();
                Rad lit = s.Load<StudentskiLibary.Entiteti.Rad>(id);

                o = new RadView(lit.Idl, lit.Idm, lit.Naziv, lit.Konferencija, lit.Adresa, lit.Format);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }
        public static RadView AzurirajRad(RadView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Rad o = s.Load<StudentskiLibary.Entiteti.Rad>(a.Idl);

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
        public static void DodajKnjigu(KnjigaView a)
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


        public static KnjigaView VratiKnigu(int id)
        {
            KnjigaView o = new KnjigaView();
            try
            {
                ISession s = DataLayer.GetSession();
                Knjiga lit = s.Load<StudentskiLibary.Entiteti.Knjiga>(id);

                o = new KnjigaView(lit.Idl, lit.Idm, lit.Naziv, lit.Izdavac, lit.ISBN, lit.GodinaIzdanja);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }
        public static KnjigaView AzurirajKnjigu(KnjigaView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Knjiga o = s.Load<StudentskiLibary.Entiteti.Knjiga>(a.Idl);

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

        public static void DodajClanak(ClanakView a)
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


        public static ClanakView VratiClanak(int id)
        {
            ClanakView o = new ClanakView();
            try
            {
                ISession s = DataLayer.GetSession();
                Clanak lit = s.Load<StudentskiLibary.Entiteti.Clanak>(id);

                o = new ClanakView(lit.Idl, lit.Idm, lit.Naziv, lit.Broj, lit.Godina, lit.ISSN);

                s.Close();


            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return o;
        }
        public static ClanakView AzurirajClanak(ClanakView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Clanak o = s.Load<StudentskiLibary.Entiteti.Clanak>(a.Idl);

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

        #region UzeoProjekat
        public static UzeoProjekatView vratiOdnos(int idStudenta, int idProjekta)
        {
            UzeoProjekatView uzeo = new UzeoProjekatView();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<UzeoProjekat> uzeoP = from o in s.Query<UzeoProjekat>()
                                                  where o.Id.StudentUzeo.Index == idStudenta
                                                  where o.Id.UzeoProjekat.identifikator == idProjekta
                                                  select o;

                foreach (UzeoProjekat r in uzeoP)
                {
                    UzeoProjekatIdView id = new UzeoProjekatIdView();
                    id.Studentuzeo = VratiStudenta(r.Id.StudentUzeo.Index);
                    id.uzeoProjekat = VratiProjekat(r.Id.UzeoProjekat.identifikator);
                    uzeo = new UzeoProjekatView(id, r.Izabir, r.Rok, r.Zavrsetak);
                }

                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }

            return uzeo;


        }

        public static void izmeniOdnos(UzeoProjekatView uzeo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoProjekatId id = new UzeoProjekatId();
                id.StudentUzeo = s.Load<Student>(uzeo.Id.Studentuzeo.index);
                id.UzeoProjekat = s.Load<StudentskiLibary.Entiteti.Projekat>(uzeo.Id.uzeoProjekat.identifikator);

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
        public static void ObrisiOdnos(UzeoProjekatView uzeo)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                UzeoProjekatId id = new UzeoProjekatId();
                id.StudentUzeo = s.Load<Student>(uzeo.Id.Studentuzeo.index);
                id.UzeoProjekat = s.Load<StudentskiLibary.Entiteti.Projekat>(uzeo.Id.uzeoProjekat.identifikator);

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

        #region SpisakWebP
        public static List<SpisakWebPojedinView> vratiSpisakWebP(int iden)
        {
            List<SpisakWebPojedinView> spisak = new List<SpisakWebPojedinView>();
            try
            {
                ISession s = DataLayer.GetSession();
                PrakPoj sviProj = s.Load<PrakPoj>(iden);

                foreach (SpisakWebP u in sviProj.Spisaks)
                {
                    spisak.Add(new SpisakWebPojedinView(u.Id, u.iden, u.WebStranica));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return spisak;
        }

        public static void DodajWebP(SpisakWebPojedinView a)
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
        public static SpisakWebPojedinView AzurirajWebP(SpisakWebPojedinView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakWebP spisak = s.Load<StudentskiLibary.Entiteti.SpisakWebP>(a.Id);

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

        public static SpisakWebPojedinView VratiWebP(int id)
        {
            SpisakWebPojedinView o = new SpisakWebPojedinView();
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakWebP a = s.Load<StudentskiLibary.Entiteti.SpisakWebP>(id);

                o = new SpisakWebPojedinView(a.Id, a.iden, a.WebStranica);

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
                StudentskiLibary.Entiteti.SpisakWebP a = s.Load<StudentskiLibary.Entiteti.SpisakWebP>(id);
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
        public static List<SpisakWebGrupniView> vratiSpisakWebG(int iden)
        {
            List<SpisakWebGrupniView> spisak = new List<SpisakWebGrupniView>();
            try
            {
                ISession s = DataLayer.GetSession();
                PrakGrup sviProj = s.Load<PrakGrup>(iden);

                foreach (SpisakWebG u in sviProj.Spisaks)
                {
                    spisak.Add(new SpisakWebGrupniView(u.Id, u.iden, u.WebStranica));
                }

                s.Close();

            }
            catch (Exception ec)
            {
                Console.WriteLine(ec.Message);
            }
            return spisak;
        }

        public static void DodajWebG(SpisakWebGrupniView a)
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
        public static SpisakWebGrupniView AzurirajWebG(SpisakWebGrupniView a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakWebG spisak = s.Load<StudentskiLibary.Entiteti.SpisakWebG>(a.Id);

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

        public static SpisakWebGrupniView VratiWebG(int id)
        {
            SpisakWebGrupniView o = new SpisakWebGrupniView();
            try
            {
                ISession s = DataLayer.GetSession();
                SpisakWebG a = s.Load<StudentskiLibary.Entiteti.SpisakWebG>(id);

                o = new SpisakWebGrupniView(a.Id, a.iden, a.WebStranica);

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
                StudentskiLibary.Entiteti.SpisakWebG a = s.Load<StudentskiLibary.Entiteti.SpisakWebG>(id);
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
