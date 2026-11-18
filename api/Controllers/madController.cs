
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class madController : ControllerBase
    {
         private readonly IMadServices _madServices; 
        public madController(IMadServices madServices)
        {
            _madServices = madServices; 
        }
         [HttpGet("create/{name}/{animal}/{another}/{num}/{noun}/{color}/{verb}/{place}/{adj}/{food}")]
        public IActionResult getMessage(string name, string animal, string another, int num, string noun, string color, string verb, string place, string adj, string food){
            return Ok(new {response = _madServices.madLib(name, animal, another, num, noun, color, verb, place, adj, food)});
        }

    }
}