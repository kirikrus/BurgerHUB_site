using BurgerHUB.Data;
using BurgerHUB.Data.Interfaces;
using BurgerHUB.Data.Models;
using BurgerHUB.Mocks;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<IMenu, MockMenu>();
builder.Services.AddTransient<IClients, MockClients>();
builder.Services.AddMvc();
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("Myserver"));
    //options.UseSqlServer("Server=localhost;Database=BurgerHubData2;Trusted_Connection=True; TrustServerCertificate=true");
});


    var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    Seed.SeedData(dbContext);
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapControllers();
});

app.Run();
