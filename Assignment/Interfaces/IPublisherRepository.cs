using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Models;

namespace Assignment.Interfaces
{
    public interface IPublisherRepository
    {
        public Task<List<Publisher>> GetAllAsync();
        public Task<Publisher> GetPublisherFromName(string publisherName);
    }
}