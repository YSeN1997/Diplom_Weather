using System.Text.Json.Serialization;

namespace Weather.Web.Models.ForecastModels
{
    public class WeatherModel
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("icon")]
        public string Icon { get; set; }
    }
}
