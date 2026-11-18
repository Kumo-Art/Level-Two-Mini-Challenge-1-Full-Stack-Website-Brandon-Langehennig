using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
         private readonly IHelloServices _helloServices;

        public HelloController(IHelloServices helloServices)
        {
            _helloServices = helloServices;
        }


        [HttpGet("greeting/{name}")]

        public IActionResult Greeting(string name)
        {
            string message = _helloServices.Greeting(name);
            return Ok(new { Message = message });
        }
    }
}