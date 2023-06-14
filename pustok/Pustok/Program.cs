using Microsoft.EntityFrameworkCore;
using Pustok.DAL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PustokDbContext>(opt =>
{
    opt.UseSqlServer("Server=WIN-V54CU0NE9TB; Database=Pustok; Trusted_Connection=True");
});

var app = builder.Build();




app.UseStaticFiles();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
