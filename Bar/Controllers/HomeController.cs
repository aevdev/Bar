using Microsoft.AspNetCore.Mvc;
using Bar.Models;
using Bar.Services;
using System.Text.Json;

namespace Bar.Controllers
{
    public class HomeController : Controller
    {

        private readonly ICocktailApiService cocktailApiService;

        public HomeController(ICocktailApiService cocktailApiService)
        {
            this.cocktailApiService = cocktailApiService;
        }
        /*------------------------------------------------------------------------------------*/
        public async Task<IActionResult> Index()
        {
            //var result = await cocktailApiService.GetPageAsync();
            //return View(result);

            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://barwebapp.free.beeceptor.com/");
            var result = await response.Content.ReadAsStringAsync();
            var cocktails = JsonSerializer.Deserialize<List<Cocktail>>(result);
            return View(cocktails);

            //return View();
        }

        public async Task<IActionResult> Details(string searchId)
        {
            searchId = "0"; // временное решение

            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://barwebapp.free.beeceptor.com/?={searchId}");
            var result = await response.Content.ReadAsStringAsync();
            var cocktail = JsonSerializer.Deserialize<Cocktail>(result);
            return View(cocktail);
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        public async Task<IActionResult> Signin()
        {
            return View();
        }

        public async Task<IActionResult> Profile(string userId)
        {
            userId = "us1"; //временное решение

            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://barwebapp.free.beeceptor.com/account?={userId}");
            var result = await response.Content.ReadAsStringAsync();
            var cocktail = JsonSerializer.Deserialize<User>(result);
            return View(cocktail);
        }
    }
}
