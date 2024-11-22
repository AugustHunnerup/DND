public class Booking{
    public int Id { get; set; }
    public string Hotel { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public User User { get; set; }
    public Hotel hotel { get; set; }
}