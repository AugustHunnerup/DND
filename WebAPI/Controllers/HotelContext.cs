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
            new Event { Id = 1, Name = "Legoland", ImageUrl = "/images/legolegolego.jpeg", Description = "Experience Legoland in Billund", Country = "Denmark" },
            new Event { Id = 2, Name = "Tivoli", ImageUrl = "/images/kbhtivoli.jpg", Description = "Experience Tivoli in Copenhagen", Country = "Denmark" },
            new Event {Id = 3, Name = "Kongelige teater", ImageUrl = "/images/kongeligeteaterrrr.jpg", Description = "Experience Kongelig teater in Copenhagen", Country = "Denmark" },
            new Event {Id = 4, Name = "Jellingestenen", ImageUrl = "/images/jellingsteeen.jpg", Description = "Experience Jellingestenen in Sydjylland", Country = "Denmark" },
            new Event {Id = 5, Name = "Europa-Park", ImageUrl = "/images/Rust1.jpg", Description = "Experience Europa-Park and its exciting roller coasters", Country = "Germany" },
            new Event {Id = 6, Name = "Nationalpark Harz", ImageUrl = "/images/Goslar.jpg", Description = "Experience a beautiful and peaceful park in North Germany", Country = "Germany" },
            new Event { Id =7, Name = "Eiffel Tower", ImageUrl = "/images/Paris.jpg", Description = "Experience the amazing view of the Eiffel Tower.", Country = "France" },
            new Event {  Id =8, Name = "Wine Tour", ImageUrl = "/images/Bordeaux.jpg", Description = "Experience a tasteful wine tour in Bordeaux", Country = "France" },
            new Event {  Id =9, Name = "Niagara Falls", ImageUrl = "/images/Ontario.jpg", Description = "Experience the massive waterfall Niagara Falls in Ontario", Country = "Canada" },
            new Event {  Id =10, Name = "Banff National Park", ImageUrl = "/images/Alberta.jpg", Description = "Experience Canada's oldest national park Banff", Country = "Canada" },
            new Event {  Id =11, Name = "Sydney Opera House", ImageUrl = "/images/Sydney.jpg", Description = "Experience the iconic Opera House designed by Jørn Utzon", Country = "Australia" },
            new Event {  Id = 12, Name = "Great Barrier Reef", ImageUrl = "/images/Cairns.jpg", Description = "Experience the world's biggest coral reef system in Cairns", Country = "Australia" },
            new Event {  Id =13, Name = "Fushimi Inari-taisha", ImageUrl = "/images/Kyoto.jpg", Description = "Experience one of Japan's most famous shinto-shrines", Country = "Japan" },
            new Event {  Id = 14, Name = "Mount Fuji", ImageUrl = "/images/Fujinomiya.jpg", Description = "Experience Japan's biggest mountain", Country = "Japan" },
            new Event {  Id =15, Name = "Cristo Redentor", ImageUrl = "/images/RioDeJaneiro.jpg", Description = "Experience Cristo Redentor, one of the world's most iconic statues", Country = "Brazil" },
            new Event {  Id =16, Name = "Iguazu-waterfalls", ImageUrl = "/images/FozDoIguaco.jpg", Description = "Experience the Iguazu-waterfalls, one of the world's biggest waterfalls", Country = "Brazil" },
            new Event {  Id =17, Name = "Great Wall of China", ImageUrl = "/images/Beijing.jpg", Description = "Experience the Great Wall of China in Beijing", Country = "China" },
            new Event {  Id =18, Name = "The Terracotta Army", ImageUrl = "/images/Xian.jpg", Description = "Experience The Terracotta Army which is over 2000 years old", Country = "China" },
            new Event {  Id =19, Name = "The Taj Mahal", ImageUrl = "/images/Agra.jpg", Description = "Experience The Taj Mahal, one of the seven wonders of the world", Country = "India" },
            new Event {  Id =20, Name = "The Kerala Backwaters", ImageUrl = "/images/Alappuzha.jpg", Description = "Experience The Kerala Backwaters, which is a network of lakes, canals and lagoons", Country = "India" },
            new Event {  Id =21, Name = "Saint Basil's Cathedral", ImageUrl = "/images/Moscow.jpg", Description = "Experience the iconic symbol of Russia, Saint Basil's Cathedral", Country = "Russia" },
            new Event {  Id =22, Name = "Hotel Saint Petersburg", ImageUrl = "/images/SaintPeterburg.jpg", Description = "Experience one of the largest and oldest museums in the world", Country = "Russia" },
            new Event {  Id =23, Name = "Table Mountain", ImageUrl = "/images/CapeTown.jpg", Description = "Experience an iconic flat-topped mountain overlooking Cape Town", Country = "South Africa" },
            new Event {  Id =24, Name = "Kruger National Park", ImageUrl = "/images/Nelspruit.jpg", Description = "Experience one of Africa's largest game reserves", Country = "South Africa" },
            new Event {  Id =25, Name = "The Pyramids of Giza", ImageUrl = "/images/Giza.jpg", Description = "Experience The Great Pyramids of Giza", Country = "Egypt" },
            new Event {  Id =26, Name = "The Valley of The Kings", ImageUrl = "/images/Luxor.jpg", Description = "Experience The Valley of The Kings where many Pharaohs of the New Kingdom were buried", Country = "Egypt" },
            new Event {  Id =27, Name = "Perito Moreno Glacier", ImageUrl = "/images/ElCalafate.jpg", Description = "Experience one of the few advancing glaciers in the world", Country = "Argentina" },
            new Event {  Id =28, Name = "Iguazu Falls", ImageUrl = "/images/IguazuFalls.jpg", Description = "Experience one of the World's most stunning natural wonders", Country = "Argentina" },
            new Event {  Id =29, Name = "Chicken Itza", ImageUrl = "/images/Tinum.jpg", Description = "Experience the UNESCO World Heritage", Country = "Mexico" },
            new Event {  Id =30, Name = "Cenote Ik Kil", ImageUrl = "/images/Tinum1.jpg", Description = "Experience a natural sinkhole renowned for its stunning beauty", Country = "Mexico" },
            new Event {  Id =31, Name = "Hot Air Balloon Ride", ImageUrl = "/images/Goreme.jpg", Description = "Experience a Hot Air Balloon Ride in Cappadocia", Country = "Turkey" },
            new Event { Id =32, Name = "The Hagia Sophia", ImageUrl = "/images/Istanbul.jpg", Description = "Experience The Hagia Sophia, served as a mosque and museum over the centuries", Country = "Turkey" },
            new Event { Id =33, Name = "Acropolis", ImageUrl = "/images/Athen.jpg", Description = "Experience the world famous archaeological site Acropolis", Country = "Greece" }
        );

        modelBuilder.Entity<Hotel>().HasData(
            new Hotel {Id = 1, Name = "Hotel Copenhagen", ImageUrl = "/images/CPH.jpg", Description = "A modern hotel in the heart of Copenhagen.", Country = "Denmark", Price=250 },
            new Hotel {Id = 2, Name = "Hotel Aarhus", ImageUrl = "/images/Aarhus.jpg", Description = "A cozy hotel in Aarhus.", Country = "Denmark" , Price=120},
            new Hotel {Id = 3, Name = "Hotel Berlin", ImageUrl = "/images/hotelb.jpg", Description = "An upscale hotel near Brandenburg Gate.", Country = "Germany", Price=285 },
            new Hotel {Id = 4, Name = "Hotel Munich", ImageUrl = "/images/hotelmun.jpg", Description = "A charming hotel in Munich.", Country = "Germany", Price=150 },
            new Hotel {Id = 5, Name = "Hotel Paris", ImageUrl = "/images/hotelp.jpg", Description = "A romantic hotel with views of the Eiffel Tower.", Country = "France", Price=287 },
            new Hotel {Id = 6, Name = "Hotel Lyon", ImageUrl = "/images/hotellyon.jpg", Description = "A beautiful hotel in Lyon.", Country = "France", Price=137 },
            new Hotel {Id = 7, Name = "Hotel Toronto", ImageUrl = "/images/hoteltoronto.jpg", Description = "A charming hotel in the city center.", Country = "Canada", Price=184 },
            new Hotel {Id = 8, Name = "Hotel Vancouver", ImageUrl = "/images/hotelv.jpg", Description = "A stylish hotel in Milan.", Country = "Canada", Price=193 },
            new Hotel {Id = 9, Name = "Hotel Sydney", ImageUrl = "/images/hotelss.jpg", Description = "A vibrant hotel near the beach.", Country = "Australia", Price=152  },
            new Hotel {Id = 10, Name = "Hotel Canberra", ImageUrl = "/images/hotelc.jpg", Description = "A luxurious hotel in the capital.", Country = "Australia", Price=163 },
            new Hotel {Id = 11, Name = "Hotel Tokyo", ImageUrl = "/images/hotelttt.jpg", Description = "A modern hotel in Manchester.", Country = "Japan", Price=243 },
            new Hotel {Id = 12, Name = "Hotel Osaka", ImageUrl = "/images/hotelosa.jpg", Description = "A stylish hotel in the city.", Country = "Japan", Price=175 },
            new Hotel {Id = 13, Name = "Hotel Brasilia", ImageUrl = "/images/hotelbra.jpg", Description = "A stylish hotel in the city.", Country = "Brazil", Price=190 },
            new Hotel {Id = 14, Name = "Hotel Sao Paulo", ImageUrl = "/images/hotelpao.jpg", Description = "A stylish hotel in the city.", Country = "Brazil", Price=126 },
            new Hotel {Id = 15, Name = "Hotel Beijing", ImageUrl = "/images/hotelbei.jpg", Description = "A stylish hotel in the city.", Country = "China", Price=172 },
            new Hotel {Id = 16, Name = "Hotel Shanghai", ImageUrl = "/images/hotelshang.jpg", Description = "A stylish hotel in the city.", Country = "China", Price=229 },
            new Hotel {Id = 17, Name = "Hotel Mumbai", ImageUrl = "/images/hotelmom.jpg", Description = "A stylish hotel in the city.", Country = "India", Price=268 },
            new Hotel {Id = 18, Name = "Hotel Surat", ImageUrl = "/images/hotelcurry.jpg", Description = "A stylish hotel in the city.", Country = "India", Price=222 },
            new Hotel {Id = 19, Name = "Hotel Moscow", ImageUrl = "/images/hotelputin.jpg", Description = "A stylish hotel in the city.", Country = "Russia", Price=103 },
            new Hotel {Id = 20, Name = "Hotel Saint Petersburg", ImageUrl = "/images/hotelsaint.jpg", Description = "A stylish hotel in the city.", Country = "Russia", Price = 200 },
            new Hotel {Id = 21, Name = "Hotel Cape Town", ImageUrl = "/images/hoteltown.jpg", Description = "A stylish hotel in the city.", Country = "South Africa", Price = 130 },
            new Hotel {Id = 22, Name = "Hotel Johannesburg", ImageUrl = "/images/hotelburg.jpg", Description = "A stylish hotel in the city.", Country = "South Africa", Price  = 190 },
            new Hotel {Id = 23, Name = "Hotel Cairo", ImageUrl = "/images/hotelsalah.jpg", Description = "A stylish hotel in the city.", Country = "Egypt", Price = 110 },
            new Hotel {Id = 24, Name = "Hotel Giza", ImageUrl = "/images/hotelgiza.jpg", Description = "A stylish hotel in the city.", Country = "Egypt", Price = 145},
            new Hotel {Id = 25, Name = "Hotel Buenos Aires", ImageUrl = "/images/hotelaries.jpg", Description = "A stylish hotel in the city.", Country = "Argentina", Price = 120 },
            new Hotel {Id = 26, Name = "Hotel Cordoba", ImageUrl = "/images/hotelcor.jpg", Description = "A stylish hotel in the city.", Country = "Argentina", Price = 125 },
            new Hotel {Id = 27, Name = "Hotel Mexico City", ImageUrl = "/images/hotelmexico.jpg", Description = "A stylish hotel in the city.", Country = "Mexico", Price= 225 },
            new Hotel {Id = 28, Name = "Hotel Guadalajara", ImageUrl = "/images/hotelg.jpg", Description = "A stylish hotel in the city.", Country = "Mexico", Price = 175 },
            new Hotel {Id = 29, Name = "Hotel Istanbul", ImageUrl = "/images/hotelis.jpg", Description = "A stylish hotel in the city.", Country = "Turkey", Price = 250 },
            new Hotel {Id = 30, Name = "Hotel Antalya", ImageUrl = "/images/hotelan.jpg", Description = "A stylish hotel in the city.", Country = "Turkey", Price = 300 },
            new Hotel {Id = 31, Name = "Hotel Athens", ImageUrl = "/images/hotelat.jpg", Description = "A stylish hotel in the city.", Country = "Greece", Price = 150 },
            new Hotel {Id = 32, Name = "Hotel Rhodes", ImageUrl = "/images/hotelrho.jpg", Description = "A stylish hotel in the city.", Country = "Greece", Price = 200 }
        );
        modelBuilder.Entity<User>().HasData(new{
            Id = 1,
            Username = "Admin",
            Email = "Enesyil38@hotmail.com",
            FullName = "Enes Yildiz",
            Domain = "Hotelbooking.com",
            Password = "1234",
            Role = "Admin",
            SecurityLevel = 2,
            Birthday = new DateTime(2000, 06, 23)
        });

        modelBuilder.Entity<User>().HasData(new{
            Id = 2,
            Username = "August",
            Email = "august.hunnerup@gmail.com",
            FullName = "August Hunnerup Østergaard",
            Domain = "Hotelbooking.com",
            Password = "1234",
            Role = "Customer",
            SecurityLevel = 1,
            Birthday = new DateTime(1999, 12, 11)
        });
           
    }
}