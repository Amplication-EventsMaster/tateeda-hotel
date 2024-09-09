namespace HotelBooking.APIs.Dtos;

public class RoomUpdateInput
{
    public List<string>? Bookings { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? Hotel { get; set; }

    public string? Id { get; set; }

    public double? Price { get; set; }

    public string? RoomNumber { get; set; }

    public string? TypeField { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
