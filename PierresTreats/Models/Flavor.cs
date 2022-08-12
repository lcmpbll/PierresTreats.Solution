namespace PierresTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.JoinEntities = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    public virtual ApplicationUser User { get; set; }
   
    public virtual ICollerction<FlavorTreat> JoinEntites { get; }
  }
}