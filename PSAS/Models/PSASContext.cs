using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PSAS.Models
{
  public class PSASContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<FlavorTreat> FlavorTreats { get; set; }
    public PSASContext(DbContextOptions<PSASContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      // Create a new user object
      var user = new ApplicationUser
      {
        UserName = "admin",
        Email = "exampleuser@example.com",
      };
      base.OnModelCreating(builder);

      builder.Entity<ApplicationUser>(entity =>
      {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Id).ValueGeneratedOnAdd();
      });

      // Add the user to the Users DbSet and set their password hash
      builder.Entity<ApplicationUser>().HasData(new
      {
        Id = "1",
        UserName = user.UserName,
        NormalizedUserName = user.UserName.ToUpper(),
        Email = user.Email,
        NormalizedEmail = user.Email.ToUpper(),
        EmailConfirmed = true,
        PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(user, "password"),
        SecurityStamp = string.Empty,
        ConcurrencyStamp = string.Empty,
        PhoneNumber = "555-555-5555",
        PhoneNumberConfirmed = false,
        TwoFactorEnabled = false,
        LockoutEmd = "2020-01-01 00:00:00",
        LockoutEnabled = false,
        AccessFailedCount = 0,
      });

      builder.Entity<Treat>()
        .HasData(
          new Treat { TreatId = 1, Name = "Macarons" },
          new Treat { TreatId = 2, Name = "Croissants" },
          new Treat { TreatId = 3, Name = "Creme Brulee" },
          new Treat { TreatId = 4, Name = "Eclairs" },
          new Treat { TreatId = 5, Name = "Madeleines" }
        );
      builder.Entity<Flavor>()
        .HasData(
          new Flavor { FlavorId = 1, Name = "Vanilla" },
          new Flavor { FlavorId = 2, Name = "Chocolate" },
          new Flavor { FlavorId = 3, Name = "Caramel" },
          new Flavor { FlavorId = 4, Name = "Lemon" },
          new Flavor { FlavorId = 5, Name = "Raspberry" },
          new Flavor { FlavorId = 6, Name = "Almond" },
          new Flavor { FlavorId = 7, Name = "Pistachio" },
          new Flavor { FlavorId = 8, Name = "Coffee" },
          new Flavor { FlavorId = 9, Name = "Hazelnut" },
          new Flavor { FlavorId = 10, Name = "Orange" }
        );
    }
  }
}
