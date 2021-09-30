using System.Text.Json.Serialization;

namespace MonobankApi.Models
{
    public class ClientInfo
    {
        [JsonPropertyName("clientId")]
        public string Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("webHookUrl")]
        public string WebHookUrl { get; set; }
        [JsonPropertyName("permissions")]
        public string Permissions { get; set; }
        [JsonPropertyName("accounts")]
        public Account[] Accounts { get; set; }
    }
}