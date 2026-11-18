using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MadLibController : ControllerBase
    {
        [HttpGet("lib)")] 

        public IActionResult MadLIb(string noun, string verb, string adjective, string adverb)
        {
            return Ok (new {Message = "The " + adjective + " " + noun + " " + verb + " to the store " + adverb + "."});
        }
    }
}