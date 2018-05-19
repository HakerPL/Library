using System;
using MySQL.Entities;

namespace Library.DTO
{
    class ReaderHistoryDto
    {
        public string BookTitle { get; set; }

        public DateTime BorrowedDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public ReaderHistoryDto(BookHistory book)
        {
            BorrowedDate = book.BorrowedDate;
            ReturnDate = book.ReturnDate;
            BookTitle = book.Book.Title;
        }
    }
}
