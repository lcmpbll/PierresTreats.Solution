using System.Collections.Generic; 

namespace PierresTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntites = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public int Calories { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntites { get; set; }
  }
}