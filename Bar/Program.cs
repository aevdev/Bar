using Bar.Extensions;
using Bar.Options;
using Bar.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


builder.Services.AddHttpClient(); //���� http ������ ��� ������� � ASP, ������ ��� �� ���� �������������� ��������� IHttpClientFactory, ��� �� ��� ������ � ����� ����������� �����������

//-------------------------------------------------------------------------

builder.Services.AddCoctailApi(options =>
{
    options.BaseUrl = builder.Configuration["CoctailApi:BaseUrl"];
});

var app = builder.Build();

//app.UseHttpsRedirection();//�� ���� ��������� ����� ��� API, �� ������ �����

app.UseStaticFiles();
app.UseRouting();

app.UseAuthorization(); //�� ���� ��������� ����� ��� API � �� ��� ��������.

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
