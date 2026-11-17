using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SumController : ControllerBase
    {
        [HttpGet("addition/{numOne}/{numTwo}")]

        public IActionResult Addition(int numOne,int numTwo)
        {
            int sum = numOne + numTwo;
            return Ok (new {numOne,numTwo, Result = sum});
        }
    }
}