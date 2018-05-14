using System;
using System.ComponentModel.DataAnnotations;

namespace MySQL.Entities
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BornDate { get; set; }
    }
}
