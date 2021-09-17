using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.ViewModels
{
    /// <summary>
    /// ViewModelBook displays BookTypeID, BookGenreID, BookPrice and QuantityAvailable
    /// </summary>
    public class ViewModelBook
    {
        public byte VBookTypeId { get; set; }
        public byte VBookGenreId { get; set; }
        public decimal VBookPrice { get; set; }
        public byte VQuantityAvailable { get; set; }

        /// <summary>
        /// In case the Stored Procedure returns BookType as a string
        /// as they are FKs in the Book table
        /// </summary>
        [StringLength(100, MinimumLength = 1)]
        public string VBookType { get; set; }

        /// <summary>
        /// In case the Stored Procedure returns BookGenre as a string
        /// as they are FKs in the Book table
        /// </summary>
        [StringLength(100, MinimumLength = 1)]
        public string VBookGenre { get; set; }
    }
}
