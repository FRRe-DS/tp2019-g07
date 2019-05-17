using System;
using System.Linq;
using NHibernate;
using WpfApp1.entidades;

namespace WpfApp1.servicio
{
 public   class SignoVitalServicio:RepositorioCG<SignoVital>
    {
        public bool validarSignoVital(SignoVital st)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<SignoVital>()
                        where
                      e.idSignoVital.Equals(st.idSignoVital) &&
                      e.idExpediente.Equals(st.idExpediente) &&
                      e.idSignoEvaluar.Equals(st.idSignoEvaluar)
                        select e).Count() > 0;
            }
        }
    }
}
