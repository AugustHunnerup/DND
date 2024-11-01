using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class HotelsController : ControllerBase
{
    private static List<Hotel> Hotel = new List<Hotel>
{
    
new Hotel { Name = "Hotel Copenhagen", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in the heart of Copenhagen.", Country = "Denmark" },
    new Hotel { Name = "Hotel Berlin", ImageUrl = "https://via.placeholder.com/150", Description = "An upscale hotel near Brandenburg Gate.", Country = "Germany" },
    new Hotel { Name = "Hotel Paris", ImageUrl = "https://via.placeholder.com/150", Description = "A romantic hotel with views of the Eiffel Tower.", Country = "France" },
    new Hotel { Name = "Hotel Rome", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in the city center.", Country = "Italy" },
    new Hotel { Name = "Hotel Barcelona", ImageUrl = "https://via.placeholder.com/150", Description = "A vibrant hotel near the beach.", Country = "Spain" },
    new Hotel { Name = "Hotel London", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in the capital.", Country = "UK" },
    new Hotel { Name = "Hotel New York", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in the city.", Country = "USA" },
    new Hotel { Name = "Hotel Toronto", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in the heart of the city.", Country = "Canada" },
    new Hotel { Name = "Hotel Sydney", ImageUrl = "https://via.placeholder.com/150", Description = "A luxury hotel with views of the harbor.", Country = "Australia" },
    new Hotel { Name = "Hotel Tokyo", ImageUrl = "https://via.placeholder.com/150", Description = "A high-tech hotel in the city.", Country = "Japan" },
    new Hotel { Name = "Hotel Rio de Janeiro", ImageUrl = "https://via.placeholder.com/150", Description = "A beachfront hotel in Brazil.", Country = "Brazil" },
    new Hotel { Name = "Hotel Beijing", ImageUrl = "https://via.placeholder.com/150", Description = "A historical hotel in China.", Country = "China" },
    new Hotel { Name = "Hotel Mumbai", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in India.", Country = "India" },
    new Hotel { Name = "Hotel Moscow", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in the capital.", Country = "Russia" },
    new Hotel { Name = "Hotel Cape Town", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel with stunning views.", Country = "South Africa" },
    new Hotel { Name = "Hotel Cairo", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel near the pyramids.", Country = "Egypt" },
    new Hotel { Name = "Hotel Buenos Aires", ImageUrl = "https://via.placeholder.com/150", Description = "A vibrant hotel in Argentina.", Country = "Argentina" },
    new Hotel { Name = "Hotel Mexico City", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in the capital.", Country = "Mexico" },
    new Hotel { Name = "Hotel Istanbul", ImageUrl = "https://via.placeholder.com/150", Description = "A historic hotel in the city.", Country = "Turkey" },
    new Hotel { Name = "Hotel Athens", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel with stunning views of the Acropolis.", Country = "Greece" },
    new Hotel { Name = "Hotel Lisbon", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Portugal.", Country = "Portugal" },
    new Hotel { Name = "Hotel Stockholm", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in the capital.", Country = "Sweden" },
    new Hotel { Name = "Hotel Oslo", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Norway.", Country = "Norway" },
    new Hotel { Name = "Hotel Helsinki", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel with beautiful sea views.", Country = "Finland" },
    new Hotel { Name = "Hotel Dublin", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Dublin.", Country = "Ireland" },
    new Hotel { Name = "Hotel Brussels", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in Brussels.", Country = "Belgium" },
    new Hotel { Name = "Hotel Zurich", ImageUrl = "https://via.placeholder.com/150", Description = "A luxury hotel in Zurich.", Country = "Switzerland" },
    new Hotel { Name = "Hotel Vienna", ImageUrl = "https://via.placeholder.com/150", Description = "A historic hotel in Vienna.", Country = "Austria" },
    new Hotel { Name = "Hotel Prague", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Prague.", Country = "Czech Republic" },
    new Hotel { Name = "Hotel Budapest", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Budapest.", Country = "Hungary" },
    new Hotel { Name = "Hotel Bratislava", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel with stunning river views.", Country = "Slovakia" },
    new Hotel { Name = "Hotel Ljubljana", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in the capital.", Country = "Slovenia" },
    new Hotel { Name = "Hotel Bucharest", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in Romania.", Country = "Romania" },
    new Hotel { Name = "Hotel Sofia", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel with a rich history.", Country = "Bulgaria" },
    new Hotel { Name = "Hotel Kyiv", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Kyiv.", Country = "Ukraine" },
    new Hotel { Name = "Hotel Vilnius", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in the capital.", Country = "Lithuania" },
    new Hotel { Name = "Hotel Riga", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Latvia.", Country = "Latvia" },
    new Hotel { Name = "Hotel Tallinn", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Tallinn.", Country = "Estonia" },
    new Hotel { Name = "Hotel Chisinau", ImageUrl = "https://via.placeholder.com/150", Description = "A cozy hotel in Moldova.", Country = "Moldova" },
    new Hotel { Name = "Hotel Tbilisi", ImageUrl = "https://via.placeholder.com/150", Description = "A historic hotel in Tbilisi.", Country = "Georgia" },
    new Hotel { Name = "Hotel Yerevan", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in Armenia.", Country = "Armenia" },
    new Hotel { Name = "Hotel Baku", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Baku.", Country = "Azerbaijan" },
    new Hotel { Name = "Hotel Almaty", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel with stunning mountain views.", Country = "Kazakhstan" },
    new Hotel { Name = "Hotel Tashkent", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Tashkent.", Country = "Uzbekistan" },
    new Hotel { Name = "Hotel Bishkek", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel in the capital city.", Country = "Kyrgyzstan" },
    new Hotel { Name = "Hotel Dushanbe", ImageUrl = "https://via.placeholder.com/150", Description = "A cozy hotel in Tajikistan.", Country = "Tajikistan" },
    new Hotel { Name = "Hotel Male", ImageUrl = "https://via.placeholder.com/150", Description = "A luxury hotel in the Maldives.", Country = "Maldives" },
    new Hotel { Name = "Hotel Victoria", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel near the beach.", Country = "Seychelles" },
    new Hotel { Name = "Hotel Suva", ImageUrl = "https://via.placeholder.com/150", Description = "A beachfront hotel in Fiji.", Country = "Fiji" },
    new Hotel { Name = "Hotel Auckland", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Auckland.", Country = "New Zealand" },
    new Hotel { Name = "Hotel Rarotonga", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel near the beach.", Country = "Cook Islands" },
    new Hotel { Name = "Hotel Nuku'alofa", ImageUrl = "https://via.placeholder.com/150", Description = "A hotel with stunning ocean views.", Country = "Tonga" },
};

    [HttpGet]
    public ActionResult<IEnumerable<Hotel>> Get()
    {
        return Ok(Hotel);
    }

    [HttpGet("byCountry/{country}")]
    public ActionResult<IEnumerable<Hotel>> GetByCountry(string country)
    {
        var hotelsInCountry = Hotel.Where(h => h.Country.Equals(country, System.StringComparison.OrdinalIgnoreCase)).ToList();
        if (!hotelsInCountry.Any())
        {
            return NotFound();
        }
        return Ok(hotelsInCountry);
    }
}
