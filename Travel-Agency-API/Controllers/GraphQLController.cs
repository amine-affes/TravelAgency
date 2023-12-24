using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Travel_Agency_API.Services.Dossiers;

namespace Travel_Agency_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class GraphQLController : ControllerBase
    {
        private readonly ILogger<GraphQLController> _logger;

        public GraphQLController(ILogger<GraphQLController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetDossierByClient")]
        public async Task<IActionResult> GetDossierByClient(string name, string familyName, [FromServices] IDossierService dossierService)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(familyName))
            {
                return BadRequest();
            }
                var dossier = await dossierService.GetDossierByClient(name, familyName);
            if (dossier == null)
            {
                _logger.LogWarning("Not Found ...");
                return NotFound();
            }
            return Ok(dossier);
        }
    }
}
