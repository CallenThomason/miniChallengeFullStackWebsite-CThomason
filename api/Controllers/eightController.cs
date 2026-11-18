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
    public class eightController : ControllerBase
    {
             private readonly IEightServices _eightServices; 
        public eightController(IEightServices eightServices)
        {
            _eightServices = eightServices; 
        }
         [HttpGet("response")]
        public IActionResult getMessage(){
           
           
            return Ok(new {response = _eightServices.RandomAns()});
        }
    }
}