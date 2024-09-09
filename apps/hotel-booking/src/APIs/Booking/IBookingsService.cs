using HotelBooking.APIs.Common;
using HotelBooking.APIs.Dtos;

namespace HotelBooking.APIs;

public interface IBookingsService
{
    /// <summary>
    /// Create one Booking
    /// </summary>
    public Task<Booking> CreateBooking(BookingCreateInput booking);

    /// <summary>
    /// Delete one Booking
    /// </summary>
    public Task DeleteBooking(BookingWhereUniqueInput uniqueId);

    /// <summary>
    /// Find many Bookings
    /// </summary>
    public Task<List<Booking>> Bookings(BookingFindManyArgs findManyArgs);

    /// <summary>
    /// Meta data about Booking records
    /// </summary>
    public Task<MetadataDto> BookingsMeta(BookingFindManyArgs findManyArgs);

    /// <summary>
    /// Get one Booking
    /// </summary>
    public Task<Booking> Booking(BookingWhereUniqueInput uniqueId);

    /// <summary>
    /// Update one Booking
    /// </summary>
    public Task UpdateBooking(BookingWhereUniqueInput uniqueId, BookingUpdateInput updateDto);

    /// <summary>
    /// Get a Customer record for Booking
    /// </summary>
    public Task<Customer> GetCustomer(BookingWhereUniqueInput uniqueId);

    /// <summary>
    /// Get a Room record for Booking
    /// </summary>
    public Task<Room> GetRoom(BookingWhereUniqueInput uniqueId);
}
