using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Assignment.Dtos;
using Assignment.Helpers;
using Assignment.Models;

namespace Assignment.Interfaces
{
    public interface IBookRepository
    {
        public Task<List<Book>> GetAllAsync(QueryObject query);
        public Task<Book?> GetByIdAsync(int id);
        public Task<Book?> UpdateBookAsync(int id, BookUpdateRequestDto bookDto);
        public Task<Book> CreateAsync(Book bookModel);
    }
}