using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using MySQL.Entities;

namespace MySQL.Repositories
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
            if (item.Id == 0)
                _connectDb.ReaderBorrowBook.Add(item);
            else
                _connectDb.Entry(item).State = EntityState.Modified;

            _connectDb.SaveChanges();
        }
    }
}
