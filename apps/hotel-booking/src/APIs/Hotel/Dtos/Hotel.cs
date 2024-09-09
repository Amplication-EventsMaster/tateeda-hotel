namespace HotelBooking.APIs.Dtos;

public class Hotel
{
    public DateTime CreatedAt { get; set; }

    public string Id { get; set; }

    public string? Location { get; set; }

    public string? Name { get; set; }

    public double? Rating { get; set; }

    public List<string>? Rooms { get; set; }

    public DateTime UpdatedAt { get; set; }
}
