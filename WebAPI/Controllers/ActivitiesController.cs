using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class ActivitiesController : ControllerBase
{
    private static List<Event> Events = new List<Event>
    {
        new Event { Name = "Legoland", ImageUrl = "/images/Copenhagen.jpg", Description = "Experience Legoland in Billund", Country = "Denmark" },
        new Event { Name = "Tivoli", ImageUrl = "/images/Copenhagen.jpg", Description = "Experience Tivoli in Copenhagen", Country = "Denmark" },
        new Event { Name = "Kongelige teater", ImageUrl = "/images/Copenhagen.jpg", Description = "Experience Kongelig theater in Copenhagen", Country = "Denmark" },
        new Event { Name = "Jellingestenen", ImageUrl = "Aarhus.jpg", Description = "Experience Jellingestenen in Sydjylland", Country = "Denmark" },
        new Event { Name = "Hotel Berlin", ImageUrl = "https://via.placeholder.com/150", Description = "An upscale hotel near Brandenburg Gate.", Country = "Germany" },
        new Event { Name = "Hotel Munich", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Munich.", Country = "Germany" },
        new Event { Name = "Hotel Paris", ImageUrl = "https://via.placeholder.com/150", Description = "A romantic hotel with views of the Eiffel Tower.", Country = "France" },
        new Event { Name = "Hotel Lyon", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Lyon.", Country = "France" },
        new Event { Name = "Hotel Rome", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in the city center.", Country = "Italy" },
        new Event { Name = "Hotel Milan", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in Milan.", Country = "Italy" },
        new Event { Name = "Hotel Barcelona", ImageUrl = "https://via.placeholder.com/150", Description = "A vibrant hotel near the beach.", Country = "Spain" },
        new Event { Name = "Hotel Madrid", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in Madrid.", Country = "Spain" },
        new Event { Name = "Hotel London", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in the capital.", Country = "UK" },
        new Event { Name = "Hotel Manchester", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Manchester.", Country = "UK" },
        new Event { Name = "Hotel New York", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in the city.", Country = "USA" },
        new Event { Name = "Hotel Los Angeles", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in Los Angeles.", Country = "USA" },
        new Event { Name = "Hotel Toronto", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in the heart of the city.", Country = "Canada" },
        new Event { Name = "Hotel Vancouver", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Vancouver.", Country = "Canada" },
        new Event { Name = "Hotel Sydney", ImageUrl = "https://via.placeholder.com/150", Description = "A luxury hotel with views of the harbor.", Country = "Australia" },
        new Event { Name = "Hotel Melbourne", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in Melbourne.", Country = "Australia" },
        new Event { Name = "Hotel Tokyo", ImageUrl = "https://via.placeholder.com/150", Description = "A high-tech hotel in the city.", Country = "Japan" },
        new Event { Name = "Hotel Kyoto", ImageUrl = "https://via.placeholder.com/150", Description = "A traditional hotel in Kyoto.", Country = "Japan" },
        new Event { Name = "Hotel Rio de Janeiro", ImageUrl = "https://via.placeholder.com/150", Description = "A beachfront hotel in Brazil.", Country = "Brazil" },
        new Event { Name = "Hotel Sao Paulo", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Sao Paulo.", Country = "Brazil" },
        new Event { Name = "Hotel Beijing", ImageUrl = "https://via.placeholder.com/150", Description = "A historical hotel in China.", Country = "China" },
        new Event { Name = "Hotel Shanghai", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in Shanghai.", Country = "China" },
        new Event { Name = "Hotel Mumbai", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in India.", Country = "India" },
        new Event { Name = "Hotel Delhi", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Delhi.", Country = "India" },
        new Event { Name = "Hotel Moscow", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in the capital.", Country = "Russia" },
        new Event { Name = "Hotel Saint Petersburg", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Saint Petersburg.", Country = "Russia" },
        new Event { Name = "Hotel Cape Town", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel with stunning views.", Country = "South Africa" },
        new Event { Name = "Hotel Johannesburg", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Johannesburg.", Country = "South Africa" },
        new Event { Name = "Hotel Cairo", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel near the pyramids.", Country = "Egypt" },
        new Event { Name = "Hotel Alexandria", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Alexandria.", Country = "Egypt" },
        new Event { Name = "Hotel Buenos Aires", ImageUrl = "https://via.placeholder.com/150", Description = "A vibrant hotel in Argentina.", Country = "Argentina" },
        new Event { Name = "Hotel Cordoba", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Cordoba.", Country = "Argentina" },
        new Event { Name = "Hotel Mexico City", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in the capital.", Country = "Mexico" },
        new Event { Name = "Hotel Cancun", ImageUrl = "https://via.placeholder.com/150", Description = "A beachfront hotel in Cancun.", Country = "Mexico" },
        new Event { Name = "Hotel Istanbul", ImageUrl = "https://via.placeholder.com/150", Description = "A historic hotel in the city.", Country = "Turkey" },
        new Event { Name = "Hotel Ankara", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Ankara.", Country = "Turkey" },
        new Event { Name = "Hotel Athens", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel with stunning views of the Acropolis.", Country = "Greece" },
        new Event { Name = "Hotel Thessaloniki", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Thessaloniki.", Country = "Greece" },
        new Event { Name = "Hotel Lisbon", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Portugal.", Country = "Portugal" },
        new Event { Name = "Hotel Porto", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Porto.", Country = "Portugal" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Event>> Get()
    {
        return Ok(Events);
    }

    [HttpGet("byCountry/{country}")]
    public ActionResult<IEnumerable<Event>> GetByCountry(string country)
    {
        var eventsInCountry = Events.Where(h => h.Country.Equals(country, System.StringComparison.OrdinalIgnoreCase)).ToList();
        if (!eventsInCountry.Any())
        {
            return NotFound();
        }
        return Ok(eventsInCountry);
    }
}
