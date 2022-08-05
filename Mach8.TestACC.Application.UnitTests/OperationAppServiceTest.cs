using Mach8.TestACC.Application.Mapping;
using Mach8.TestACC.Core.Abstractions;
using Mach8.TestACC.Core.Entities;
using Mach8.TestACC.Core.Services;
using Mach8.TestACC.Core.ValueObjects;
using Mach8.TestACC.Dto;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace Mach8.TestACC.Application.UnitTests;

public class OperationAppServiceTest
{
    [Fact]
    public void WhenValidateMethodIsCalled_ThenSendOneArrayLikeAParameter_TheExpectedResultShouldBeEqual3()
    {
        //Arrange
        var mapper = new Mapper();
        var operationService = new OperationService();
        var operationAppService = new OperationAppService(operationService, mapper);

        //Act
        var result = operationAppService.Validate(new OperationDto
        {
            Numbers = new[] { 1, 9, 5, 0, 20, -4, 12, 16, 7 },
            ValueToFind = 12
        });

        //Assert
        Assert.Equal(3, result.Result.Count);
    }    
}
