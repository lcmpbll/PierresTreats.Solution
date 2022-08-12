using System.ComponentModel.DataAnnotations.Schema;
namespace PierresTreats.Models
{
  public class FlavorTreat
  {
    public int FlavorTreatId { get; set; }
    public int FlavorId { get; set; }
    public int TreatId { get; set; }
    public virtual Flavor Flavor { get; set; }
    public virtual Treat Treat { get; set; }
    [NotMapped]
    public int Calories { get { return Flavor.Calories + Treat.Calories;} }
     [NotMapped]
    public string FlavorTreatName { get { return Flavor.Name +"y " + Treat.Name;} }
  }
}