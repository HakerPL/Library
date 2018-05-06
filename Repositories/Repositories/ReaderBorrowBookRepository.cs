using System.Collections.Generic;
using System.Linq;
using MySQL;
using MySQL.Entities;

namespace Repositories.Repositories
{
    public class ReaderBorrowBookRepository //: IRepository<ReaderBorrowBook>
    {
        private readonly ConnectDb _connectDb;
        public ReaderBorrowBookRepository(ConnectDb connectDb)
        {
            _connectDb = connectDb;
        }

        public void Delete(ReaderBorrowBook item)
        {
            _connectDb.ReaderBorrowBook.Remove(item);
            _connectDb.SaveChanges();
        }

        public List<ReaderBorrowBook> GetAll()
        {
            return _connectDb.ReaderBorrowBook.ToList();
        }

        public void Save(ReaderBorrowBook item)
        {
            if (_connectDb.ReaderBorrowBook.FirstOrDefault(u => u.BookId == item.BookId && u.ReaderId == item.ReaderId) != null)
                _connectDb.ReaderBorrowBook.Attach(item);
            else
                _connectDb.ReaderBorrowBook.Add(item);

            _connectDb.SaveChanges();
        }
    }
}
