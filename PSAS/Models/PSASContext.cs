using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PSAS.Models
{
  public class PSASContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treats> Treats { get; set; }
    public DbSet<Flavors> Flavors { get; set; }

    public PSASContext(DbContextOptions options) : base(options) { }
  }

}