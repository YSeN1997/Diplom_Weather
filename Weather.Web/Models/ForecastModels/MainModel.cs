using System.Text.Json.Serialization;

namespace Weather.Web.Models.ForecastModels
{
    public class MainModel
    {
      
        [JsonPropertyName("temp")]
        public float Temp { get; set; }

        [JsonPropertyName("feels_like")]
        public double FleelsLike { get; set; }

        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }

    }
}
