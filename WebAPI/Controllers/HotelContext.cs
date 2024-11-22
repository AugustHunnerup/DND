using Microsoft.EntityFrameworkCore;

public class HotelContext : DbContext
{
    public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }

    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>().HasData(
            new Event { Id = 1, Name = "Legoland", ImageUrl = "/images/Billund.jpg", Description = "Experience Legoland in Billund", Country = "Denmark" },
            new Event { Id = 2, Name = "Tivoli", ImageUrl = "/images/Copenhagen.jpg", Description = "Experience Tivoli in Copenhagen", Country = "Denmark" },
            new Event {Id = 3, Name = "Kongelige teater", ImageUrl = "/images/Copenhagen1.jpg", Description = "Experience Kongelig teater in Copenhagen", Country = "Denmark" }
            /*new Event {Name = "Jellingestenen", ImageUrl = "/images/Jelling.jpg", Description = "Experience Jellingestenen in Sydjylland", Country = "Denmark" },
            new Event {Name = "Europa-Park", ImageUrl = "/images/Rust1.jpg", Description = "Experience Europa-Park and its exciting roller coasters", Country = "Germany" },
            new Event {Name = "Nationalpark Harz", ImageUrl = "/images/Goslar.jpg", Description = "Experience a beautiful and peaceful park in North Germany", Country = "Germany" },
            new Event { Name = "Eiffel Tower", ImageUrl = "/images/Paris.jpg", Description = "Experience the amazing view of the Eiffel Tower.", Country = "France" },
            new Event {  Name = "Wine Tour", ImageUrl = "/images/Bordeaux.jpg", Description = "Experience a tasteful wine tour in Bordeaux", Country = "France" },
            new Event {  Name = "Niagara Falls", ImageUrl = "/images/Ontario.jpg", Description = "Experience the massive waterfall Niagara Falls in Ontario", Country = "Canada" },
            new Event {  Name = "Banff National Park", ImageUrl = "/images/Alberta.jpg", Description = "Experience Canada's oldest national park Banff", Country = "Canada" },
            new Event {  Name = "Sydney Opera House", ImageUrl = "/images/Sydney.jpg", Description = "Experience the iconic Opera House designed by Jørn Utzon", Country = "Australia" },
            new Event {  Name = "Great Barrier Reef", ImageUrl = "/images/Cairns.jpg", Description = "Experience the world's biggest coral reef system in Cairns", Country = "Australia" },
            new Event {  Name = "Fushimi Inari-taisha", ImageUrl = "/images/Kyoto.jpg", Description = "Experience one of Japan's most famous shinto-shrines", Country = "Japan" },
            new Event {  Name = "Mount Fuji", ImageUrl = "/images/Fujinomiya.jpg", Description = "Experience Japan's biggest mountain", Country = "Japan" },
            new Event {  Name = "Cristo Redentor", ImageUrl = "/images/RioDeJaneiro.jpg", Description = "Experience Cristo Redentor, one of the world's most iconic statues", Country = "Brazil" },
            new Event {  Name = "Iguazu-waterfalls", ImageUrl = "/images/FozDoIguaco.jpg", Description = "Experience the Iguazu-waterfalls, one of the world's biggest waterfalls", Country = "Brazil" },
            new Event {  Name = "Great Wall of China", ImageUrl = "/images/Beijing.jpg", Description = "Experience the Great Wall of China in Beijing", Country = "China" },
            new Event {  Name = "The Terracotta Army", ImageUrl = "/images/Xian.jpg", Description = "Experience The Terracotta Army which is over 2000 years old", Country = "China" },
            new Event {  Name = "The Taj Mahal", ImageUrl = "/images/Agra.jpg", Description = "Experience The Taj Mahal, one of the seven wonders of the world", Country = "India" },
            new Event {  Name = "The Kerala Backwaters", ImageUrl = "/images/Alappuzha.jpg", Description = "Experience The Kerala Backwaters, which is a network of lakes, canals and lagoons", Country = "India" },
            new Event {  Name = "Saint Basil's Cathedral", ImageUrl = "/images/Moscow.jpg", Description = "Experience the iconic symbol of Russia, Saint Basil's Cathedral", Country = "Russia" },
            new Event {  Name = "Hotel Saint Petersburg", ImageUrl = "/images/SaintPeterburg.jpg", Description = "Experience one of the largest and oldest museums in the world", Country = "Russia" },
            new Event {  Name = "Table Mountain", ImageUrl = "/images/CapeTown.jpg", Description = "Experience an iconic flat-topped mountain overlooking Cape Town", Country = "South Africa" },
            new Event {  Name = "Kruger National Park", ImageUrl = "/images/Nelspruit.jpg", Description = "Experience one of Africa's largest game reserves", Country = "South Africa" },
            new Event {  Name = "The Pyramids of Giza", ImageUrl = "/images/Giza.jpg", Description = "Experience The Great Pyramids of Giza", Country = "Egypt" },
            new Event {  Name = "The Valley of The Kings", ImageUrl = "/images/Luxor.jpg", Description = "Experience The Valley of The Kings where many Pharaohs of the New Kingdom were buried", Country = "Egypt" },
            new Event {  Name = "Perito Moreno Glacier", ImageUrl = "/images/ElCalafate.jpg", Description = "Experience one of the few advancing glaciers in the world", Country = "Argentina" },
            new Event {  Name = "Iguazu Falls", ImageUrl = "/images/IguazuFalls.jpg", Description = "Experience one of the World's most stunning natural wonders", Country = "Argentina" },
            new Event {  Name = "Chicken Itza", ImageUrl = "/images/Tinum.jpg", Description = "Experience the UNESCO World Heritage", Country = "Mexico" },
            new Event {  Name = "Cenote Ik Kil", ImageUrl = "/images/Tinum1.jpg", Description = "Experience a natural sinkhole renowned for its stunning beauty", Country = "Mexico" },
            new Event {  Name = "Hot Air Balloon Ride", ImageUrl = "/images/Goreme.jpg", Description = "Experience a Hot Air Balloon Ride in Cappadocia", Country = "Turkey" },
            new Event { Name = "The Hagia Sophia", ImageUrl = "/images/Istanbul.jpg", Description = "Experience The Hagia Sophia, served as a mosque and museum over the centuries", Country = "Turkey" },
            new Event { Name = "Acropolis", ImageUrl = "/images/Athen.jpg", Description = "Experience the world famous archaeological site Acropolis", Country = "Greece" }*/
        );

        modelBuilder.Entity<Hotel>().HasData(
            new Hotel {Id = 1, Name = "Hotel Copenhagen", ImageUrl = "/images/Copenhagen5.jpg", Description = "A modern hotel in the heart of Copenhagen.", Country = "Denmark" },
            new Hotel {Id = 2, Name = "Hotel Aarhus", ImageUrl = "/images/Aarhus.jpg", Description = "A cozy hotel in Aarhus.", Country = "Denmark" },
            new Hotel {Id = 3, Name = "Hotel Berlin", ImageUrl = "https://via.placeholder.com/150", Description = "An upscale hotel near Brandenburg Gate.", Country = "Germany" }
           /* new Hotel {Name = "Hotel Munich", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in Munich.", Country = "Germany" },
            new Hotel {Name = "Hotel Paris", ImageUrl = "https://via.placeholder.com/150", Description = "A romantic hotel with views of the Eiffel Tower.", Country = "France" },
            new Hotel {Name = "Hotel Lyon", ImageUrl = "https://via.placeholder.com/150", Description = "A beautiful hotel in Lyon.", Country = "France" },
            new Hotel {Name = "Hotel Rome", ImageUrl = "https://via.placeholder.com/150", Description = "A charming hotel in the city center.", Country = "Italy" },
            new Hotel {Name = "Hotel Milan", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in Milan.", Country = "Italy" },
            new Hotel {Name = "Hotel Barcelona", ImageUrl = "https://via.placeholder.com/150", Description = "A vibrant hotel near the beach.", Country = "Spain" },
            new Hotel {Name = "Hotel London", ImageUrl = "https://via.placeholder.com/150", Description = "A luxurious hotel in the capital.", Country = "UK" },
            new Hotel {Name = "Hotel Manchester", ImageUrl = "https://via.placeholder.com/150", Description = "A modern hotel in Manchester.", Country = "UK" },
            new Hotel {Name = "Hotel New York", ImageUrl = "https://via.placeholder.com/150", Description = "A stylish hotel in the city.", Country = "USA" }*/
        );
        modelBuilder.Entity<User>().HasData(new{
            Id = 1,
            Username = "Admin",
            Email = "jknr@via.dk",
            FullName = "Jakob Trigger Knop",
            Domain = "admin.com",
            Password = "1234",
            Role = "Teacher",
            SecurityLevel = 4,
            Birthday = new DateTime(1988, 3, 14)
        });
    }
}