using System.Collections.Generic;

namespace PSAS.Models
{
  public class Treats
  {
    public int TopicId { get; set; }
    public string Name { get; set; }
    public List<Choice> Choices { get; set; }
  }
}