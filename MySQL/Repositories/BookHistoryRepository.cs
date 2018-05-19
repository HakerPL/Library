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

        public List<BookHistory> GetBook(int bookId)
        {
            return _connectDb.BookHistory.Where(u => u.BookId == bookId).ToList();
        }

        public List<BookHistory> GetReader(int readerId)
        {
            return _connectDb.BookHistory.Where(u => u.ReaderId == readerId).ToList();
        }

        public BookHistory GetLastRecord(int bookId)
        {
            return _connectDb.BookHistory.OrderByDescending(u => u.BookId == bookId).FirstOrDefault();
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
