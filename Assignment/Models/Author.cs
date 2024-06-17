using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Author
    {
        [Key]
        public int Author_id {get; set; }
        public string Last_name {get; set; } = string.Empty;
        public string First_name {get; set; } = string.Empty;
        public string Phone {get; set; } = string.Empty;
        public string Address {get; set; } = string.Empty;
        public string City {get; set; } = string.Empty;
        public string State {get; set; } = string.Empty;
        public string Zip {get; set; } = string.Empty;
        public string? Email_address {get; set; }

        public List<BookAuthor> BookAuthors {get; set; } = new List<BookAuthor>();
    }
}