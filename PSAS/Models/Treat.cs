using System.Collections.Generic;

namespace PSAS.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public List<Treat> Treats { get; set; }
  }
}