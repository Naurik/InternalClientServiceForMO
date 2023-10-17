using Service.DATA.DataBase.PostgresSQL.RepoInterface;
using Service.DATA.DataBase.PostgresSQL.Repository;
using Service.DATA.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<KontraktnikDbContext>(ServiceLifetime.Scoped);
builder.Services.AddScoped<IOperationRepo, OperationRepo>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

app.Run();
