![image](https://github.com/user-attachments/assets/97e97808-b787-4722-8062-27c1e3dcd1e2) 

1)

We use RESTful web API to manage hotel data, user authentication, and bookings. Here are some code examples:

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

HTTP Verbs:
GET: Retrieves resources.
POST: Creates new resources.
PUT: Updates existing resources.
DELETE: Removes resources.

2)
[HttpGet]
public async Task<ActionResult<IEnumerable<Hotel>>> Get()
{
    return await _context.Hotels.ToListAsync();
}

HTTP Method: GET
Route: /api/[controller]


 [HttpPost("login")]
    public async Task<ActionResult> Login([FromBody] UserLoginDto userLoginDto)
    {
        try
        {
            User user = await authService.ValidateUser(userLoginDto.Username, userLoginDto.Password);
            string token = GenerateJwt(user);

            return Ok(token);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


HTTP Method: POST
Route: /api/[controller]/login

3)

The HotelContext.cs defines how the application interacts with SQLite database. The Hotel.db stores the data.
Here is an example:
public class HotelContext : DbContext
{
    public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }

    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)

  This class defines the database schema by mapping the entities; Hotels, Events, Bookings, Users to tables.




   
Reflection from today 01-11-2024:
We have set up github desktop on each of our computers. We then downloaded the project and found out about fetching and pulling in order to save changes. This enables us to make changes when we aren't working together face to face. This also gives us freedom to work alone and then discuss the changes when we meet again. 
In addition, we wanted to change the name of the project which was Pizza2. The easiest way for us to do it was to make a new folder with the name HotelWEBAPP. We copied everything from the last folder into the new one. This gave us a few problems since not every person could see the new folder. 
We also made a Getignore in order to download the newest version of the project without the settings from the individual's computer. This means, that the code won't be machine code, but it will be translated to C#. 
We also had a problem where couldn't put our API key in our API folder in the Github.

We learned to make getignore and to connect our servers together by livesharing, restoring and could work on the same project. 

We took notes on authentacation, and how that worked.

Renaming our files, that were complicated.

