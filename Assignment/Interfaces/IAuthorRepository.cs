using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Dtos;
using Assignment.Models;

namespace Assignment.Interfaces
{
    public interface IAuthorRepository
    {
        public Task<List<Author>> GetAll(int book_id);
        public Task<List<Author>> GetAllAsync();
        public Task<bool> AuthorExist(CreateBookAuthorDto authorDto);
        public Task<Author> AddAuthor(CreateBookAuthorDto authorDto);
        public Task<Author> GetAuthorFromName(CreateBookAuthorDto authorDto);
    }
}