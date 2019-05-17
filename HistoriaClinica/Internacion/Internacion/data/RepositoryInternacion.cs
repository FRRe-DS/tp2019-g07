using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Internacion.data
{
    public class RepositoryInternacion<T> : InterfaceInternacion<T> where T : class

    {
        internal DbContext _context;

        public RepositoryInternacion()
        {
          //  using (var dbc = new InternacContext()) {
          //      _context = dbc;
          //};
           
        }

        public RepositoryInternacion(DbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            using (var dataContext = new InternacContext())
            { dataContext.Set<T>().Add(entity);
                dataContext.SaveChanges();
            }
           
        }

        public void Delete(T entity)
        {
            using (var dataContext = new InternacContext())
            {
                dataContext.Set<T>().Remove(entity);
                dataContext.SaveChanges();
            }
            }

        public void Edit(T entity)
        {
            using (var dataContext = new InternacContext())
            {

                dataContext.Entry(entity).State = EntityState.Modified;
                dataContext.SaveChanges();
            }
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            using (var dataContext = new InternacContext())

            {
                IQueryable<T> query = dataContext.Set<T>().Where(predicate);
                return query;
            }
        }

        public IQueryable<T> GetAll()
        {
            using (var dataContext = new InternacContext())

            {
                IQueryable<T> query = dataContext.Set<T>();
                return query;
            }
        }

        public void Save()
        {
            //dataContext.SaveChanges();
        }
    }
}
