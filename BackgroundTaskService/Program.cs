using Hangfire;
using Hangfire.PostgreSql;
using Microsoft.OpenApi.Models;
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
        //for local
        .UsePostgreSqlStorage("Host=localhost;Port=5432;Database=KontraktnikDB;Username=postgres;Password=22111964;"));
        //.UsePostgreSqlStorage("Host=localhost;Port=5432;Database=jauynger_db;Username=postgres;Password=passw0rd13!;"));
builder.Services.AddHangfireServer();

builder.Services.AddSwaggerGen(s =>
{
    s.SwaggerDoc("v", new OpenApiInfo
    {
        Version = "v1",
        Title = "HangFireAPI",
        Contact = new OpenApiContact
        {
            Name = "Add BackgroundTask",
            Email = string.Empty,
            //ForTest
            Url = new Uri("https://localhost:7231/api/SendSurvey/recurring")
        }
    });
    //s.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
});

var app = builder.Build();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Configure the HTTP request pipeline.

app.UseDeveloperExceptionPage();

var virDir = app.Configuration.GetSection("VirtualDirectory").Value;

app.UseSwagger();
app.UseSwaggerUI(s =>
{
    s.SwaggerEndpoint(virDir + "/swagger/v1/swagger.json", "serviceAPI");
});

app.UseHangfireDashboard("/hangfire");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
