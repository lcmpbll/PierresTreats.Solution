namespace PierresTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.JoinEntites = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }
    public virtual ICollection<FlavorTreat> JoinEntites { get; set; }
  }
}