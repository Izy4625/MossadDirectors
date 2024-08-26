using Microsoft.AspNetCore.Mvc;
using MossadDirectors.Models;
using System.Diagnostics;

namespace MossadDirectors.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly ILogger<HomeController> _logger;
        private static List<Target> targets;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]   
        public async Task<IActionResult> Index()
        {
          targets   = await this._httpClient.GetFromJsonAsync<List<Target>>("http://localhost:5053/Targets");
            return View(targets);
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
