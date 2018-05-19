using System.Collections.Generic;
using System.Linq;
using Autofac;
using DiAutofac;
using Library.DTO;
using MySQL.Repositories;

namespace Library.Model
{
    class ConvertBookHistoryToBookDto
    {
        public static List<BookHistoryDto> GetBookHistory(int bookId)
        {
            return DiContainer.Container.Resolve<BookHistoryRepository>().GetBook(bookId).Select(b => new BookHistoryDto(b)).ToList();
        }
    }
}
