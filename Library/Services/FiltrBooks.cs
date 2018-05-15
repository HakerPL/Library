using System.Collections.Generic;
using System.Linq;
using MySQL.Entities;

namespace Library.Services
{
    public enum FiltrBookMethod
    {
        TITLE,
        ISBN
    }
    public class FiltrBooks
    {
        public static List<Book> Filtr(List<Book> sourceList, FiltrBookMethod filtrMethod, string filtr)
        {
            List<Book> list = new List<Book>();

            switch (filtrMethod)
            {
                case FiltrBookMethod.TITLE:
                    list = sourceList.Where(r => r.Title.Contains(filtr)).ToList();
                    break;

                case FiltrBookMethod.ISBN:
                    list = sourceList.Where(r => r.Isbn.Contains(filtr)).ToList();
                    break;
            }

            return list;
        }
    }
}
