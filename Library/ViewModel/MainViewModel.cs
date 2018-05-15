using System;
using System.Collections.Generic;
using System.ComponentModel;
using Autofac;
using DiAutofac;
using Library.Services;
using Library.ViewModel.Commands;
using MySQL.Entities;
using MySQL.Repositories;

namespace Library.ViewModel
{
    public class MainViewModel
    {
        #region Courrent Reader

        public Reader CourrnetReader
        {
            get => _courrentReader;
            set => _courrentReader = value;
        }

        public string CourrnetReaderName
        {
            get => _courrentReader.Name;
            set
            {
                _courrentReader.Name = value;
                OnPropertyChanged(nameof(CourrnetReaderName));
            }
        }

        public string CourrnetReaderSurname
        {
            get => _courrentReader.Surname;
            set
            {
                _courrentReader.Surname = value;
                OnPropertyChanged(nameof(CourrnetReaderSurname));
            }
        }

        public DateTime CourrnetReaderBornDate
        {
            get => _courrentReader.BornDate;
            set
            {
                _courrentReader.BornDate = value;
                OnPropertyChanged(nameof(CourrnetReaderBornDate));
            }
        }

        #endregion

        #region Courrent Author

        public Author CourrnetAuthor
        {
            get => _courrentAuthor;
            set => _courrentAuthor = value;
        }

        public string CourrnetAuthorName
        {
            get => _courrentAuthor.Name;
            set
            {
                _courrentAuthor.Name = value;
                OnPropertyChanged(nameof(CourrnetAuthorName));
            }
        }

        public string CourrnetAuthorSurname
        {
            get => _courrentAuthor.Surname;
            set
            {
                _courrentAuthor.Surname = value;
                OnPropertyChanged(nameof(CourrnetAuthorSurname));
            }
        }

        public DateTime CourrnetAuthorBornDate
        {
            get => _courrentAuthor.BornDate;
            set
            {
                _courrentAuthor.BornDate = value;
                OnPropertyChanged(nameof(CourrnetAuthorBornDate));
            }
        }

        #endregion

        #region Courrent Book

        public Book CourrnetBook
        {
            get => _courrentBook;
            set => _courrentBook = value;
        }

        public string CourrnetBookTitle
        {
            get => _courrentBook.Title;
            set
            {
                _courrentBook.Title = value;
                OnPropertyChanged(nameof(CourrnetBookTitle));
            }
        }

        public string CourrnetBookIsbn
        {
            get => _courrentBook.Isbn;
            set
            {
                _courrentBook.Isbn = value;
                OnPropertyChanged(nameof(CourrnetBookIsbn));
            }
        }

        public int CourrnetBookBookType
        {
            get => (int)_courrentBook.BookType;
            set
            {
                _courrentBook.BookType = (BookType)value;
                OnPropertyChanged(nameof(CourrnetBookBookType));
            }
        }

        public DateTime CourrnetBookReleaseDate
        {
            get => _courrentBook.ReleaseDate;
            set
            {
                _courrentBook.ReleaseDate = value;
                OnPropertyChanged(nameof(CourrnetBookReleaseDate));
            }
        }

        public bool CourrnetBookBorrowed
        {
            get { return _courrentBook.Borrowed; }
            set
            {
                _courrentBook.Borrowed = value;
                OnPropertyChanged(nameof(CourrnetBookBorrowed));
            }
        }

        public Author CourrnetBookAuthor
        {
            get => _courrentBook.Author;
            set => _courrentBook.Author = value;
        }

        #endregion

        private Reader _courrentReader;
        private Author _courrentAuthor;
        private Book _courrentBook;


        #region Reader Commands

        private ICommand _saveReader;
        public ICommand SaveReader => _saveReader ?? (_saveReader = new SaveReaderCommand(this));

        private ICommand _removeReader;
        public ICommand RemoveReader => _removeReader ?? (_removeReader = new RemoveReaderCommand(this));

        #endregion

        #region Author Commands

        private ICommand _saveAuthor;
        public ICommand SaveAuthor => _saveAuthor ?? (_saveAuthor = new SaveAuthorCommand(this));

        private ICommand _removeAuthor;
        public ICommand RemoveAuthor => _removeAuthor ?? (_removeAuthor = new RemoveAuthorCommand(this));

        #endregion

        #region Book Commands

        private ICommand _saveBook;
        public ICommand SaveBook => _saveBook ?? (_saveBook = new SaveBookCommand(this));

        private ICommand _removeBook;
        public ICommand RemoveBook => _removeBook ?? (_removeBook = new RemoveBookCommand(this));

        #endregion


        public MainViewModel(){}

        #region Filtr

        public List<Reader> FiltrReader(FiltrReaderMethod filtrMethod, string filtr)
        {
            return FiltrReaders.Filtr(GetAllReaders(), filtrMethod, filtr);
        }

        public List<Author> FiltrAuthor(FiltrAuthorMethod filtrMethod, string filtr)
        {
            return FiltrAuthors.Filtr(GetAllAuthors(), filtrMethod, filtr);
        }

        public List<Book> FiltrBook(FiltrBookMethod filtrMethod, string filtr)
        {
            return FiltrBooks.Filtr(GetAllBooks(), filtrMethod, filtr);
        }

        #endregion

        #region Get

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

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
