using System;
using System.Collections.Generic;
using System.Linq;
using webapif.helper;
using NHibernate;

namespace webapif.Models.Persistance
{
    public class ServerDataRepository<T> : IServerDataRepository<T> where T: class
    {
        public ServerDataRepository()
        {

        }

        public IEnumerable<T> Get(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
                yield return session.Get<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            using (var session = NHibernateHelper.OpenSession())
                return session.Query<T>().ToList();
        }

        public bool  Add(T entidad)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(entidad);
                    transaction.Commit();
                }

                return true;
            }
        }

        public void Delete(T entidad)
        {
            //var entidad = Get(id);

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Delete(entidad);
                    transaction.Commit();
                }
            }

        }

        public bool Update(T entidad)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.SaveOrUpdate(entidad);
                    try
                    {
                        transaction.Commit();
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
                return true;
            }
        }

       
    }
}