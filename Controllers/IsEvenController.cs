using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace K.IsEven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IsEvenController : ControllerBase
    {
        private readonly ILogger<IsEvenController> _logger;

        public IsEvenController(ILogger<IsEvenController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{number}")]
        public IActionResult Get(int number)
        {
            return Ok(new IsEvenResponse { IsEven = ((number % 2) == 0) });
        }
    }

    public struct IsEvenResponse
    {
        public bool IsEven { get; set; }
    }
}
