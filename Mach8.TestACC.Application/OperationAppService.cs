using Mach8.TestACC.Application.Abstractions;
using Mach8.TestACC.Application.Mapping;
using Mach8.TestACC.Core.Abstractions;
using Mach8.TestACC.Dto;

namespace Mach8.TestACC.Application;

public class OperationAppService : IOperationAppService
{
    private readonly IOperationService _operationService;
    private readonly IMapper _mapper;

    public OperationAppService(IOperationService operationService, IMapper mapper) => 
        (_operationService, _mapper) = (operationService, mapper);

    public ResponseDto Validate(OperationDto parameter)
    {
        var domainObject = _mapper.Map(parameter);
        var result = _operationService.Validate(domainObject);

        return _mapper.Map(result.ToList());
    }
}
