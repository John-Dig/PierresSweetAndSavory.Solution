using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PSAS.Models
{
  public class PSASContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<FlavorTreat> FlavorTreats { get; set; }
    public PSASContext(DbContextOptions options) : base(options) { }
  }

}