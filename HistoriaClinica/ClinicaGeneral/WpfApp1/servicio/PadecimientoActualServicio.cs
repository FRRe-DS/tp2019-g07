using System;
using System.Linq;
using NHibernate;
using WpfApp1.entidades;
namespace WpfApp1.servicio
{
    public class PadecimientoActualServicio : RepositorioCG<PadecimientoActual>
    {
        public bool validarPadecimentoActual(int p, int ex)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from e in session.Query<PadecimientoActual>()
                        where
                      e.idPadecimiento.Equals(p) &&
                      e.idExpediente.Equals(ex)
                        select e).Count() > 0;
            }
        }
    }
}
