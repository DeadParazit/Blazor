using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using appCheck.Server.Data;
using appCheck.Shared.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace appCheck.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublicationController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public PublicationController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet("{id}", Name = "publication")]
        public async Task<ActionResult<Publication>> Get(int id)
        {
            return await _db.Publications.FirstOrDefaultAsync(x => x.id == id);
        }

        //create
        [HttpPost("[action]")]
        public async Task Create([FromBody] Publication publication)
        {
            _db.Publications.Add(publication);
            await _db.SaveChangesAsync();
            //return new CreatedAtRouteResult("Get", new { id = publication.id }, publication);
        }

        [HttpPost("[action]")]
        public void Allow([FromBody] Publication[] publications)
        {
            foreach(var publication in publications)
            {
                _db.Update(publication);
            }
            _db.SaveChanges();
        }

        [HttpGet("category")]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return await _db.Categories.ToListAsync();
        }
    }
}
