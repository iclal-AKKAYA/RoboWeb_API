using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoboFactoryWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoboController : ControllerBase
    {
        [HttpGet("get-robo")]
        public IActionResult GetRobo() 
        {
            return Ok();
        }
    }
}
