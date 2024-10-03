using Bnp.Domain;

namespace Bnp.Infrastructure.Interfaces;

public interface ISecurityRepository
{
    bool AddSecurity(Security security);
    
    bool DeleteSecurity(string isin);
    
    Security GetSecurity(string isin);

    List<Security> GetSecurities();
}
