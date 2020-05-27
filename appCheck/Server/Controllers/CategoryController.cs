using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appCheck.Server.Data;
using appCheck.Shared.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace appCheck.Server.Controllers
{
    [ApiController]
    //путь исходя из названия контроллера
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpPost("[action]")]
        public async Task Create([FromBody] Category category)
        {
            _db.Categories.Add(category);
            await _db.SaveChangesAsync();
        }
    }
}
