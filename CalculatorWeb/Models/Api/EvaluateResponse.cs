using System.Text.Json.Serialization;

namespace CalculatorWeb.Models.Api
{
    public class EvaluateResponse
    {
        [JsonPropertyName("result")]
        public required string Result { get; set; }
    }
}
