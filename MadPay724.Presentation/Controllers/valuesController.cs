using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MadPay724.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class valuesController : ControllerBase
    {

        [HttpGet]
        public async Task< ActionResult<IEnumerable<string>>> Gett()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            return "value";
        }
        [HttpPost]
        public async Task<string> Post([FromBody] string value)
        {
            return null;
        }
        [HttpPut("{id}")]
        public async Task<string> Put(int id , [FromBody] string value)
        {
            return null;
        }
        [HttpDelete]
        public async Task<string> Delete(int id)
        {
            return null;
        }

         private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<valuesController> _logger;

        public valuesController(ILogger<valuesController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
