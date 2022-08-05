using Mach8.TestACC.Core.Entities;
using Mach8.TestACC.Core.ValueObjects;
using Mach8.TestACC.Dto;

namespace Mach8.TestACC.Application.Mapping;

public interface IMapper
{
    Operation Map(OperationDto operationDto);
    ResponseDto Map(List<ResponseModel> responseItems);
}
