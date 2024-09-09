using HotelBooking.Infrastructure;

namespace HotelBooking.APIs;

public class RoomsService : RoomsServiceBase
{
    public RoomsService(HotelBookingDbContext context)
        : base(context) { }
}
