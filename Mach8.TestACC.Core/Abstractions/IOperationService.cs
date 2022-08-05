using Mach8.TestACC.Core.Entities;
using Mach8.TestACC.Core.ValueObjects;

namespace Mach8.TestACC.Core.Abstractions;

public interface IOperationService
{
    IList<ResponseModel> Validate(Operation parameter);
}
