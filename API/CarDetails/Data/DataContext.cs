using CarDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDetails.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Cars> Cars{get; set;}
}
