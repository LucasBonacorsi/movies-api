using Microsoft.AspNetCore.Mvc;

namespace ApiPeliculas.Controllers
{
    [ApiController]
    [Route("hola")]
    public class WeatherForecastController : ControllerBase
    {

        public WeatherForecastController()
        {
            System.Console.WriteLine("hola DESDE LA CONSOLA");
        }

        [HttpGet()]
        public string Get()
        { 
            return "que tal";
        }
    }
}