using System.ComponentModel.DataAnnotations.Schema;

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public string Country { get; set; } // Add a property to identify the country
    public int Price { get; set; }
    
}
