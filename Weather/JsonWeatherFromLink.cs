namespace Weather;

public class JsonWeatherFromLink
{
    public int? Cnt { get; set; }

    public IEnumerable<WeatherInJson>? List { get; set; }
}