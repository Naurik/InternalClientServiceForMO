using Microsoft.EntityFrameworkCore;
using Service.DATA.DataBase.PostgresSQL;
using Service.DATA.DataBase.PostgresSQL.Repository;
using Service.DATA.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<KontraktnikDbContext>(options => options.UseNpgsql("Host=localhost;Port=5432;Database=MO_Candidate;Username=postgres;Password=22111964"));
builder.Services.AddScoped<OperationRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=MO_SendRequest}/{action=SendRequest}/{id?}");

app.Run();
