using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MySQL.Entities;

namespace MySQL.Repositories
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
            if (item.Id == 0)
                _connectDb.Book.Add(item);
            else
                _connectDb.Entry(item).State = EntityState.Modified;

            _connectDb.SaveChanges();
        }
    }
}
