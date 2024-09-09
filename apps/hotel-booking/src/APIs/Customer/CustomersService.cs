using HotelBooking.Infrastructure;

namespace HotelBooking.APIs;

public class CustomersService : CustomersServiceBase
{
    public CustomersService(HotelBookingDbContext context)
        : base(context) { }
}
