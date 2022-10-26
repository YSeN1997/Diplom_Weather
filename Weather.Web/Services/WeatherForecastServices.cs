using Weather.Web.Models.ForecastModels;

namespace Weather.Web.Services
{
    public interface IWeatherForecastService
    {
        Task<ViewModel> FindForecastAsync(string search);
    }
    internal class WeatherForecastServices : IWeatherForecastService

    {
        private readonly OpenWeatherClient _openWeatherClient = new();
        public async Task<ViewModel> FindForecastAsync(string search)
        {
            var forecasts = await _openWeatherClient.GetFiveDayForecast(search);
            var currentWeather = await _openWeatherClient.GetCurrentWeather(search);

            if (forecasts == null || currentWeather == null)
                return null;

            return new ViewModel
            {
                CurrentWeather = currentWeather,
                Forecasts = forecasts
            };
        }
    }
}
