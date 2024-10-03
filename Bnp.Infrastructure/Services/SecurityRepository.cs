using Bnp.Domain;
using Bnp.Infrastructure.Interfaces;

namespace Bnp.Infrastructure.Services;

public class SecurityRepository : ISecurityRepository
{
    private List<Security> _securities = new List<Security>();

    public bool AddSecurity(Security security)
    {
        _securities.Add(security);

        return true;
    }

    public bool DeleteSecurity(string isin)
    {
        // find the security

        // delete the security

        return true;
    }

    public List<Security> GetSecurities()
    {
        return _securities.ToList();
    }

    public Security GetSecurity(string isin)
    {
        return _securities.FirstOrDefault(x => x.Isin == isin)!;
    }
}
