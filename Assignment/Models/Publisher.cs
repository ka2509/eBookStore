using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public class Publisher
    {
        [Key]
        public int Pub_id {get; set; }
        public string Publisher_name {get; set; } = string.Empty;
        public string City {get; set; } = string.Empty;
        public string State {get; set; } = string.Empty;
        public string Country {get; set; } = string.Empty;
        // One-To-Many
        public List<Book> Books {get; set; } = new List<Book>();
    }
}