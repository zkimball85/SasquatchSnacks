using Microsoft.EntityFrameworkCore;
using SasquatchSnacks.Models;

namespace SasquatchSnacks.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
}
