using System;

using System.Linq;
using NHibernate;
using WpfApp1.entidades;
namespace WpfApp1.servicio
{
 public   class ElementoEvaluacionSignoServicio:RepositorioCG<ElementoEvaluacionSigno>
    {
        public bool validaElementoEvaluacionSigno(string nombre)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<ElementoEvaluacionSigno>()
                        where e.nombreSigno.Equals(nombre)
                        select e).Count() > 0;
            }
        }
    }
}
