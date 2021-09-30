using System.Text.Json.Serialization;

namespace MonobankApi.Models
{
    public class Currency
    {
        [JsonPropertyName("currencyCodeA")]
        public int CurrencyCodeA { get; set; }
        [JsonPropertyName("currencyCodeB")]
        public int CurrencyCodeB { get; set; }
        [JsonPropertyName("date")]
        public int Date { get; set; }
        [JsonPropertyName("rateBuy")]
        public float RateBuy { get; set; }
        [JsonPropertyName("rateSell")]
        public float RateSell { get; set; }
        [JsonPropertyName("rateCross")]
        public float RateCross { get; set; }
    }
}