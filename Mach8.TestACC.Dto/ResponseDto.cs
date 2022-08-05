namespace Mach8.TestACC.Dto;

public class ResponseDto
{
    public IList<ValueDto> Result { get; set; } = new List<ValueDto>();
}

public class ValueDto
{
    public int? Value1 { get; set; }
    public int? Value2 { get; set; }
}

