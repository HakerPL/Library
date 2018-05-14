using System.Collections.Generic;
using System.Linq;
using MySQL.Entities;

namespace Library.Services
{
    public enum FiltrReader
    {
        NAME,
        SURNAME
    }
    public class FiltrReaders
    {
        public static List<Reader> FiltReaders(List<Reader> sourceList, FiltrReader filtrMethod, string filtr)
        {
            List<Reader> list = new List<Reader>();

            switch (filtrMethod)
            {
                case FiltrReader.NAME:
                    list = sourceList.Where(r => r.Name.Contains(filtr)).ToList();
                    break;

                case FiltrReader.SURNAME:
                    list = sourceList.Where(r => r.Surname.Contains(filtr)).ToList();
                    break;
            }

            return list;
        }
    }
}
