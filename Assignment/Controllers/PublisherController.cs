using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Interfaces;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.Controllers
{
    [ApiController]
    [Route("api/publisher")]
    public class PublisherController :ControllerBase
    {
        private readonly IPublisherRepository _publisherRepo;

        public PublisherController(IPublisherRepository publisherRepo)
        {
            _publisherRepo = publisherRepo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync() {
            var pubs = _publisherRepo.GetAllAsync();
            if(pubs == null) {
                return NotFound();
            }
            return Ok(pubs);
        }
    }
}