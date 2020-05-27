using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appCheck.Server.Data;
using appCheck.Shared.Model;
using Microsoft.AspNetCore.Mvc;

namespace appCheck.Server.Controllers
{
    [ApiController]
    [Route("IndexList")]
    public class IndexController : Controller
    {
        private readonly ApplicationDbContext _db;

        public IndexController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("publications")]
        public IEnumerable<Publication> GetPublications()
        {
            var result = _db.Publications.ToList();
            return _db.Publications.ToList();
        }
    }
}
