using BusinessLayer.Interfaces;
using DbContextLayer.Models;
using Microsoft.EntityFrameworkCore;
using ModelsLayer.EFModels;
using ModelsLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BookRepository : IBookRepository
    {
        private readonly P1_StoreApplicationDBContext _context;

        public BookRepository(P1_StoreApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<ViewModelBook>> BookListAsync()
        {
            List<Book> books = await _context.Books.FromSqlRaw<Book>("EXECUTE GetBooks").ToListAsync();
            List<ViewModelBook> vmb = new List<ViewModelBook>();
            foreach (Book b in books)
            {
                vmb.Add(ModelMapper.BookToViewModelBook(b));
            }
            return vmb;
        }
    }
}
