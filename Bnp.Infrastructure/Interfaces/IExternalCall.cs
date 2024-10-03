namespace Bnp.Infrastructure.Interfaces;

public interface IExternalCall
{
    Task<double> GetPrice(string isin);
}
