using Bnp.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Bnp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SecuritiesController : ControllerBase
{
    private readonly ISecurityService _securityService;

    public SecuritiesController(ISecurityService securityService)
    {
        _securityService = securityService;
    }

    [HttpGet]
    public IActionResult GetSecurities([FromQuery] string[] isin)
    {
        // TODO: implementation using mediator (mediatr)

        _securityService.GetSecurity(isin);

        return Ok(isin);
    }
}
