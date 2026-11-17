using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet("greeting/{name}")]

        public IActionResult Greeting(string name)
        {
            return Ok (new{ Message = "Hello " + name + " nice to meet you."});
        }
    }
}