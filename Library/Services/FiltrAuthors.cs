using System.Collections.Generic;
using System.Linq;
using MySQL.Entities;

namespace Library.Services
{
    public enum FiltrAuthorMethod
    {
        NAME,
        SURNAME
    }
    public class FiltrAuthors
    {
        public static List<Author> Filtr(List<Author> sourceList, FiltrAuthorMethod filtrMethod, string filtr)
        {
            List<Author> list = new List<Author>();

            switch (filtrMethod)
            {
                case FiltrAuthorMethod.NAME:
                    list = sourceList.Where(r => r.Name.Contains(filtr)).ToList();
                    break;

                case FiltrAuthorMethod.SURNAME:
                    list = sourceList.Where(r => r.Surname.Contains(filtr)).ToList();
                    break;
            }

            return list;
        }
    }
}
