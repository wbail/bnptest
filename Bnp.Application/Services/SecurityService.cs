using Bnp.Application.Interfaces;
using Bnp.Application.Validations;
using Bnp.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace Bnp.Application.Services;

public class SecurityService : ISecurityService
{
    private readonly IExternalCall _externalCall;
    private readonly ISecurityRepository _securityRepository;
    private readonly IsinValidations _validations;
    private readonly ILogger<SecurityService> _logger;

    public SecurityService(IExternalCall externalCall, ISecurityRepository securityRepository, IsinValidations validations, ILogger<SecurityService> logger)
    {
        _externalCall = externalCall;
        _securityRepository = securityRepository;
        _validations = validations;
        _logger = logger;
    }

    public async Task GetSecurity(string[] isin)
    {
        foreach (var item in isin)
        {
            var validationResult = await _validations.ValidateAsync(item);

            if (!validationResult.IsValid)
            {
                _logger.LogWarning($"The isin { item } is invalid");
                continue;
            }

            var price = await GetPrice(item);

            _securityRepository.AddSecurity(new Domain.Security
            {
                Isin = item,
                Price = price
            });
        }
    }

    private async Task<double> GetPrice(string isin)
    {
        return await _externalCall.GetPrice(isin);
    }
}
