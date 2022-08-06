using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pro690P2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pro690P2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            Response res = new Response();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/forecast.json?q=Toronto&days=3"),
                Headers =
                    {
                        { "X-RapidAPI-Key", "4d355fe7ebmshe082b05ff4b2432p13cb10jsn728d554a9a8f" },
                        { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                res = JsonSerializer.Deserialize<Response>(body);
            }
            return View(res);
        }
        public IActionResult About()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            System.Environment.FailFast("Error happened");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
