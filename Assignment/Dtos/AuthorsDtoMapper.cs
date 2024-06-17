using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;

namespace Assignment.Dtos
{
    public static class AuthorsDtoMapper
    {
        public static AuthorsDto ToAuthorsDto(this Author authorModel) {
            return new AuthorsDto {
                FirstName = authorModel.First_name,
                LastName = authorModel.Last_name,
                EmailAddress = authorModel.Email_address
            };
        }
    }
}