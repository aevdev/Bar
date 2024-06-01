using Bar.Models;

namespace Bar.Services
{
    public interface ICocktailApiService
    {
        Task<CocktailApiResponse> GetPageAsync();
    }
}
