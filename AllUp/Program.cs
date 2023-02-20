using AllUp.DataAccessLayer;
using AllUp.interfaces;
using AllUp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    
});
builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<ILayoutService, LayoutService>();
var app = builder.Build();
app.UseSession();
app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=Home}/{action=index}/{id?}");

app.Run();