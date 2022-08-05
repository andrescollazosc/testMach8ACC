using Mach8.TestACC.Core.Entities;
using Mach8.TestACC.Core.Exceptions;
using Mach8.TestACC.Core.Services;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Mach8.TestACC.Core.UnitTests.Services;

public class OperationServiceTest
{
    [Fact]
    public void WhenValidateIsCalled_SendNumbersParameterEmpty_ReturnResultEmpty()
    {
        //Arrange
        var operationService = new OperationService();
        var parameter = new Operation()
        {
            Numbers = new List<int>(),            
        };

        //ACT
        var result = operationService.Validate(parameter);

        Assert.True(result.Count == 0);
    }

    [Fact]
    public void WhenValidateIsCalled_SendValueToFindParameterEqualZero_ReturnException()
    {
        //Arrange
        var operationService = new OperationService();
        var parameter = new Operation()
        {
            Numbers = new List<int>()
            {
                1, 2, 3
            },
            ValueToFind = 0
        };

        //ACT
        Assert.Throws<ValidationException>(() => operationService.Validate(parameter));
    }

    [Fact]
    public void WhenValidateIsCalled_SendValidParameters_ReturnSuccessValue()
    {
        //Arrange
        const int EXPECTED = 3;
        var operationService = new OperationService();
        var parameter = new Operation()
        {
            Numbers = new List<int>()
            {
                1, 9, 5, 0, 20, -4, 12, 16, 7
            },
            ValueToFind = 12
        };

        //ACT
        var result = operationService.Validate(parameter).ToList();

        //Assert
        Assert.Equal(EXPECTED, result.Count);
    }
}
