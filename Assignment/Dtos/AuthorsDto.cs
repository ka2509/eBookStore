using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Dtos
{
    public class AuthorsDto
    {
        public string LastName {get; set; } = string.Empty;
        public string FirstName {get; set; } = string.Empty;
        public string EmailAddress {get; set; } = string.Empty;
    }
}