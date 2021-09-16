using System;
using System.Collections.Generic;

#nullable disable

namespace DbContextLayer.Models
{
    public partial class BookGenre
    {
        public BookGenre()
        {
            Books = new HashSet<Book>();
        }

        public byte BookGenreId { get; set; }
        public string BookGenre1 { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
