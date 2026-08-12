using Microsoft.EntityFrameworkCore;
using SasquatchSnacks.Models;

namespace SasquatchSnacks.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // We will add DbSet Properties for each of our models here
    // after we create them in the Models folder. 
    public DbSet<Customer> Customers { get; set; }
}
