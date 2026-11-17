
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        [HttpGet("picker")]
        public IActionResult RestaurantPicker()
        {
           
            return Ok(new { Message = "Here are some great restaurants you might like!" });
        }
    }
}