using NHibernate;
using System;
using System.Collections.Generic;
using NHibernate.Linq;
using System.Linq;


namespace WpfApp1
{
    /// <summary>
    /// clase que implemeta las operaciones basica sobre la base de datos(CRUD)
    /// </summary>
    public class RepositorioCG<T> : IclinicaGeneralCRUD<T> where T : class
    {
        public void Acutalizar(T entidade)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                using (ITransaction transaccion = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transaccion.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaccion.WasCommitted)
                        {
                            transaccion.Rollback();
                        }
                        throw new Exception("Error al actualizar los datos : " + ex.Message);
                    }
                }
            }
        }

        public IList<T> Consultar()
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return (from c in session.Query<T>() select c).ToList();
            }
        }

        public void Excluir(T entidade)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                using (ITransaction transaccion = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                        transaccion.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaccion.WasCommitted)
                        {
                            transaccion.Rollback();
                        }
                        throw new Exception("Error al interar borrar un registro : " + ex.Message);
                    }
                }
            }
        }

        public void Insetar(T entidade)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                using (ITransaction transaccion = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidade);
                        transaccion.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaccion.WasCommitted)
                        {
                            transaccion.Rollback();
                        }
                        throw new Exception("Error al insertar datos : " + ex.Message);
                    }
                }
            }
        }

        public T RetornarPorId(int Id)
        {
            using (ISession session = SessionFactory.AbrirSession())
            {
                return session.Get<T>(Id);
            }
        }
    }
}
