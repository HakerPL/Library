using System;
using MySQL.Entities;

namespace Library.DTO
{
    class BookHistoryDto
    {
        public string ReaderName { get; set; }

        public DateTime BorrowedDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public BookHistoryDto(BookHistory book)
        {
            BorrowedDate = book.BorrowedDate;
            ReturnDate = book.ReturnDate;
            ReaderName = $"{book.Reader.Name} {book.Reader.Surname}";
        }
    }
}
