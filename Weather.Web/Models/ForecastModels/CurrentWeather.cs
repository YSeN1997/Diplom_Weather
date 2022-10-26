using System.Text.Json.Serialization;

namespace Weather.Web.Models.ForecastModels
{
    public class CurrentWeather
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("main")]
        public MainModel Main { get; set; }

        [JsonPropertyName("weather")]
        public List<WeatherModel> Weather { get; set; } = new List<WeatherModel>();
            
        [JsonPropertyName("wind")]
        public WindModel Wind { get; set; }

        [JsonPropertyName("pop")]

        public float  Pop { get; set; } 


    }
}
