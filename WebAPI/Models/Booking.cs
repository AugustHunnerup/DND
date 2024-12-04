public class Booking{
    public int Id { get; set; }
    public string HotelName { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public User? User { get; set; }
    public int UserId { get; set; }
    public int Price { get; set; }
    public int NumberOfPeople { get; set; }
    
}