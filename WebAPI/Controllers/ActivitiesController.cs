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
        new Event { Name = "Europa-Park", ImageUrl = "/images/Rust1.jpg", Description = "Experience Europa-Park and its exciting roller coasters", Country = "Germany" },
        new Event { Name = "Nationalpark Harz", ImageUrl = "/images/Goslar.jpg", Description = "Experience a beautiful and peaceful park in North Germany", Country = "Germany" },
        new Event { Name = "Eiffel Tower", ImageUrl = "/images/Paris.jpg", Description = "Experience the amazing view of the Eiffel Tower.", Country = "France" },
        new Event { Name = "Wine Tour", ImageUrl = "/images/Bordeaux.jpg", Description = "Experience a tasteful wine tour in Bordeaux", Country = "France" },
        new Event { Name = "Colosseum", ImageUrl = "/images/Rom.jpg", Description = "Experience the Colosseum in Rome", Country = "Italy" },
        new Event { Name = "Gondola Ride", ImageUrl = "/images/Venedig.jpg", Description = "Experience a romantic Gondola Ride in Venedig", Country = "Italy" },
        new Event { Name = "Sagrada Familia", ImageUrl = "/images/Barcelona.jpg", Description = "Experience the iconic Basilica designed by the architect Antoni Gaudi", Country = "Spain" },
        new Event { Name = "Alhambra", ImageUrl = "/images/Granada.jpg", Description = "Experience the historic palace in Granada", Country = "Spain" },
        new Event { Name = "Big Ben", ImageUrl = "/images/London.jpg", Description = "Experience the massive clock tower Big Ben in London", Country = "UK" },
        new Event { Name = "Stonehenge", ImageUrl = "/images/Salisbury.jpg", Description = "Experience the prehistoric monument Stonehenge in Salisbury", Country = "UK" },
        new Event { Name = "Statue of Liberty", ImageUrl = "/images/NewYorkCity.jpg", Description = "Experience the Statur of Liberty in New York City", Country = "USA" },
        new Event { Name = "Grand Canyon", ImageUrl = "/images/Arizona.jpg", Description = "Experience the impressive Grand Canyon", Country = "USA" },
        new Event { Name = "Niagara Falls", ImageUrl = "/images/Ontario.jpg", Description = "Experience the massive waterfall Niagara Falls in Ontario", Country = "Canada" },
        new Event { Name = "Banff National Park", ImageUrl = "/images/Alberta.jpg", Description = "Experince Canada's oldest national park Banff", Country = "Canada" },
        new Event { Name = "Sydney Opera House", ImageUrl = "/images/Sydney.jpg", Description = "Experience the iconic Opera House designed by Jørn Utzon", Country = "Australia" },
        new Event { Name = "Great Barrier Reef", ImageUrl = "/images/Cairns.jpg", Description = "Experience the worlds biggest coral reef system in Cairns", Country = "Australia" },
        new Event { Name = "Fushimi Inari-taisha", ImageUrl = "/images/Kyoto.jpg", Description = "Experience one of Japan's most famous shinto-shrines", Country = "Japan" },
        new Event { Name = "Mount Fuji", ImageUrl = "/images/Fujinomiya.jpg", Description = "Experience Japan's biggest mountain", Country = "Japan" },
        new Event { Name = "Cristo Redentor", ImageUrl = "/images/RioDeJaneiro.jpg", Description = "Experience Cristo Redentor, one of the world's most iconic statues", Country = "Brazil" },
        new Event { Name = "Iguazu-waterfalls", ImageUrl = "/images/FozDoIguaco.jpg", Description = "Experience the Iguazu-waterfalls, one of the world's biggest waterfalls", Country = "Brazil" },
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
