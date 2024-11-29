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
            _context.Bookings.Add(booking); // Assumes Bookings is already part of your DbContext
            await _context.SaveChangesAsync();
            return Ok("Booking successfully saved.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error saving booking: {ex.Message}");
        }
    }
    
    [HttpGet("user/{userId}")]
    public async Task<ActionResult<IEnumerable<Booking>>> GetUserBookings(int userId)
    {
        var userBookings = await _context.Bookings
            .Where(b => b.UserId == userId)
            .ToListAsync();

        if (userBookings == null || !userBookings.Any())
        {
            return NotFound("No bookings found for this user.");
        }

        return Ok(userBookings);
    }

    [HttpGet("all-bookings")]
    public async Task<ActionResult<IEnumerable<Booking>>> GetAllBookings()
    {
        var allBookings = await _context.Bookings
            .ToListAsync();

        if (allBookings == null || !allBookings.Any())
        {
            return NotFound("No bookings found.");
        }

        return Ok(allBookings);
    }
}
