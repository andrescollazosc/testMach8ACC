namespace Mach8.TestACC.Core.Entities;

public class Operation 
{ 
    public IList<int> Numbers { get; set; } = new List<int>();
    public int ValueToFind { get; set; }
}
