using System.Collections.Generic;

namespace PSAS.Models
{
  public class FlavorTreat
  {
    public int TreatId { get; set; }
    public int FlavorId { get; set; }
    public Treat Treat { get; set; }

    public int FlavorTreatId { get; set; }
    public Flavor Flavor {get; set;}
  }
}