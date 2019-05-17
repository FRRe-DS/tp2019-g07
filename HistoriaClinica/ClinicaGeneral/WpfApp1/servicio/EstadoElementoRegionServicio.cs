using System;
using System.Linq;
using NHibernate;
using WpfApp1.entidades;

namespace WpfApp1.servicio
{
 public   class EstadoElementoRegionServicio:RepositorioCG<EstadoElementoRegion>
    {
        public bool validaEstadoElementoRegion(string nombre)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<EstadoElementoRegion>()
                        where e.nomestadoelto.Equals(nombre)
                        select e).Count() > 0;
            }
        }

    }
    
}
