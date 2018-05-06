using System.Collections.Generic;
using System.Linq;
using MySQL;
using MySQL.Entities;

namespace Repositories.Repositories
{
    public class BookRepository //: IRepository<Book>
    {
        private readonly ConnectDb _connectDb;
        public BookRepository(ConnectDb connectDb)
        {
            _connectDb = connectDb;
        }

        public void Delete(Book item)
        {
            _connectDb.Book.Remove(item);
            _connectDb.SaveChanges();
        }

        public Book Get(int id)
        {
            return _connectDb.Book.FirstOrDefault(u => u.Id == id);
        }

        public List<Book> GetAll()
        {
            return _connectDb.Book.ToList();
        }

        public void Save(Book item)
        {
            if (_connectDb.Book.FirstOrDefault(u => u.Id == item.Id) != null)
                _connectDb.Book.Attach(item);
            else
                _connectDb.Book.Add(item);

            _connectDb.SaveChanges();
        }
    }
}
