using Bar.Models;
using Microsoft.Extensions.Options;
using Bar.Options;
using System.Text.Json;

namespace Bar.Services
{
    public class CocktailApiService : ICocktailApiService
    {
        public string BaseUrl { get; set; }
        //public CocktailApiOptions CocktailApiOptions { get; set; }
        public HttpClient HttpClient { get; set; }
        public CocktailApiService()
        {
            //BaseUrl = "https://omdbapi.com/";
            HttpClient = new HttpClient();
            //CocktailApiOptions = options.Value;
            //HttpClient = httpClientFactory.CreateClient();
        }
        public async Task<CocktailApiResponse> GetPageAsync()
        {
            var response = await HttpClient.GetAsync($"{BaseUrl}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<CocktailApiResponse>(json);
            return result;

            //CocktailApiResponse result;
            //var response = await HttpClient.GetAsync($"{CocktailApiOptions.BaseUrl}");
            //var json = await response.Content.ReadAsStringAsync();
            //result = JsonSerializer.Deserialize<CocktailApiOptions>(json);

            //if (result.Response == "False")
            //    throw new Exception(result.Error);
            //return result;
        }

        public async Task<CocktailApiResponse> GetDetail(int searchId)
        {
            var response = await HttpClient.GetAsync($"{BaseUrl}?={searchId}");
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<CocktailApiResponse>(json);
            return result;

            //CocktailApiResponse result;
            //var response = await HttpClient.GetAsync($"{CocktailApiOptions.BaseUrl}");
            //var json = await response.Content.ReadAsStringAsync();
            //result = JsonSerializer.Deserialize<CocktailApiOptions>(json);

            //if (result.Response == "False")
            //    throw new Exception(result.Error);
            //return result;
        }
    }
}
