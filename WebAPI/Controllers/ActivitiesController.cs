using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class ActivitiesController : ControllerBase
{
    private readonly HotelContext _context;

    public ActivitiesController(HotelContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Event>>> Get()
    {
        return await _context.Events.ToListAsync();
    }

    [HttpGet("byCountry/{country}")]
    public ActionResult<IEnumerable<Event>> GetByCountry(string country)
    {
        var eventsInCountry = _context.Events
            .Where(e => e.Country.Equals(country, System.StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (!eventsInCountry.Any())
        {
            return NotFound();
        }

        return Ok(eventsInCountry);
    }
}
