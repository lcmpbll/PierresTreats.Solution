using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProjectName.Models
{
  public class ProjectNameContext : IdentityDbContext
  {
    public DbSet<CLassOne> ClassOne { get; set; }
    public DbSet<ClassTwo> ClassTwo { get; set; }
    public DbSet<ClassOneClassTwo> ClassOneClassTwo { get;  set; }

    public ProjectNameContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}