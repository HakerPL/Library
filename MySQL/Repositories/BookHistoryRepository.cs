using System.Collections.Generic;
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

        public BookHistory Get(int id)
        {
            return _connectDb.BookHistory.FirstOrDefault(u => u.Id == id);
        }

        public List<BookHistory> GetAll()
        {
            return _connectDb.BookHistory.ToList();
        }

        public void Save(BookHistory item)
        {
            if (_connectDb.BookHistory.FirstOrDefault(u => u.Id == item.Id) != null)
                _connectDb.BookHistory.Attach(item);
            else
                _connectDb.BookHistory.Add(item);

            _connectDb.SaveChanges();
        }
    }
}
