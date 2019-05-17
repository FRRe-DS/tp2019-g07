using System;
using System.Linq;
using NHibernate;
using WpfApp1.entidades;

namespace WpfApp1.servicio
{
   public class ElementoGeneralServicio:RepositorioCG<ElementoGeneral>
    {
        public bool validaElementoGeneral(string nombre)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<ElementoGeneral>()
                        where e.nombreelto.Equals(nombre)
                        select e).Count() > 0;
            }
        }
    }
}
