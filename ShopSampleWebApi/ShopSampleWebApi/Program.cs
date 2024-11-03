using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ShopSampleWebApi.Configurations;
using ShopSampleWebApi.Core.Interfaces;
using ShopSampleWebApi.Core.Mappings;
using ShopSampleWebApi.Core.Services;
using ShopSampleWebApi.DataAccess;
using ShopSampleWebApi.DataAccess.Factories;
using ShopSampleWebApi.DataAccess.Interfaces;
using ShopSampleWebApi.DataAccess.Repositories;
using System.Reflection;

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

// Add controllers and other necessary services.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Configure API versioning.
builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
});

// Configure versioned support for Swagger.
builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV"; // Group format v1, v2.
    options.SubstituteApiVersionInUrl = true; // Substitute API version in URL.
});

// Configure Swagger with support for multiple versions  
builder.Services.AddSwaggerGen(options =>
{
    // Add documentation for each version.  
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Product API V1",
        Description = "API for product management - Version 1"
    });
    options.SwaggerDoc("v2", new OpenApiInfo
    {
        Version = "v2",
        Title = "Product API V2",
        Description = "API for product management - Version 2"
    });

    options.EnableAnnotations(); // Enable annotations  

    // Load XML comments if XML generation is enabled.  
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    options.IncludeXmlComments(xmlPath); // Include XML comments.  
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API V1");
        c.SwaggerEndpoint("/swagger/v2/swagger.json", "Product API V2");
        c.RoutePrefix = "swagger"; 
    });
}

app.UseHttpsRedirection();

// We don't use authentication and authorization right now.
//app.UseAuthentication();
app.UseAuthorization();

//app.UseRouting();
app.MapControllers();

app.Run();
