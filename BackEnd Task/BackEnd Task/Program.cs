using BackEnd_Task.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-T2CJH2U\\SQLEXPRESS;Database=BackEndTaskDb;Trusted_Connection=true;");
});

var app = builder.Build();  

app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.Run();
