using HotelBooking.APIs.Common;
using HotelBooking.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class BookingFindManyArgs : FindManyInput<Booking, BookingWhereInput> { }
