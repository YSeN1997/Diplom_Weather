using System.Globalization;
using System.Text.Json.Serialization;
using Weather.Web.Services;



namespace Weather.Web.Models.ForecastModels
{
    public class ForecastModel
    {
        [JsonIgnore]

        public DateTime Date
        {
            get
            {
                return DateTime.ParseExact(TextDate, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            }
        }
        [JsonPropertyName("dt_txt")]
        public string TextDate { get; set; }
        [JsonPropertyName("main")]
        public MainModel Main { get; set; }
        [JsonPropertyName("weather")]
        public List<WeatherModel> Weather { get; set; } = new List<WeatherModel>();
        
    }

}
