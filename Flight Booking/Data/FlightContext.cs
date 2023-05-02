using demo1.Models;
using Microsoft.EntityFrameworkCore;
using PaymentDetails.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace Flight_Booking_System.Data
{
    public class FlightContext : DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<FlightDetail> FlightDetails { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<Seat> Seats { get; set; }

    }
}
