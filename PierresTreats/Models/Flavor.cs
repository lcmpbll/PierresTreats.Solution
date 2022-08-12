using System.Collections.Generic;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    public int Name { get; set; }
    public int Calories { get; set; }
    public string Description { get; set; }
    public virtual ApplicationUser User { get; set; }
   
    public virtual ICollection<FlavorTreat> JoinEntities { get; }
  }
}