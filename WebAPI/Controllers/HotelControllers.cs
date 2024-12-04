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
        var allBookings = await _context.Bookings.ToListAsync();

        if (allBookings == null || !allBookings.Any())
        {
            return NotFound("No bookings found.");
        }

        return Ok(allBookings);
    }

    [HttpGet("user-info/{userId}")]
    public async Task<ActionResult<User>> GetUserInfo(int userId)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPut("user-info/{userId}")]
    public async Task<IActionResult> UpdateUserInfo(int userId, [FromBody] User updatedUser)
    {
        if (userId != updatedUser.Id)
        {
            return BadRequest("User ID mismatch.");
        }

        var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);
        if (user == null)
        {
            return NotFound();
        }

        user.Email = updatedUser.Email;
        user.Username = updatedUser.Username;
        user.Password = updatedUser.Password;
        user.Birthday = updatedUser.Birthday;
        user.Domain = updatedUser.Domain;
        user.Role = updatedUser.Role;
        user.SecurityLevel = updatedUser.SecurityLevel;
        _context.Entry(user).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Users.Any(e => e.Id == userId))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpDelete("bookings/{id}")]
    public async Task<IActionResult> DeleteBooking(int id)
    {
        var booking = await _context.Bookings.FirstOrDefaultAsync(b => b.Id == id);
        if (booking == null)
        {
            return NotFound();
        }

        _context.Bookings.Remove(booking);
        await _context.SaveChangesAsync();

        return NoContent();
    }
    
    [HttpGet("get-current-password/{userId:int}")]
    public async Task<ActionResult<string>> GetCurrentPassword(int userId)
    {
        var user = await _context.Users.FirstOrDefaultAsync(b => b.Id == userId);
        if (user == null)
        {
            return NotFound("User not found.");
        }


        var currentPassword = user.Password; 
        return Ok(currentPassword);
    }
    

}
