using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySQL.Entities
{
    public enum TYPE
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

        public TYPE Type { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool Borrowed { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
