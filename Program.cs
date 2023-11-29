

using Microsoft.EntityFrameworkCore;
using Modul2Finish.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EFDabaseContext>(db => db.UseMySQL(
    builder.Configuration.GetConnectionString("DefaultConnection")));
// builder.Services.AddScoped<EFDatabaseContext>();
builder.Services.AddScoped<IDataRepository, EFDatabaseRepository>();



var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();

app.MapControllerRoute(
    name:"Default",
    pattern: "{controller=Home}/{action=Index}"
);

app.Run();
