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
    public class RestaurantController : ControllerBase
    {

        private readonly IRestaurantServices _RestaurantServices;
        public RestaurantController(IRestaurantServices restaurantServices)
        {
            _RestaurantServices = restaurantServices;
      
      
        }
        [HttpGet("{choice}")]
        public IActionResult GetMessage(string choice)
        {


            return Ok(new { response = "you should eat at " + _RestaurantServices.ResAns(choice) });
        }
    }
}
