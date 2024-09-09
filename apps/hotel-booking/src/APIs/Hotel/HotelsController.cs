using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.APIs;

[ApiController()]
public class HotelsController : HotelsControllerBase
{
    public HotelsController(IHotelsService service)
        : base(service) { }
}
