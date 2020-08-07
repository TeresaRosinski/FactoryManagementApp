using System.Collections.Generic; 

namespace Factory.Models
{
  public class Engineer
  {
  public Engineer()
  {
    this.Machines = new HashSet<MachineEngineer>();
  }

  public int EngineerId {get; set;}
  public string Name {get; set; }
  public string Email {get; set; }
  public string Phone {get; set; }
  public string Department {get; set;}

  public ICollection<MachineEngineer> Machines {get; }


  }
}