namespace Bnp.Application.Interfaces;

public interface ISecurityService
{
    Task GetSecurity(string[] isin);
}
