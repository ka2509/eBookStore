using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Interfaces;
using Assignment.Models;

namespace Assignment.Repository
{
    public class BookAuthorRepository : IBookAuthorRepository
    {
        private readonly DataContext _context;
        public BookAuthorRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<BookAuthor> SaveBookAuthor(BookAuthor bookAuthor)
        {
            await _context.BookAuthors.AddAsync(bookAuthor);
            await _context.SaveChangesAsync();
            return bookAuthor;
    
        }
    }
}