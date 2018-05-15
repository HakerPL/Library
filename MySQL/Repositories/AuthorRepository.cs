using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MySQL.Entities;

namespace MySQL.Repositories
{
    public class AuthorRepository //: IRepository<Author>
    {
        private readonly ConnectDb _connectDb;
        public AuthorRepository(ConnectDb connectDb)
        {
            _connectDb = connectDb;
        }

        public void Delete(Author item)
        {
            _connectDb.Author.Remove(item);
            _connectDb.SaveChanges();
        }

        public Author Get(int id)
        {
            return _connectDb.Author.FirstOrDefault(u => u.Id == id);
        }

        public List<Author> GetAll()
        {
            return _connectDb.Author.ToList();
        }

        public void Save(Author item)
        {
            if (item.Id == 0)
                _connectDb.Author.Add(item);
            else
                _connectDb.Entry(item).State = EntityState.Modified;

            _connectDb.SaveChanges();
        }
    }
}
