using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/weather")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
