namespace Weather.Web.Models.ForecastModels
{
    public class ViewModel
    {
        public List<ForecastModel> Forecasts { get; set; }
        public CurrentWeather CurrentWeather { get; set; }
    }
}
