using Bnp.Application.Services;
using Bnp.Application.Validations;
using Bnp.Domain;
using Bnp.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace Bnp.Application.Tests;

public class SecurityServiceTests
{
    private readonly Mock<IExternalCall> _externalCallMock = new();
    private readonly Mock<ISecurityRepository> _securityRepositoryMock = new();
    private readonly Mock<ILogger<SecurityService>> _loggerMock = new();
    private SecurityService _securityService;

    public SecurityServiceTests()
    {
        _externalCallMock.Setup(x => x.GetPrice(It.IsAny<string>()))
            .ReturnsAsync(7);

        var security = new Security();
        _securityRepositoryMock.Setup(x => x.AddSecurity(security)).Returns(true);

        //mock validations

        _securityService = new SecurityService(_externalCallMock.Object, _securityRepositoryMock.Object, new IsinValidations(), _loggerMock.Object);
    }

    [Fact]
    public async Task Security_Isin_Add_Ok_Into_Database()
    {
        var isin = new string[] { "US0378331005" };

        await _securityService.GetSecurity(isin);

        _securityRepositoryMock.Verify(x => x.AddSecurity(It.IsAny<Security>()), Times.Once);
    }

    [Fact]
    public async Task Security_Isin_Does_Not_Add_Into_Database()
    {
        var isin = new string[] { "iwioufghwuiofhwofhwofhwofhofhwofhwofh" };

        await _securityService.GetSecurity(isin);

        _securityRepositoryMock.Verify(x => x.AddSecurity(It.IsAny<Security>()), Times.Never);
    }
}