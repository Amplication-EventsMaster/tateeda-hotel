using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.APIs;

[ApiController()]
public class BookingsController : BookingsControllerBase
{
    public BookingsController(IBookingsService service)
        : base(service) { }
}
