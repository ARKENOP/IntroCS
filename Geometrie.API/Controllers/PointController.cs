using Microsoft.AspNetCore.Mvc;

namespace Geometrie.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PointController : ControllerBase
    {

        private readonly ILogger<PointController> _logger;

        public PointController(ILogger<PointController> logger)
        {
            _logger = logger;
        }
    }
}
