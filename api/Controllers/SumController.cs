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
    public class SumController : ControllerBase
    {

        private readonly ISumServices _sumServices;

        public SumController(ISumServices sumServices)
        {
            _sumServices = sumServices;
        }

        [HttpGet("addition/{numOne}/{numTwo}")]

        public IActionResult Addition(int numOne,int numTwo)
        {
            int sum = _sumServices.Addition(numOne, numTwo);
            
            return Ok (new {numOne,numTwo, Result = sum});
        }
    }
}