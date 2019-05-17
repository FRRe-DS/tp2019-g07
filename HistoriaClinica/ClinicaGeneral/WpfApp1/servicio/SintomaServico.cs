using System;
using System.Linq;
using NHibernate;
using WpfApp1.entidades;

namespace WpfApp1.servicio
{
 public  class SintomaServico:RepositorioCG<Sintoma>
    {
        public bool validaSintoma(string descripcion)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<Sintoma>()
                        where e.descripcion.Equals(descripcion) 
                       select e).Count() > 0;
            }
        }
    }
}
