using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment.Dtos;
using Assignment.Interfaces;
using Assignment.Helpers;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("api/book")]
    public class BookController : ControllerBase
    {
        
        private readonly IBookRepository _bookRepo;
        private readonly IAuthorRepository _authorRepo;
        private readonly IPublisherRepository _publisherRepo;
        private readonly IBookAuthorRepository _bookAuthorRepo;
        public BookController(IBookRepository bookRepo, IAuthorRepository authorRepo, IPublisherRepository publisherRepo, IBookAuthorRepository bookAuthorRepo)
        {
            _bookRepo = bookRepo;
            _authorRepo = authorRepo;
            _publisherRepo = publisherRepo;
            _bookAuthorRepo = bookAuthorRepo;
        }

        [HttpGet] 
        public async Task<IActionResult> GetAll([FromQuery] QueryObject query) {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var books = await _bookRepo.GetAllAsync(query);
            if(books == null) {
                return NotFound();
            }
            var booksDto = books.Select(b => b.ToBookViewDto());
            return Ok(booksDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id) {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var book = await _bookRepo.GetByIdAsync(id);
            if(book == null) {
                return NotFound();
            }
            var bookDto = book.ToBookViewDto();
            return Ok(bookDto);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookRequestDto bookDto) {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            foreach(var authorDto in bookDto.AuthorNames) {
                if(!await _authorRepo.AuthorExist(authorDto)) {
                   await _authorRepo.AddAuthor(authorDto);
                }
            }
            
            var publisher = await _publisherRepo.GetPublisherFromName(bookDto.PublisherName);
            var bookModel = bookDto.ToBookFromCreate(publisher);
            List<BookAuthor> bookAuthors = new List<BookAuthor>();
            foreach(var authorDto in bookDto.AuthorNames) {
                var author = await _authorRepo.GetAuthorFromName(authorDto);
                var bookAuthor = new BookAuthor{
                    Book = bookModel,
                    Author = author,
                    Author_order = authorDto.Author_order,
                    Royality_percentage = authorDto.Royality_percentage
                };
                bookAuthors.Append(bookAuthor);
            }
            bookModel.BookAuthors = bookAuthors;
            var savedBook = await _bookRepo.CreateAsync(bookModel);
            return Ok(savedBook.ToBookViewDto());
        }
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] BookUpdateRequestDto bookDto) {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var bookModel = await _bookRepo.UpdateBookAsync(id, bookDto);
            if(bookModel == null) {
                return NotFound();
            }
            return Ok(bookModel.ToBookViewDto());
        }
        
    }
}