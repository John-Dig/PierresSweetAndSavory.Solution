using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PSAS.Models
{
    public DbSet<Topic> Topics { get; set; }
    public DbSet<Choice> Choices { get; set; }
  

    public VoteContext(DbContextOptions options) : base(options) { }
  }
}
