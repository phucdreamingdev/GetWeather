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
    public ResultObject Get()
    {
        //Generate new object result
        var result = new ResultObject();
        try
        {
            // Get Json from link
             var json = new WebClient().DownloadString("http://api.openweathermap.org/data/2.5/group?id=" +
                                                       "1580578,1581129,1581297,1581188,1587923&units=metric&appid=91b7466cc" +
                                                       "755db1a94caf6d86a9c788a");

            // Deserialize the JSON string to Object
            var weather = JsonConvert.DeserializeObject<JsonWeatherFromLink>(json);
            if (weather.Cnt != 0)
            {
                
                //Generate new List 
                var data = new HashSet<WeatherForecast>();

                foreach (var placeWeather in weather.List)
                {
                    data.Add(new WeatherForecast()
                    {
                        CityId = placeWeather.Id,
                        CityName = placeWeather.Name,
                        WeatherMain = placeWeather.Weather.Select(item => item).FirstOrDefault().Main,
                        WeatherDescription = placeWeather.Weather.Select(item => item).FirstOrDefault().Description,
                        WeatherIcon = $"http://openweathermap.org/img/wn/{placeWeather.Weather.Select(item => item).FirstOrDefault().Icon}@2x.png",
                        MainTemp = placeWeather.Main.Temp,
                        MainHumidity = placeWeather.Main.Humidity
                    });
                }

                result.Data = data;
                result.StatusCode = (int)HttpStatusCode.OK;
                result.Message = "Current weather information of cities";
            }

        }
        catch (Exception e)
        {
            return new ResultObject()
            {
                Data = null,
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Message = e.Message
            };
        }
        
        return result;
    }
}