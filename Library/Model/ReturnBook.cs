using System;
using Autofac;
using DiAutofac;
using MySQL.Entities;
using MySQL.Repositories;

namespace Library.Model
{
    class ReturnBook
    {
        public static bool ReaderReturnBook(int bookId)
        {
            BookHistory history = DiContainer.Container.Resolve<BookHistoryRepository>().GetLastRecord(bookId);

            if (history == null)
                return false;

            history.ReturnDate = DateTime.Today;
            DiContainer.Container.Resolve<BookHistoryRepository>().Save(history);

            return true;
        }
    }
}
