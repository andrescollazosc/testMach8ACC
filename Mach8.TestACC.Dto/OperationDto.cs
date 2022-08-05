namespace Mach8.TestACC.Dto;

public class OperationDto
{
    public IList<int> Numbers { get; set; } = new List<int>();
    public int ValueToFind { get; set; }
}
