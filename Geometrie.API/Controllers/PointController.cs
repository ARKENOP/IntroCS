using Geometrie.DTO;
using Geometrie.Services;
using Microsoft.AspNetCore.Mvc;

namespace Geometrie.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PointController : ControllerBase
    {

        private readonly ILogger<PointController> _logger;
        private Point_Service _service;

        public PointController(ILogger<PointController> logger, Point_Service service)
        {
            _logger = logger;
            _service = service;
        }
        /// <summary>
        /// Retourne un point par son identifiant dans la base de données
        /// </summary>
        /// <param name="id"></param>
        /// <returns>un <see cref="Point_DTO"></see></returns>
        [HttpGet]
        public Point_DTO GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
