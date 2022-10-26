using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Weather.Web.Models;
using Weather.Web.Services;

namespace Weather.Web.Controllers
{
    public class Homecontroller : Controller
    {
        private readonly IWeatherForecastService _weatherForecastService;
        public Homecontroller(IWeatherForecastService forecastService)
        {
            _weatherForecastService = forecastService;
        }
        public async Task<IActionResult> Index(string search)
        {
            if (string.IsNullOrWhiteSpace(search))
                return View();

            var weatherForecastModel = await _weatherForecastService.FindForecastAsync(search);

            if (weatherForecastModel == null)
            {
                ViewData["Error"] = $"Город \"{search}\" не найден";
                return View();
            }

            return View("Weather", weatherForecastModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}