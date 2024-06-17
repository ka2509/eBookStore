using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class BookAuthor
    {
        public int? Book_id {get; set; }
        public Book? Book {get; set; }
        public int? Author_id {get; set; }
        public Author? Author {get; set; }
        public string? Author_order {get; set; } = string.Empty;
        public decimal Royality_percentage {get; set; }
    }
}