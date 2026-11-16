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

        [HttpGet("add/{num1}/{num2}")]

        public IActionResult addNums(int num1, int num2)
        {
            return Ok(new {num1, num2, sum = num1 + num2}); 
        }

        [HttpGet("compare/{num1}/{num2}")]

        public IActionResult compareNums(int num1, int num2)
        {
            if(num1 == num2)
            {
                return Ok(new {num1, num2, compareOne = $"{num1} = {num2}", compareTwo = $"{num2} = {num1}"});
            }
            else if(num1 > num2)
            {
                 return Ok(new {num1, num2, compareOne = $"{num1} > {num2}", compareTwo = $"{num2} < {num1}"});
            }
            else
            {
                 return Ok(new {num1, num2, compareOne = $"{num1} < {num2}", compareTwo = $"{num2} > {num1}"});
            }
        }
    }
}