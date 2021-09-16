using System;
using System.Collections.Generic;

#nullable disable

namespace DbContextLayer.Models
{
    public partial class BookType
    {
        public BookType()
        {
            Books = new HashSet<Book>();
        }

        public byte BookTypeId { get; set; }
        public string BookType1 { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
