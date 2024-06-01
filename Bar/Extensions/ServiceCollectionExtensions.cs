using Bar.Options;
using Bar.Services;

namespace Bar.Extensions
{

    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddCoctailApi(this IServiceCollection services, Action<CocktailApiOptions> options) //добавляем второй параметр в соответствии с тем, как реализован метод Configure, в который мы хотим отправить ключи.
        {
            services.AddScoped<ICocktailApiService, CocktailApiService>();
            services.Configure<CocktailApiOptions>(options);

            return services;
        }
    }
}
