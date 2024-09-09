using HotelBooking.APIs.Dtos;
using HotelBooking.Infrastructure.Models;

namespace HotelBooking.APIs.Extensions;

public static class BookingsExtensions
{
    public static Booking ToDto(this BookingDbModel model)
    {
        return new Booking
        {
            CreatedAt = model.CreatedAt,
            Customer = model.CustomerId,
            EndDate = model.EndDate,
            Id = model.Id,
            Room = model.RoomId,
            StartDate = model.StartDate,
            TotalPrice = model.TotalPrice,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static BookingDbModel ToModel(
        this BookingUpdateInput updateDto,
        BookingWhereUniqueInput uniqueId
    )
    {
        var booking = new BookingDbModel
        {
            Id = uniqueId.Id,
            EndDate = updateDto.EndDate,
            StartDate = updateDto.StartDate,
            TotalPrice = updateDto.TotalPrice
        };

        if (updateDto.CreatedAt != null)
        {
            booking.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.Customer != null)
        {
            booking.CustomerId = updateDto.Customer;
        }
        if (updateDto.Room != null)
        {
            booking.RoomId = updateDto.Room;
        }
        if (updateDto.UpdatedAt != null)
        {
            booking.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return booking;
    }
}
