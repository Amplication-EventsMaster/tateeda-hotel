using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
