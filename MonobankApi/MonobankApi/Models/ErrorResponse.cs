using System.Text.Json.Serialization;
namespace MonobankApi.Models
{
    public class ErrorResponse
    {
        [JsonPropertyName("errorDescription")]
        public string ErrorDescription { get; set; }
    }
}