using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ComparisonController : ControllerBase
    {
        [HttpGet("compare/{compOne}/{compTwo}")]

        public IActionResult Comparison(int compOne, int compTwo)
        {
            bool compare = compOne < compTwo;
            return Ok (new {compOne,compTwo, Result = compare});
        }
    }
}