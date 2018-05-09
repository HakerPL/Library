using System.Collections.Generic;
using Autofac;
using DiAutofac;
using MySQL.Entities;
using MySQL.Repositories;

namespace Library.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {

        }

        public List<Author> GetAllAuthors()
        {
            return DiContainer.Container.Resolve<AuthorRepository>().GetAll();
        }

        public List<Book> GetAllBooks()
        {
            return DiContainer.Container.Resolve<BookRepository>().GetAll();
        }

        public List<BookHistory> GetBookHistory(int bookId)
        {
            return DiContainer.Container.Resolve<BookHistoryRepository>().Get(bookId);
        }

        public List<Reader> GetAllReaders()
        {
            return DiContainer.Container.Resolve<ReaderRepository>().GetAll();
        }

        public List<ReaderBorrowBook> GetReaderBorrowBooks()
        {
            return DiContainer.Container.Resolve<ReaderBorrowBookRepository>().GetAll();
        }
    }
}
