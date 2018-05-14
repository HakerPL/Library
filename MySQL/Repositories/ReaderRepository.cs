using System.Collections.Generic;
using System.Linq;
using MySQL.Entities;

namespace MySQL.Repositories
{
    public class ReaderRepository //: IRepository<Reader>
    {
        private readonly ConnectDb _connectDb;
        public ReaderRepository(ConnectDb connectDb)
        {
            _connectDb = connectDb;
        }

        public void Delete(Reader item)
        {
            _connectDb.Reader.Remove(item);
            _connectDb.SaveChanges();
        }

        public Reader Get(int id)
        {
            return _connectDb.Reader.FirstOrDefault(u => u.Id == id);
        }

        public List<Reader> GetAll()
        {
            return _connectDb.Reader.ToList();
        }

        public void Save(Reader item)
        {
            Reader checkClient = _connectDb.Reader.FirstOrDefault(u => u.Id == item.Id);
            if (checkClient == null)
                _connectDb.Reader.Add(item);
            else
                _connectDb.Entry(checkClient).CurrentValues.SetValues(item);

            _connectDb.SaveChanges();
        }
    }
}
