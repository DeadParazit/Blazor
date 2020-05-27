using appCheck.Server.Data;
using appCheck.Shared.Model;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appCheck.Server.Controllers
{
    public class OidcConfigurationController : Controller
    {
        private readonly ILogger<OidcConfigurationController> _logger;
        private readonly ApplicationDbContext _db;

        public OidcConfigurationController(IClientRequestParametersProvider clientRequestParametersProvider, ILogger<OidcConfigurationController> logger, ApplicationDbContext db)
        {
            ClientRequestParametersProvider = clientRequestParametersProvider;
            _logger = logger;

            _db = db;
        }

        public IClientRequestParametersProvider ClientRequestParametersProvider { get; }

        [HttpGet("_configuration/{clientId}")]
        public IActionResult GetClientRequestParameters([FromRoute]string clientId)
        {
            var parameters = ClientRequestParametersProvider.GetClientParameters(HttpContext, clientId);
            return Ok(parameters);
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

        [HttpGet("publications_2")]
        public async Task<ActionResult<List<Publication>>> GetPublications_2()
        {
            return await _db.Publications.ToListAsync();
        }
    }
}
