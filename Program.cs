using Microsoft.EntityFrameworkCore;
using MoviesAdmin.Data;

var builder = WebApplication.CreateBuilder(args);

// Pull connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("MoviesContext")
    ?? throw new InvalidOperationException("Connection string 'MoviesContext' not found.");

// Register DbContext before builder.Build()
builder.Services.AddDbContext<MoviesContext>(options =>
    options.UseSqlServer(connectionString));

// Add MVC controllers + views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Movies}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
