namespace Weather;

public class JsonWeatherFromLink
{
    public JsonWeatherFromLink()
    {
        List = new HashSet<ListItem>();
    }

    public int? Cnt { get; set; }
    public IEnumerable<ListItem> List { get; set; }
}