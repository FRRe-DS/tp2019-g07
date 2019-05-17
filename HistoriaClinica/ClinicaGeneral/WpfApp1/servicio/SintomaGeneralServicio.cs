using System;
using System.Linq;
using NHibernate;
using WpfApp1.entidades;

namespace WpfApp1.servicio
{
    public class SintomaGeneralServicio : RepositorioCG<SintomaGeneral>
    {
        public static void addSintomaGeneral(SintomaGeneral sg)
        {
           
        }

        public  bool validaSintomaGeneral(SintomaGeneral sg)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<SintomaGeneral>() where
                                                                e.codigoSintoma.Equals(sg.codigoSintoma) &&
                                                                e.idExpediente.Equals(sg.idExpediente) &&
                                                                e.idSintomaGeneral.Equals(sg.idSintomaGeneral)
                                                                select e).Count() > 0;
            }
        }
    }
}
