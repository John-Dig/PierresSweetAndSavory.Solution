using System.Collections.Generic;

namespace PSAS.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public List<Flavor> Flavors {get; set;} //probably remove
    public List<FlavorTreat> JoinEntities { get; }
    public ApplicationUser User {get;set;}
  }
}