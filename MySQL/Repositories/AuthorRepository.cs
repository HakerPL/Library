using System.Collections.Generic;
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
            if (_connectDb.Author.FirstOrDefault(u => u.Id == item.Id) != null)
                _connectDb.Author.Attach(item);
            else
                _connectDb.Author.Add(item);

            _connectDb.SaveChanges();
        }
    }
}
