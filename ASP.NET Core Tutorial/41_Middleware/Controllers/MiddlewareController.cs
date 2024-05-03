using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MiddlewareController.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class WeatherForecast : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing","Bracing","Chilly","Cool","Mild","Warm","Balmy","Hot","Sweltering","Scorching"
        };
        private readonly ILogger<WeatherForecast> _loger;
        public WeatherForecast(ILogger<WeatherForecast> loger)
        {
            _loger = loger;
        }

        public int TemperatureC { get; private set; }
        public DateTime Date { get; private set; }
        public string Summary { get; private set; }

        [HttpGet]

        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(i => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(i),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();

                
        }


        }
        
    }
}
