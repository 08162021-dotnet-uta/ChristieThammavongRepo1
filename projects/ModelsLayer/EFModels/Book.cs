using System;
using System.Collections.Generic;

#nullable disable

namespace DbContextLayer.Models
{
    public partial class Book
    {
        public Book()
        {
            Orders = new HashSet<Order>();
        }

        public byte BookId { get; set; }
        public byte BookTypeId { get; set; }
        public byte BookGenreId { get; set; }
        public decimal BookPrice { get; set; }
        public byte QuantityAvailable { get; set; }

        public virtual BookGenre BookGenre { get; set; }
        public virtual BookType BookType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
