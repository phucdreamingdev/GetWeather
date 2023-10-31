namespace Weather;

public class WeatherForecast
{
    public int CityId { get; set; }
    
    public string? CityName { get; set; }
    
    public string? WeatherMain { get; set; }

    public string? WeatherDescription { get; set; }

    public string? WeatherIcon
    {
        get
        {
            return $"http://openweathermap.org/img/wn/{this.WeatherIcon}@2x.png";
        }
        set
        {
            WeatherIcon = this.WeatherIcon;
        }
    }
    
    public float MainTemp { get; set; }

    public int MainHumidity { get; set; }

}