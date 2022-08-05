using Mach8.TestACC.Application.Mapping;
using Mach8.TestACC.Core.ValueObjects;
using Mach8.TestACC.Dto;
using System.Collections.Generic;
using Xunit;

namespace Mach8.TestACC.Application.UnitTests.Mapping;

public class MapperTests
{
    [Fact]
    public void Map_WhenTheParameterIsDto_ThenTheResultMapMustBeAEntity()
    {
        //Arrange
        IMapper mapperMock = new Mapper();

        //Act
        var result = mapperMock.Map(new OperationDto
        {
            Numbers = new[] { 1, 2 },
            ValueToFind = 3
        });

        //Assert
        Assert.NotNull(result);
    }

    [Fact]
    public void Map_WhenTheParameterIsAListFromResultModel_ThenTheResultMapMustBeAResponseDto()
    {
        //Arrange
        IMapper mapperMock = new Mapper();

        //Act
        var result = mapperMock.Map(new List<ResponseModel>
        {
            new ResponseModel { Value1 = 5, Value2 = 7 }
        });

        //Assert
        Assert.True(result.Result.Count > 0);
    }
}
