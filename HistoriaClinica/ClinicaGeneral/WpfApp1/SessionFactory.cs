using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
namespace WpfApp1
{
    /// <summary>
    /// Establece la conexion con la base de datos y el mapeo entre las clases y la tablas
    /// </summary>
    public class SessionFactory
    {
        private static string ConnectionString = "Server=localhost; Port=5432; User Id=postgres; Password=cs2019; Database=ClinicaGeneral";
        private static ISessionFactory session;
        public static ISessionFactory CriarSession()
        {
            if (session != null)
                return session;
            IPersistenceConfigurer configDB = PostgreSQLConfiguration.PostgreSQL82.ConnectionString(ConnectionString);
            var configMap = Fluently
                    .Configure()
                    .Database(configDB)
                                        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<mapeo.ElementoEvaluacionSignoMap>())
                                        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<mapeo.ElementoGeneralMap>())
                                        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<mapeo.ElementoRegionalEvaluarMap>())
                                        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<mapeo.ExploracionGeneralMap>())
                                        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<mapeo.ExploracionRegionalMap>())
                                        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<mapeo.PadecimientoActualMap>())
                                        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<mapeo.RegionMap>())
                                        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<mapeo.SignoVitalMap>())
                                        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<mapeo.SintomaGeneralMap>())
                                        .Mappings(c => c.FluentMappings.AddFromAssemblyOf<mapeo.SintomaMap>());
                                       
            session = configMap.BuildSessionFactory();
            return session;
        }
        public static ISession AbrirSession()
        {
            return CriarSession().OpenSession();
        }
    }
}
