using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MySQL.Entities;

namespace MySQL.Repositories
{
    public class BookHistoryRepository //: IRepository<BookHistory>
    {
        private readonly ConnectDb _connectDb;
        public BookHistoryRepository(ConnectDb connectDb)
        {
            _connectDb = connectDb;
        }

        public void Delete(BookHistory item)
        {
            _connectDb.BookHistory.Remove(item);
            _connectDb.SaveChanges();
        }

        public List<BookHistory> Get(int bookId)
        {
            return _connectDb.BookHistory.Where(u => u.BookId == bookId).ToList();
        }

        public List<BookHistory> GetAll()
        {
            return _connectDb.BookHistory.ToList();
        }

        public void Save(BookHistory item)
        {
            if (item.Id == 0)
                _connectDb.BookHistory.Add(item);
            else
                _connectDb.Entry(item).State = EntityState.Modified;

            _connectDb.SaveChanges();
        }
    }
}
