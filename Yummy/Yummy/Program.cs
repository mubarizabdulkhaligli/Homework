using Microsoft.EntityFrameworkCore;
using Yummy.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<YummyDBContext>(opt =>
{
    opt.UseSqlServer("Server=WIN-V54CU0NE9TB; Database=YummyDatabase; Trusted_Connection=True");
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
