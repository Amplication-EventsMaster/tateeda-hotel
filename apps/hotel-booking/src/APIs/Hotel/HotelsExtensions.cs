using HotelBooking.APIs.Dtos;
using HotelBooking.Infrastructure.Models;

namespace HotelBooking.APIs.Extensions;

public static class HotelsExtensions
{
    public static Hotel ToDto(this HotelDbModel model)
    {
        return new Hotel
        {
            CreatedAt = model.CreatedAt,
            Id = model.Id,
            Location = model.Location,
            Name = model.Name,
            Rating = model.Rating,
            Rooms = model.Rooms?.Select(x => x.Id).ToList(),
            UpdatedAt = model.UpdatedAt,
        };
    }

    public static HotelDbModel ToModel(
        this HotelUpdateInput updateDto,
        HotelWhereUniqueInput uniqueId
    )
    {
        var hotel = new HotelDbModel
        {
            Id = uniqueId.Id,
            Location = updateDto.Location,
            Name = updateDto.Name,
            Rating = updateDto.Rating
        };

        if (updateDto.CreatedAt != null)
        {
            hotel.CreatedAt = updateDto.CreatedAt.Value;
        }
        if (updateDto.UpdatedAt != null)
        {
            hotel.UpdatedAt = updateDto.UpdatedAt.Value;
        }

        return hotel;
    }
}
