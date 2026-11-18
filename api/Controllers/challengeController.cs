using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class challengeController : ControllerBase
    {
        private readonly IChallengeServices _challengeServices; 
        public challengeController(IChallengeServices challengeServices)
        {
            _challengeServices = challengeServices; 
        }
        [HttpGet("sayHello/{username}")]
        public IActionResult getMessage(string username){
            return Ok(new {response = _challengeServices.Greeting(username)});
        }

      
    }
}