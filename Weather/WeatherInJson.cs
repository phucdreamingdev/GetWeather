namespace Weather;

public class WeatherInJson
{
    public int? Id { get; set; }
    
    public string? Name { get; set; }
    
    public Weather? Weather { get; set; }
    
    public Main? Main { get; set; }
    
}