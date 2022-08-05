using Mach8.TestACC.Application.Abstractions;
using Mach8.TestACC.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Mach8.TestACC.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OperationController : ControllerBase
{
    private readonly IOperationAppService _operationAppService;

    public OperationController(IOperationAppService operationAppService) => _operationAppService = operationAppService;

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<ResponseDto> GetValues([FromBody] OperationDto operationDto)
    {
        try
        {
            var result = _operationAppService.Validate(operationDto);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
