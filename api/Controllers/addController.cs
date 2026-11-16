using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class addController : ControllerBase
    {
         [HttpGet("add/{num1}/{num2}")]

        public IActionResult addNums(int num1, int num2)
        {
            return Ok(new {num1, num2, sum = num1 + num2}); 
        }
    }
}