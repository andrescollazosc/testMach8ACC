using Mach8.TestACC.Dto;

namespace Mach8.TestACC.Application.Abstractions;

public interface IOperationAppService
{
    ResponseDto Validate(OperationDto parameter);
}
