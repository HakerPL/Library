using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQL.Entities
{
    public class BookHistory
    {
        [Key]
        public int Id { get; set; }

        public DateTime BorrowedDate { get; set; }

        public DateTime ReturnDate { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }

        public Book Book { get; set; }

        [ForeignKey("Reader")]
        public int ReaderId { get; set; }

        public Reader Reader { get; set; }
    }
}