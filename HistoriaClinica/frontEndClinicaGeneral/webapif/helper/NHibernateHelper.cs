using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using webapif.Models.mapeo;

namespace webapif.helper
{
    public class NHibernateHelper
    {
        //private static string ConnectionString = "Server=localhost; Port=5432; User Id=postgres; Password=cs2019; Database=crudwepapi";
        private static string ConnectionString = "Server=localhost; Port=5432; User Id=postgres; Password=cs2019; Database=ClinicaGeneral";
        //private static ISessionFactory session;
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    CreateSessionFactory();

                return _sessionFactory;
            }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            //IPersistenceConfigurer configDB = PostgreSQLConfiguration.PostgreSQL82.ConnectionString(ConnectionString);
            //_sessionFactory = Fluently.Configure()
            //    .Database(configDB)
            //.Mappings(m => m.FluentMappings.AddFromAssemblyOf<ServerData>())
            //   .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
            //.BuildSessionFactory();
            if (_sessionFactory != null)
                return _sessionFactory;
            IPersistenceConfigurer configDB = PostgreSQLConfiguration.PostgreSQL82.ConnectionString(ConnectionString);
            var configMap = Fluently
                    .Configure()
                    .Database(configDB)
                    .Mappings(c => c.FluentMappings.AddFromAssemblyOf<SignoVitalMap>())
                    .Mappings(c => c.FluentMappings.AddFromAssemblyOf<SintomaGeneralMap>())
                    .Mappings(c => c.FluentMappings.AddFromAssemblyOf<ExploracionGeneralMap>())
                     .Mappings(c => c.FluentMappings.AddFromAssemblyOf<ExploracionRegionalMap>())
                      .Mappings(c => c.FluentMappings.AddFromAssemblyOf<PadecimientoActualMap>());


            _sessionFactory = configMap.BuildSessionFactory();
            return _sessionFactory;
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();

        }


    }
}