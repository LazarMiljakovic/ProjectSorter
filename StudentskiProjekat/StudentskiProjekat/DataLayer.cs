using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using StudentskiProjekat.Mapiranje;

namespace StudentskiProjekat
{
    class DataLayer
    {
        private static ISessionFactory factory = null;
        private static object ObjLock = new object();

        public static ISession GetSession()
        {
            if (factory == null)
            {
                lock (ObjLock)
                {
                    if (factory == null)
                    {
                        factory = CreteSessionFactory();
                    }
                }
            }
            return factory.OpenSession();
        }

        private static ISessionFactory CreteSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                    .ConnectionString(c =>
                        c.Is("DATA SOURCE=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User id=S17796;Password=Batabe123;Connection Timeout=900"));

                return Fluently.Configure()
                    .Database(cfg.ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<PredmetMapiranje>())
                    .BuildSessionFactory();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
