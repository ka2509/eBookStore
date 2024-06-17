using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;

namespace Assignment.Interfaces
{
    public interface IBookAuthorRepository
    {
        public Task<BookAuthor> SaveBookAuthor(BookAuthor bookAuthor);
    }
}