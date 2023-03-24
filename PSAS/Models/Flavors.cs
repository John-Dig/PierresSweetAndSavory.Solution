using System.Collections.Generic;

namespace PSAS.Models
{
  public class Flavors
  {
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public List<Choice> Choices { get; set; }
  }
}