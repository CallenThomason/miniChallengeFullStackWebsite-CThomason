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
    public class addController : ControllerBase
    {

          private readonly IAddServices _addServices; 
        public addController(IAddServices addServices)
        {
            _addServices = addServices; 
        }
         [HttpGet("add/{num1}/{num2}")]

        public IActionResult addNums(int num1, int num2)
        {
            return Ok(new {num1, num2, sum = _addServices.Add(num1, num2)}); 
        }
    }
}