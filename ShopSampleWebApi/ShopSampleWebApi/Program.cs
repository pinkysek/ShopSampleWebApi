using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ShopSampleWebApi.Configurations;
using ShopSampleWebApi.DataAccess;
using ShopSampleWebApi.DataAccess.Factories;

var builder = WebApplication.CreateBuilder(args);

// Set the environment to "Production".
//builder.Environment.EnvironmentName = "Production";

// Load appsettings.json and then overwrite values from appsettings.{Environment}.json based on the ASPNETCORE_ENVIRONMENT setting.
builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));
//builder.Services.AddSingleton(q =>
//{
//    var databaseSettings = q.GetRequiredService<IOptions<DatabaseSettings>>().Value;
//    return databaseSettings.DatabaseType switch
//    {
//        "InMemory" => DbContextFactory.CreateDbContext(DatabaseType.InMemory),
//        "Real" => DbContextFactory.CreateDbContext(DatabaseType.Real),
//        _ => throw new InvalidOperationException("Unsupported database type.")
//    };
//});


// Register ApplicationDbContext using SQL Server.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    // Load connection string from configuration.
    var databaseSettings = builder.Configuration.GetSection("DatabaseSettings").Get<DatabaseSettings>();

    // Determine the database type from settings.
    var type = databaseSettings?.DatabaseType switch
    {
        "InMemory" => DatabaseType.InMemory,
        "Real" => DatabaseType.Real,
        _ => throw new InvalidOperationException("Unsupported database type.")
    };

    // Configure the DbContext based on the database type.
    var connectionString = databaseSettings?.RealDatabaseConnectionString;
    if (type == DatabaseType.InMemory)
        options.UseInMemoryDatabase("TestDatabase");
    else if (type == DatabaseType.Real && connectionString != null)
        options.UseSqlServer(connectionString);
});

var app = builder.Build();

app.MapGet("/", () => $"Hello World! - Environment: {builder.Environment.EnvironmentName} - DatabaseSettings: {builder.Configuration.GetSection("DatabaseSettings").Get<DatabaseSettings>()}.");

app.Run();
