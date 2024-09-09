using HotelBooking.Infrastructure;

namespace HotelBooking.APIs;

public class BookingsService : BookingsServiceBase
{
    public BookingsService(HotelBookingDbContext context)
        : base(context) { }
}
