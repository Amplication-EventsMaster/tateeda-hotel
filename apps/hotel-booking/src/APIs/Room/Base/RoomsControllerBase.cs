using HotelBooking.APIs;
using HotelBooking.APIs.Common;
using HotelBooking.APIs.Dtos;
using HotelBooking.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RoomsControllerBase : ControllerBase
{
    protected readonly IRoomsService _service;

    public RoomsControllerBase(IRoomsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Room
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Room>> CreateRoom(RoomCreateInput input)
    {
        var room = await _service.CreateRoom(input);

        return CreatedAtAction(nameof(Room), new { id = room.Id }, room);
    }

    /// <summary>
    /// Delete one Room
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRoom([FromRoute()] RoomWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteRoom(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Rooms
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Room>>> Rooms([FromQuery()] RoomFindManyArgs filter)
    {
        return Ok(await _service.Rooms(filter));
    }

    /// <summary>
    /// Meta data about Room records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> RoomsMeta([FromQuery()] RoomFindManyArgs filter)
    {
        return Ok(await _service.RoomsMeta(filter));
    }

    /// <summary>
    /// Get one Room
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Room>> Room([FromRoute()] RoomWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Room(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Room
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRoom(
        [FromRoute()] RoomWhereUniqueInput uniqueId,
        [FromQuery()] RoomUpdateInput roomUpdateDto
    )
    {
        try
        {
            await _service.UpdateRoom(uniqueId, roomUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Bookings records to Room
    /// </summary>
    [HttpPost("{Id}/bookings")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectBookings(
        [FromRoute()] RoomWhereUniqueInput uniqueId,
        [FromQuery()] BookingWhereUniqueInput[] bookingsId
    )
    {
        try
        {
            await _service.ConnectBookings(uniqueId, bookingsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Bookings records from Room
    /// </summary>
    [HttpDelete("{Id}/bookings")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectBookings(
        [FromRoute()] RoomWhereUniqueInput uniqueId,
        [FromBody()] BookingWhereUniqueInput[] bookingsId
    )
    {
        try
        {
            await _service.DisconnectBookings(uniqueId, bookingsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Bookings records for Room
    /// </summary>
    [HttpGet("{Id}/bookings")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Booking>>> FindBookings(
        [FromRoute()] RoomWhereUniqueInput uniqueId,
        [FromQuery()] BookingFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindBookings(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Bookings records for Room
    /// </summary>
    [HttpPatch("{Id}/bookings")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateBookings(
        [FromRoute()] RoomWhereUniqueInput uniqueId,
        [FromBody()] BookingWhereUniqueInput[] bookingsId
    )
    {
        try
        {
            await _service.UpdateBookings(uniqueId, bookingsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Hotel record for Room
    /// </summary>
    [HttpGet("{Id}/hotel")]
    public async Task<ActionResult<List<Hotel>>> GetHotel(
        [FromRoute()] RoomWhereUniqueInput uniqueId
    )
    {
        var hotel = await _service.GetHotel(uniqueId);
        return Ok(hotel);
    }
}
