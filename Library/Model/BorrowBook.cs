using System;
using Autofac;
using DiAutofac;
using MySQL.Entities;
using MySQL.Repositories;

namespace Library.Model
{
    class BorrowBook
    {
        public static void Borrow(Book book, Reader reader)
        {
            BookHistory history = new BookHistory();
            history.BorrowedDate = DateTime.Today;
            history.Book = book;
            history.Reader = reader;

            DiContainer.Container.Resolve<BookHistoryRepository>().Save(history);
        }
    }
}
