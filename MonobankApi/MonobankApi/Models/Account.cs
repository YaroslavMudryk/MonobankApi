using System.Text.Json.Serialization;

namespace MonobankApi.Models
{
    public class Account
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("sendId")]
        public string SendId { get; set; }
        [JsonPropertyName("currencyCode")]
        public int CurrencyCode { get; set; }
        [JsonPropertyName("cashbackType")]
        public string CashbackType { get; set; }
        [JsonPropertyName("balance")]
        public int Balance { get; set; }
        [JsonPropertyName("creditLimit")]
        public int CreditLimit { get; set; }
        [JsonPropertyName("maskedPan")]
        public string[] MaskedPan { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("iban")]
        public string Iban { get; set; }
    }
}