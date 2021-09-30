using MonobankApi.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MonobankApi
{
    public class MonobankService : IMonobankService
    {
        private readonly HttpClient _httpClient;
        public MonobankService(string token)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(Constants.Base_Url),
                Timeout = TimeSpan.FromMinutes(1)
            };
            _httpClient.DefaultRequestHeaders.Add(Constants.X_Token, token);
        }

        public async Task<ClientInfo> GetClientInfoAsync(string token = null)
        {
            if (!string.IsNullOrEmpty(token))
                _httpClient.DefaultRequestHeaders.Add(Constants.X_Token, token);
            var response = await _httpClient.GetAsync(Constants.Routes.Client_Info);
            if (response.IsSuccessStatusCode)
                return JsonSerializer.Deserialize<ClientInfo>(await response.Content.ReadAsStringAsync());
            return null;
        }

        public async Task<List<Currency>> GetCurrenciesAsync()
        {
            var response = await _httpClient.GetAsync(Constants.Routes.Currency_Rate);
            if (response.IsSuccessStatusCode)
                return JsonSerializer.Deserialize<List<Currency>>(await response.Content.ReadAsStringAsync());
            return null;
        }

        public async Task<List<Transaction>> GetTransactionsAsync(string accountId, string from, string to = null, string token = null)
        {
            if (!string.IsNullOrEmpty(token))
                _httpClient.DefaultRequestHeaders.Add(Constants.X_Token, token);
            var url = string.Format(Constants.Routes.Transactions, accountId, from, to);
            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
                return JsonSerializer.Deserialize<List<Transaction>>(await response.Content.ReadAsStringAsync());
            return null;
        }
    }
}