using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class challengeController : ControllerBase
    {
        [HttpGet("sayHello/{username}")]
        public IActionResult getMessage(string username){
            return Ok(new {response = $"Hello {username}"});
        }

      
    }
}