using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Assignment.Interfaces;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Repository
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly DataContext _context;
        public PublisherRepository(DataContext context)
        {
            _context = context;
        }

        public Task<List<Publisher>> GetAllAsync()
        {
            var pubs = _context.Publishers.ToListAsync();
            if(pubs == null) {
                return null;
            }
            return pubs;
        }
        public async Task<Publisher> GetPublisherFromName(string publisherName) {
            var publisher = await _context.Publishers.FirstOrDefaultAsync(p => p.Publisher_name == publisherName);
            if(publisher == null) {
                return null;
            }
            return publisher;
        }
    }
}