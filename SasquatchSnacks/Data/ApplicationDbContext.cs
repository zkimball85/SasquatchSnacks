using Microsoft.EntityFrameworkCore;
using SasquatchSnacks.Models;

namespace SasquatchSnacks.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    /// <summary>
    /// Gets or sets the DbSet for Customer entities.
    /// </summary>
    public DbSet<Customer> Customers { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for RentalEquipment entities.
    /// </summary>
    public DbSet<RentalEquipment> RentalEquipment { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for RentalBooking entities.
    /// </summary>
    public DbSet<RentalBooking> RentalBookings { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for ConsumableProduct entities.
    /// </summary>
    public DbSet<ConsumableProduct> ConsumableProducts { get; set; }

    /// <summary>
    /// Gets or sets the DbSet for VendingLocation entities.
    /// </summary>
    public DbSet<VendingLocation> VendingLocations { get; set; }
}
