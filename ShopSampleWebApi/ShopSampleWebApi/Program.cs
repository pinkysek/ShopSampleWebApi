using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopSampleWebApi.Configurations;
using ShopSampleWebApi.Core.Interfaces;
using ShopSampleWebApi.Core.Mappings;
using ShopSampleWebApi.Core.Services;
using ShopSampleWebApi.DataAccess;
using ShopSampleWebApi.DataAccess.Factories;
using ShopSampleWebApi.DataAccess.Interfaces;
using ShopSampleWebApi.DataAccess.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Register AutoMapper with the specified mapping profile.
builder.Services.AddAutoMapper(typeof(ProductMappingProfile)); 

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

// Register all necessary repositories or services for Dependency Injection.
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

// Configure API versioning.
builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true; // Include version information in the response output
    options.AssumeDefaultVersionWhenUnspecified = true; // Use the default version if none is specified
    options.DefaultApiVersion = new ApiVersion(1, 0); // Default version if none is specified
});

// Add controllers and other necessary services.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => $"Hello World! - Environment: {builder.Environment.EnvironmentName} - DatabaseSettings: {builder.Configuration.GetSection("DatabaseSettings").Get<DatabaseSettings>()}.");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// We don't use authentication and authorization right now.
//app.UseAuthentication();
//app.UseAuthorization();

app.UseRouting();
app.MapControllers();

app.Run();
