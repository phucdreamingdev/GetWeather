namespace Weather;

public class ResultObject
{
    public ResultObject()
    {
        Data = new HashSet<WeatherForecast>();
    }
    public IEnumerable<WeatherForecast>? Data { get; set; }
    
    public string? Message { get; set; }
    
    public int? StatusCode { get; set; }
}