namespace HotelBooking.APIs.Dtos;

public class HotelCreateInput
{
    public DateTime CreatedAt { get; set; }

    public string? Id { get; set; }

    public string? Location { get; set; }

    public string? Name { get; set; }

    public double? Rating { get; set; }

    public List<Room>? Rooms { get; set; }

    public DateTime UpdatedAt { get; set; }
}
