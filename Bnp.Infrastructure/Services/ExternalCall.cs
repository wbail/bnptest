using Bnp.Infrastructure.Interfaces;

namespace Bnp.Infrastructure.Services;

public class ExternalCall : IExternalCall
{
    private readonly string _url = "https://securities.dataprovider.com/securityprice/";

    public async Task<double> GetPrice(string isin)
    {
        var url = $"{ _url }{ isin }";

        // make the call http
        // var result = await _httpClient.GetAsync(url);

        // get the price
        double price = 7;

        return await Task.FromResult(price);
    }
}
