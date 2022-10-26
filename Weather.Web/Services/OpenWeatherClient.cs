using System.Text.Json;
using System.Text.Json.Nodes;
using Weather.Web.Models.ForecastModels;

namespace Weather.Web.Services
{
    public class OpenWeatherClient
    {
        private HttpClient _httpClient = new HttpClient();
        public async Task<List<ForecastModel>> GetFiveDayForecast(string location)
        {
            var response = await _httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/forecast?q={location}&units=metric&lang=ru&appid=7cf2e3d7155335e9e51b25368ae31eaa");
            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();
            var listNode = JsonNode.Parse(json)["list"];
            var model = JsonSerializer.Deserialize<List<ForecastModel>>(listNode);
            return model;
        }
        public async Task<CurrentWeather> GetCurrentWeather(string location) {
            var response = await _httpClient.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={location}&units=metric&lang=ru&appid=7cf2e3d7155335e9e51b25368ae31eaa");
            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();
            var model = JsonSerializer.Deserialize<CurrentWeather>(json);
            return model;
                }

    }
}
