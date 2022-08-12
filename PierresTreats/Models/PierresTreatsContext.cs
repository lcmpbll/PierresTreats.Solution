using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PierresTreats.Models
{
  public class PierresTreatsContext : IdentityDbContext
  {
    public DbSet<Flavor> Flavor { get; set; }
    public DbSet<Treat> Treat { get; set; }
    public DbSet<FlavorTreat> FlavorTreat { get;  set; }

    public PierresTreatsContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}