using System.Collections.Generic;

namespace MySQL.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        List<T> GetAll();
        void Save(T item);
        void Delete(T item);
    }
}
