using HotelBooking.APIs.Dtos;
using HotelBooking.Infrastructure.Models;

namespace HotelBooking.APIs.Extensions;

public static class RoomsExtensions
{
    public static Room ToDto(this RoomDbModel model)
    {
        return new Room
        {
            Bookings = model.Bookings?.Select(x => x.Id).ToList(),
            CreatedAt = model.CreatedAt,
            Hotel = model.HotelId,
            Id = model.Id,
            Price = model.Price,
            RoomNumber = model.RoomNumber,
            TypeField = model.TypeField,
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static RoomDbModel ToModel(this RoomUpdateInput updateDto, RoomWhereUniqueInput uniqueId)
    {
        var room = new RoomDbModel
        {
            Id = uniqueId.Id,
            Price = updateDto.Price,
            RoomNumber = updateDto.RoomNumber,
            TypeField = updateDto.TypeField
        };

        if (updateDto.CreatedAt != null)
        {
            room.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.Hotel != null)
        {
            room.HotelId = updateDto.Hotel;
        }
        if (updateDto.UpdatedAt != null)
        {
            room.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return room;
    }
}
