using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitController : ControllerBase
    {
        List<string> _fruit = new List<string>
        {
            "Pear",
            "Lemon",
            "Peach"
        };

        [HttpGet("fruit")] // Define the route template to call the action.
        public IEnumerable<string> Index()
        {
            return _fruit;
        }
    }
}
