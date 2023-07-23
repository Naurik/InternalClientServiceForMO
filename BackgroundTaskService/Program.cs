using Hangfire;
using Hangfire.PostgreSql;
using Service.DATA.DataBase.PostgresSQL.RepoInterface;
using Service.DATA.DataBase.PostgresSQL.Repository;
using Service.DATA.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<KontraktnikDbContext>(ServiceLifetime.Scoped);
builder.Services.AddScoped<IOperationRepo, OperationRepo>();


builder.Services.AddHangfire(configuration => configuration
        .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
        .UseSimpleAssemblyNameTypeSerializer()
        .UseRecommendedSerializerSettings()
        .UsePostgreSqlStorage("Host=localhost;Port=5432;Database=Hangfire;Username=postgres;Password=22111964"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHangfireServer();
app.UseHangfireDashboard("/Hangfire");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
