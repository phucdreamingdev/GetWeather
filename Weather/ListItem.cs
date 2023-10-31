namespace Weather;

public class ListItem
{
     public int? Id { get; set; }
     public string? Name { get; set; }
     
     public IEnumerable<Weather>? Weather { get; set; }
     
     public Main? Main { get; set; }
    
}