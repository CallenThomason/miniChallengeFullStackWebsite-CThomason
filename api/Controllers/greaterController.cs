using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class greaterController : ControllerBase
    {
            private readonly IGreaterServices _greaterServices; 
        public greaterController(IGreaterServices greaterServices)
        {
            _greaterServices = greaterServices; 
        }
          [HttpGet("compare/{num1}/{num2}")]

        public IActionResult compareNums(int num1, int num2)
        {
            
          
                return Ok(new {num1, num2, compareOne = _greaterServices.CheckOne(num1, num2), compareTwo = _greaterServices.CheckTwo(num1, num2)});
         
        }
    }
}