using MonobankApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MonobankApi
{
    public interface IMonobankService
    {
        Task<ClientInfo> GetClientInfoAsync(string token = null);
        Task<List<Currency>> GetCurrenciesAsync();
        Task<List<Transaction>> GetTransactionsAsync(string accountId, string from, string to = null, string token = null);
    }
}