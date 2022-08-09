using Mach8.TestACC.Core.Entities;
using Mach8.TestACC.Core.ValueObjects;
using Mach8.TestACC.Dto;

namespace Mach8.TestACC.Application.Mapping;

public class Mapper : IMapper
{
    public Operation Map(OperationDto operationDto) =>
        new Operation
        {
            Numbers = operationDto.Numbers.Distinct().ToList(),
            ValueToFind = operationDto.ValueToFind,
        };

    public ResponseDto Map(List<ResponseModel> responseItems)
    {
        var result = new ResponseDto();

        foreach (var item in responseItems)
            result.Result.Add(new ValueDto { Value1 = item.Value1, Value2 = item.Value2 });

        return result;
    }
}
