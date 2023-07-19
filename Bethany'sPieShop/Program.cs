using Bethany_sPieShop.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();


builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BethanysPieShopDbContext>(options =>{
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:BethanysPieShopDbContextConnection"]);
});


var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapDefaultControllerRoute(); //"{Controller=Home}/{action=index}/{id?}"SS
DbInitializer.Seed(app);
app.Run();
