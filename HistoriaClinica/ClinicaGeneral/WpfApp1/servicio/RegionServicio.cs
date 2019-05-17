using System;
using System.Linq;
using NHibernate;
using WpfApp1.entidades;

namespace WpfApp1.servicio
{
 public   class RegionServicio:RepositorioCG<Region>
    {
        public bool validaRegion(string parte)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<Region>()
                        where e.parteExplorada.Equals(parte)
                        select e).Count() > 0;
            }
        }
    }
}
