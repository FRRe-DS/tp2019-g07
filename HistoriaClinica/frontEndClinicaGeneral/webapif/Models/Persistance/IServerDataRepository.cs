using System.Collections.Generic;

namespace webapif.Models.Persistance
{
    public interface IServerDataRepository<T>
    {
        IEnumerable<T> Get(int id);
        IEnumerable<T> GetAll();
        bool Add(T entidad);
        void Delete(T entidad);
        bool Update(T entidad);
       
    }
}
