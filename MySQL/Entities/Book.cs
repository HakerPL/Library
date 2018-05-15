using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQL.Entities
{
    public enum BookType
    {
        SCI_FI,
        COMEDY,
        HORROR,
        ACTION,
        POETRY
    }

    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Isbn { get; set; }

        public BookType BookType { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool Borrowed { get; set; } = false;

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
