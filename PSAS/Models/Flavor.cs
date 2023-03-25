using System.Collections.Generic;

namespace PSAS.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public List<Flavor> Flavors { get; set; }
  }
}