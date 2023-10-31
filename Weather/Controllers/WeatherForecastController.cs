using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Weather.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    public WeatherForecastController()
    {
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<ResultObject> Get()
    {
        //Get Json from link
        var json = new WebClient().DownloadString("http://api.openweathermap.org/data/2.5/group?id=" +
                                                  "1580578,1581129,1581297,1581188,1587923&units=metric&appid=91b7466cc" +
                                                  "755db1a94caf6d86a9c788a");
        //Convert Json data to object
        object? jsonDeserilized = JsonConvert.DeserializeObject(json);
        return null;
    }
}