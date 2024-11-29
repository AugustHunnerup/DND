using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class HotelsController : ControllerBase
{
    private readonly HotelContext _context;

    public HotelsController(HotelContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Hotel>>> Get()
    {
        return await _context.Hotels.ToListAsync();
    }

    [HttpGet("byCountry/{country}")]
    public async Task<ActionResult<IEnumerable<Hotel>>> GetByCountry(string country)
    {
        var hotelsInCountry = await _context.Hotels
            .Where(h => h.Country.Equals(country, System.StringComparison.OrdinalIgnoreCase))
            .ToListAsync();

        if (!hotelsInCountry.Any())
        {
            return NotFound();
        }

        return hotelsInCountry;
    }

    [HttpPost("add-booking")]
    public async Task<IActionResult> AddBooking([FromBody] Booking booking)
    {
        if (booking == null) return BadRequest("Booking details are required.");

        try
        {
            // Retrieve the user from the database
            //var user = await _context.Users.FindAsync(booking.UserId);
            //if (user == null) return NotFound("User not found.");

            // Assign the retrieved user to the booking
            //booking.User = user;
            _context.Bookings.Add(booking); // Assumes Bookings is already part of your DbContext
            await _context.SaveChangesAsync();
            return Ok("Booking successfully saved.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error saving booking: {ex.Message}");
        }
    }
}
