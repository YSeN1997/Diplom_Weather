using System.Text.Json.Serialization;

namespace Weather.Web.Models.ForecastModels
{
    public class WindModel
    {
        [JsonPropertyName("speed")]
        public double Speed { get; set; }
    }
}
