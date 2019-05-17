using System;
using System.Linq;
using NHibernate;
using WpfApp1.entidades;

namespace WpfApp1.servicio
{
 public   class ElementoRegionalEvaluraServicio:RepositorioCG<ElementoRegionalEvaluar>
    {
        public bool validaElementoRegionalEvaluar(string nombre)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<ElementoRegionalEvaluar>()
                        where e.nombreEltoExplorado.Equals(nombre)
                        select e).Count() > 0;
            }
        }
    }
}
