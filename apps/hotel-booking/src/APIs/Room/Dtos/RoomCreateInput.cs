namespace HotelBooking.APIs.Dtos;

public class RoomCreateInput
{
    public List<Booking>? Bookings { get; set; }

    public DateTime CreatedAt { get; set; }

    public Hotel? Hotel { get; set; }

    public string? Id { get; set; }

    public double? Price { get; set; }

    public string? RoomNumber { get; set; }

    public string? TypeField { get; set; }

    public DateTime UpdatedAt { get; set; }
}
