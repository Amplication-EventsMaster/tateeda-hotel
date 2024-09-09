using HotelBooking.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Infrastructure;

public class HotelBookingDbContext : IdentityDbContext<IdentityUser>
{
    public HotelBookingDbContext(DbContextOptions<HotelBookingDbContext> options)
        : base(options) { }

    public DbSet<HotelDbModel> Hotels { get; set; }

    public DbSet<RoomDbModel> Rooms { get; set; }

    public DbSet<BookingDbModel> Bookings { get; set; }

    public DbSet<CustomerDbModel> Customers { get; set; }
}
