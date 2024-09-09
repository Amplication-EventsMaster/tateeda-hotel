using HotelBooking.Infrastructure;

namespace HotelBooking.APIs;

public class HotelsService : HotelsServiceBase
{
    public HotelsService(HotelBookingDbContext context)
        : base(context) { }
}
