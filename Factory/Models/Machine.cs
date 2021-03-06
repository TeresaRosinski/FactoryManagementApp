using System.Collections.Generic; 
using System.ComponentModel;
using System; 
namespace Factory.Models
{
  public class Machine
  {
    public int MachineId {get; set;}
    public string Name {get; set; }
    public string Description {get; set; }
    public DateTime DatePurchased {get; set; }
    public ICollection <MachineEngineer> Engineers {get; set; }
    public Machine()
    {
      this.Engineers = new HashSet<MachineEngineer>();
    }

  }
}