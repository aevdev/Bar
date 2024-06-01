using Bar.Extensions;
using Bar.Options;
using Bar.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


builder.Services.AddHttpClient(); //этот http клиент уже встроен в ASP, потому нам не надо регистрировать интерфейс IHttpClientFactory, как мы это делали с нашим собственным интерфейсом

//-------------------------------------------------------------------------

builder.Services.AddCoctailApi(options =>
{
    options.BaseUrl = builder.Configuration["CoctailApi:BaseUrl"];
});

var app = builder.Build();

//app.UseHttpsRedirection();//не знаю насколько нужно для API, но пускай будет

app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization(); //не знаю насколько нужно для API и за что отвечает.

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}"
        );
});


//app.MapControllerRoute(
//        name: "default",
//        pattern: "{controller}/{action}"
//        );

app.Run();
